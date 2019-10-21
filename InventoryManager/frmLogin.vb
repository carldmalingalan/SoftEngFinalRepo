Public Class frmLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text <> "" And txtPassword.Text <> "") Then
            Call Login(txtUsername.Text, txtPassword.Text)
            If (login_name <> "") Then
                If (login_accountstatus <> "INACTIVE") Then
                    If (txtPassword.Text = "admin12345") Then
                        Dim ask = MsgBox("Your account is in default state. Please provide a new password.", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
                        If (ask = vbYes) Then
                            frmPasswordChange.Show()
                            Me.Close()
                        End If
                    Else
                        frmMenu.Show()
                        Me.Close()
                    End If
                Else
                    MsgBox("Your account is inactive. Please contact an administrator.", MsgBoxStyle.Information, Application.ProductName)
                End If
            Else
                MsgBox("Invalid username or password.", MsgBoxStyle.Critical, Application.ProductName)
            End If
        Else
            MsgBox("Please complete fields.", MsgBoxStyle.Exclamation, Application.ProductName)
        End If
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Call btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        frmForgotPassword.showdialog()
    End Sub
End Class
