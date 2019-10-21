Imports System.Data.SqlClient

Public Class frmForgotPassword

    Private Sub FillComboBox()
        Call ConnectTOSQLServer()

        strSQL = "SELECT  [Question],[QuestionID]  FROM [JandA2].[dbo].[tblSecretQuestion] order by [QuestionID] "
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                cboSecretQuestion.Items.Add(reader.GetString(0))
            Loop
            reader.NextResult()
        Loop
        reader.Close()
        Call DisConnectSQLServer()
    End Sub

    Private Sub btnRecover_click(sender As Object, e As EventArgs) Handles btnRecover.Click
        If (txtUsername.Text <> "" And txtAnswer.Text <> "" And cboSecretQuestion.SelectedIndex >= 0) Then
            Call ConnectTOSQLServer()
            strSQL = "select AccountName,AccountID,Username,AccessType,AccountType as AccountStatus from tbllogins where SecretQuestion = @SecretQ and Username = @Username and Answer = @Answer"
            Dim strSql2 = "select AccountName,AccountID,Username,AccessType,AccountType as AccountStatus from tbllogins where SecretQuestion = '" & cboSecretQuestion.SelectedIndex + 1 & "' and Username = '" & txtUsername.Text & "' and Answer = '" & txtAnswer.Text & "'"
            Console.WriteLine(strSql2)
            cmd = New SqlCommand(strSQL, Connection)
            cmd.Parameters.AddWithValue("@SecretQ", SqlDbType.VarChar).Value = cboSecretQuestion.SelectedIndex + 1
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.AddWithValue("@Answer", SqlDbType.VarChar).Value = txtAnswer.Text
            reader = cmd.ExecuteReader()
            Try
                If reader.HasRows Then
                    If reader.Read() Then
                        login_name = reader.GetString(0)
                        login_id = reader.GetInt32(1)
                        login_username = reader.GetString(2)
                        login_accesstype = reader.GetString(3)
                        login_accountstatus = reader.GetString(4)
                        Console.WriteLine(login_name)
                        reader.Close()

                    End If

                    strSQL = "update tblLogins set Password = @Default where AccountID = @AccountID"
                        cmd = New SqlCommand(strSQL, Connection)
                        cmd.Parameters.AddWithValue("@Default", SqlDbType.VarChar).Value = defaultPassword
                        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.Int).Value = login_id
                        cmd.ExecuteNonQuery()
                        Console.WriteLine(strSQL)
                        MsgBox("Successfully reset password to default.", MsgBoxStyle.Information, Application.ProductName)
                        Me.Close()
                    Else
                        MsgBox("No records founds.", MsgBoxStyle.Information, Application.ProductName)
                End If
            Finally
                reader.Close()
            End Try
            reader.Close()
        Else
            Console.WriteLine(cboSecretQuestion.SelectedIndex)

            MsgBox("Please complete all fields", MsgBoxStyle.Exclamation, Application.ProductName)
        End If
        Call DisConnectSQLServer()

    End Sub

    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call FillComboBox()
        cboSecretQuestion.SelectedIndex = -1
    End Sub
End Class