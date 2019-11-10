Imports System.Data.SqlClient

Public Class frmItemManager


    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean
    Private critPoint As String
    Private ExpiDate As Object
    Private ExpiDateforUpdate, CritPointForUpdate As Object

    Private Sub frmItemManager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Enabled = True
    End Sub

    Private Sub checkboxExpirationNA_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxExpirationNA.CheckedChanged
        If (checkboxExpirationNA.Checked = True) Then
            dtpExpirationDate.CustomFormat = " "  'An empty SPACE
            dtpExpirationDate.Format = DateTimePickerFormat.Custom
            dtpExpirationDate.Enabled = False
        Else
            dtpExpirationDate.CustomFormat = "MM/dd/yyyy"  'An empty SPACE
            dtpExpirationDate.Format = DateTimePickerFormat.Custom
            dtpExpirationDate.Enabled = True
        End If
    End Sub


    Dim itemclass As String

    Private Sub cbCritPointNA_CheckedChanged(sender As Object, e As EventArgs) Handles cbCritPointNA.CheckedChanged
        If (cbCritPointNA.Checked = True) Then
            txtCriticalPoint.Enabled = False
        Else
            txtCriticalPoint.Enabled = True
        End If
    End Sub

    Private Sub frmItemManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (saveType1 = 2) Then
            GatherDataForUpdate()
        End If
    End Sub

    Private Sub GatherDataForUpdate()
        Call ConnectTOSQLServer()
        strSQL = "select ItemID,Name,Quantity,[Critical Point], [Description],Classification, [AccountName] as [Added By],CreationDate from vw_InventoryView where ItemID = '" & itemID & "'"
        cmd = New SqlCommand(strSQL, Connection)
        Console.WriteLine(itemID)
        Console.WriteLine(strSQL)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtItemName.Text = reader.GetString(1).Trim
            txtItemQuantity.Text = reader.GetValue(2)
            If reader.IsDBNull(3) Then
                cbCritPointNA.Checked = True
                txtCriticalPoint.Enabled = False
            Else
                cbCritPointNA.Checked = False
                txtCriticalPoint.Enabled = True
                txtCriticalPoint.Text = reader.GetValue(3)
            End If
            txtDescription.Text = reader.GetString(4).Trim
            If (reader.GetString(5) = "Body") Then
                rdoBody.Checked = True
            ElseIf (reader.GetString(5) = "Hair") Then
                rdoHair.Checked = True
            ElseIf (reader.GetString(5) = "Face") Then
                rdoFace.Checked = True
            ElseIf (reader.GetString(5) = "Nails") Then
                rdoNails.Checked = True
            End If

        End While
        reader.Close()
        Call DisConnectSQLServer()
    End Sub

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
        ElseIf (rdoFace.Checked) Then
            itemclass = "FACE"
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
        If (cbCritPointNA.Checked = False) Then
            If txtCriticalPoint.Text.Trim = "" Then
                ErrorProvider1.SetError(cbCritPointNA, "Blank field is not allowed.")
                ErrorProvider1.SetIconPadding(cbCritPointNA, 5)
                flag3 = False
            ElseIf txtCriticalPoint.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
                ErrorProvider1.SetError(cbCritPointNA, "Special characters are not allowed in this field.")
                ErrorProvider1.SetIconPadding(cbCritPointNA, 5)
                flag3 = False
            ElseIf IsNumeric(txtCriticalPoint.Text) = False Then
                ErrorProvider1.SetError(cbCritPointNA, "Numeric characters only are the characters allowed in this field.")
                ErrorProvider1.SetIconPadding(cbCritPointNA, 5)
                flag3 = False
            Else
                ErrorProvider1.SetError(cbCritPointNA, "")
            End If
        End If
    End Sub

    Private Sub DateValidation()
        If dtpExpirationDate.Value.ToString("MM/dd/yyyy") < Date.Today.AddDays(1) And saveType1 = 1 Then
            ErrorProvider1.SetError(checkboxExpirationNA, "Expiration Date must not be backdated.")
            ErrorProvider1.SetIconPadding(checkboxExpirationNA, 5)
            flag7 = False
        Else
            ErrorProvider1.SetError(checkboxExpirationNA, "")
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

    Private Function GetGroupBoxCheckedButton(grpb As GroupBox) As RadioButton
        Dim rButton As RadioButton = grpb.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        InitializeFlags()
        ItemDescriptionValidation()
        ItemNameValidation()
        ItemQuantityValidation()
        RoleValidation()
        DateValidation()

        If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Or flag7 = False Or flag8 = False Then
            MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
            Exit Sub
        End If
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If (ask = vbYes) Then
            If (checkboxExpirationNA.Checked = False) Then
                ExpiDate = dtpExpirationDate.Value.ToString("MM/dd/yyyy")
            Else
                ExpiDate = DBNull.Value
            End If
            If (cbCritPointNA.Checked = False) Then
                critPoint = CDec(txtCriticalPoint.Text.Trim)
            Else
                critPoint = Nothing
            End If
            If (saveType1 = 1) Then
                Call AddItem(txtItemName.Text.Trim, txtItemQuantity.Text.Trim, txtDescription.Text.Trim, GetGroupBoxCheckedButton(groupBoxRole).Text, critPoint, ExpiDate)
                MsgBox("Successfully added item.", MsgBoxStyle.Information, Application.ProductName)
                logInfo = "Added a new item successfully."
                Call RecordLog(logInfo)
            ElseIf (saveType1 = 2) Then
                Call UpdateItem(txtItemName.Text, txtItemQuantity.Text.Trim, txtDescription.Text.Trim, GetGroupBoxCheckedButton(groupBoxRole).Text, critPoint, ExpiDate, itemID)
                logInfo = "Updated an item successfully."
                Call RecordLog(logInfo)
                MsgBox("Successfully updated item.", MsgBoxStyle.Information, Application.ProductName)
            End If
            frmMenu.Enabled = True

            Me.Close()
        End If
    End Sub
End Class