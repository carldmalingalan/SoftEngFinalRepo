Imports System.Data.SqlClient

Public Class frmCreateAccount
    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean

    Private Sub frmCreateAccount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Enabled = True
    End Sub


    Dim role As String
    Private Sub InitializeFlags()

        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True
        flag5 = True
        flag6 = True
        flag7 = True
        flag8 = True

    End Sub

    Private Sub RoleValidation()
        If (rdoAdministrator.Checked) Then
            role = "ADMINISTRATOR"
        ElseIf (rdoInventory.Checked) Then
            role = "INVENTORY"
        ElseIf (rdoTransactions.Checked) Then
            role = "TRANSACTIONS"
        Else
            ErrorProvider1.SetError(groupBoxRole, "Please choose a role access.")
            ErrorProvider1.SetIconPadding(groupBoxRole, 5)
            flag8 = False
        End If
    End Sub
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If (ask = vbYes) Then
            InitializeFlags()
            FirstNameValidation()
            LastNameValidation()
            UsernameValidation()
            RoleValidation()

            If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Or flag7 = False Or flag8 = False Then

                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
                Exit Sub
            End If
            If (saveType = 1) Then
                Call CreateAccount(txtUsername.Text, txtLastname.Text, txtFirstname.Text, role)
                MsgBox("Account has been successfully created with default password, admin12345.", MsgBoxStyle.Information, Application.ProductName)
                frmMenu.Enabled = True
                Me.Close()
            ElseIf (saveType = 2) Then
                Call UpdateAccount(txtUsername.Text, txtLastname.Text, txtFirstname.Text, role, accountID)
                MsgBox("Account has been successfully update.", MsgBoxStyle.Information, Application.ProductName)
                frmMenu.Enabled = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FirstNameValidation()

        If txtFirstname.Text.Trim = "" Then

            ErrorProvider1.SetError(txtFirstname, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False

        ElseIf txtFirstname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtFirstname, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False

        ElseIf IsNumeric(txtFirstname.Text) = True Or txtFirstname.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtFirstname, "Numeric characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False

        Else
            ErrorProvider1.SetError(txtFirstname, "")
        End If
    End Sub
    Private Sub LastNameValidation()

        If txtLastname.Text.Trim = "" Then

            ErrorProvider1.SetError(txtLastname, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False

        ElseIf txtLastname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtLastname, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False

        ElseIf IsNumeric(txtLastname.Text) = True Or txtLastname.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtLastname, "Numeric characters are not characters allowed in this field.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False

        Else

            ErrorProvider1.SetError(txtLastname, "")

        End If

    End Sub
    Private Sub UsernameValidation()

        If txtUsername.Text.Trim = "" Then

            ErrorProvider1.SetError(txtUsername, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        ElseIf txtUsername.Text.IndexOfAny(restrictedCharactersForUsername) > -1 Then

            ErrorProvider1.SetError(txtUsername, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        ElseIf txtUsername.Text.IndexOfAny("-_1234567890") = 0 Then

            ErrorProvider1.SetError(txtUsername, "The first character must be a letter.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        ElseIf txtUsername.Text.Length < 3 Then

            ErrorProvider1.SetError(txtUsername, "Username must be at least 3 characters.")
            ErrorProvider1.SetIconPadding(txtUsername, 3)
            flag5 = False

        Else
            ErrorProvider1.SetError(txtUsername, "")
            Call ConnectTOSQLServer()
            strSQL = "select * from tblLogins where Username = @Username"
            cmd = New SqlCommand(strSQL, Connection)
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = txtUsername.Text
            reader = cmd.ExecuteReader

            If (reader.HasRows) Then
                ErrorProvider1.SetError(txtUsername, "Username is already taken.")
                ErrorProvider1.SetIconPadding(txtUsername, 3)
                flag5 = False
                Call DisConnectSQLServer()
            Else
                Call DisConnectSQLServer()
            End If
        End If
    End Sub
End Class