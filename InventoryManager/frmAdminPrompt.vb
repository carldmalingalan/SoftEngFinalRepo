Imports System.Data.SqlClient

Public Class frmAdminPrompt
    Private loginbool As String
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If (txtUsername.Text <> "" And txtPassword.Text <> "") Then
            Call ConnectTOSQLServer()
            loginbool = ""
            strSQL = "select * from tblLogins where Username = @Username and Password = @Password and AccessType = 'Administrator'"
            cmd = New SqlCommand(strSQL, Connection)
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = GetHash(txtPassword.Text)
            reader = cmd.ExecuteReader()
            Console.WriteLine(strSQL)
            While reader.Read()
                loginbool = CStr(reader.GetInt32(0))
            End While
            If (loginbool <> "") Then
                VoidTransaction(voidID)
            Else
                MsgBox("Invalid credentials!", MsgBoxStyle.Exclamation, Application.ProductName)
            End If
            Call DisConnectSQLServer()
            Me.Close()
        Else
                MsgBox("Invalid credentials!", MsgBoxStyle.Exclamation, Application.ProductName)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class