Imports System.Data.SqlClient

Public Class frmAdminPrompt
    Private loginbool As Int32
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If (txtUsername.Text <> "" And txtPassword.Text <> "") Then
            Call ConnectTOSQLServer()
            loginbool = ""
            strSQL = "select * from tblLogins where Username = @Username and Password = @Password"
            cmd = New SqlCommand(strSQL, Connection)
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = GetHash(txtPassword.Text)
            reader = cmd.ExecuteReader()
            If reader.HasRows = True Then
                loginbool = reader.GetInt32(0)
            End If

            If (loginbool > 0) Then
                strSQL = "update tblTransactions set DataStatus = 'INACTIVE' where TransactionID = " & voidID
            Else
                MsgBox("Invalid credentials!", MsgBoxStyle.Exclamation, Application.ProductName)
            End If
            Call DisConnectSQLServer()
        Else
                MsgBox("Invalid credentials!", MsgBoxStyle.Exclamation, Application.ProductName)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class