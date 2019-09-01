Public Class frmItemManager


    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean

    Private Sub frmItemManager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Enabled = True
    End Sub

    Dim itemclass As String
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
        If (rdoNails.Checked) Then
            itemclass = "NAILS"
        ElseIf (rdoHair.Checked) Then
            itemclass = "HAIR"
        ElseIf (rdoBody.Checked) Then
            itemclass = "BODY"
        Else
            ErrorProvider1.SetError(groupBoxRole, "Please choose a item type.")
            ErrorProvider1.SetIconPadding(groupBoxRole, 5)
            flag8 = False
        End If
    End Sub

    Private Sub ItemNameValidation()
        If txtItemName.Text.Trim = "" Then

            ErrorProvider1.SetError(txtItemName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtItemName, 5)
            flag1 = False

        ElseIf txtItemName.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtItemName, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtItemName, 5)
            flag1 = False

        ElseIf IsNumeric(txtItemName.Text) = True Or txtItemName.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtItemName, "Numeric characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtItemName, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtItemName, "")
        End If
    End Sub

    Private Sub ItemQuantityValidation()

        If txtItemQuantity.Text.Trim = "" Then
            ErrorProvider1.SetError(txtItemQuantity, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtItemQuantity, 5)
            flag2 = False
        ElseIf txtItemQuantity.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtItemQuantity, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtItemQuantity, 5)
            flag2 = False
        ElseIf IsNumeric(txtItemQuantity.Text) = False Then
            ErrorProvider1.SetError(txtItemQuantity, "Numeric characters only are the characters allowed in this field.")
            ErrorProvider1.SetIconPadding(txtItemQuantity, 5)
            flag2 = False
        Else
            ErrorProvider1.SetError(txtItemQuantity, "")
        End If
    End Sub

    Private Sub ItemDescriptionValidation()

        If txtDescription.Text.Trim = "" Then
            ErrorProvider1.SetError(txtDescription, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtDescription, 3)
            flag5 = False
        Else
            ErrorProvider1.SetError(txtDescription, "")
        End If
    End Sub
    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click

        InitializeFlags()
        ItemDescriptionValidation()
            ItemNameValidation()
            ItemQuantityValidation()
            RoleValidation()

            If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Or flag7 = False Or flag8 = False Then
                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
                Exit Sub
            End If
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If (ask = vbYes) Then

            If (saveType1 = 1) Then
                Call AddItem(txtItemName.Text, txtItemQuantity.Text, txtDescription.Text, itemclass)
                MsgBox("Successfully added item.", MsgBoxStyle.Information, Application.ProductName)
            ElseIf (saveType1 = 2) Then
                Call UpdateItem(txtItemName.Text, txtItemQuantity.Text, txtDescription.Text, itemclass, itemID)
                MsgBox("Successfully update item.", MsgBoxStyle.Information, Application.ProductName)
            End If
            frmMenu.Enabled = True
            Me.Close()
        End If
    End Sub
End Class