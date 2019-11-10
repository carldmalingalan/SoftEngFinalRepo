Imports System.Data.SqlClient

Public Class frmItemQuantity
    Dim flag1 As Boolean
    Private Sub frmItemQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadItemlIst()
        If (btnType = "EDIT") Then
            txtQuantityOut.Text = quantitycheckout
        End If
    End Sub
    Private Sub Initializeflag()
        flag1 = True
    End Sub

    Private Sub loadItemlIst()
        lblTxn.Text = "Trans#" & lastTransID
        Call ConnectTOSQLServer()
        strSQL = "select * from vw_InventoryView where ItemID = " & itemNumber
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.Read()
            lblName.Text = reader.GetString(1)
            If (btnType = "EDIT") Then
                lblQty.Text = checkoutqty
            Else
                lblQty.Text = CStr(reader.GetDecimal(2))
            End If
            lblCateg.Text = reader.GetString(5)
            lblDesc.Text = reader.GetString(4)
        Loop
        reader.NextResult()
        Call DisConnectSQLServer()
    End Sub

    Private Sub Validation()
        If CDec(txtQuantityOut.Text.Trim) > CDec(lblQty.Text) Then
            ErrorProvider1.SetError(txtQuantityOut, "Quantity must be lower than stored value.")
            ErrorProvider1.SetIconPadding(txtQuantityOut, 5)
            flag1 = False
        ElseIf (txtQuantityOut.Text.Trim = "") Then
            ErrorProvider1.SetError(txtQuantityOut, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtQuantityOut, 5)
            flag1 = False
        ElseIf (Not IsNumeric(txtQuantityOut.Text.Trim)) Then
            ErrorProvider1.SetError(txtQuantityOut, "Only numberic characters are allowed.")
            ErrorProvider1.SetIconPadding(txtQuantityOut, 5)
            flag1 = False
        ElseIf (CDec(txtQuantityOut.Text.Trim) < 1) Then
            ErrorProvider1.SetError(txtQuantityOut, "Quantity must be atleast 1.")
            ErrorProvider1.SetIconPadding(txtQuantityOut, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtQuantityOut, "")
        End If
    End Sub

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        Initializeflag()
        Validation()
        If (flag1 = False) Then
            Exit Sub
        End If
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            checkoutqty = txtQuantityOut.Text.Trim
            Call AddCheckOut(checkoutqty)
            Call UpdateItemThruTransaction(checkoutqty)
            Me.Close()
        End If
    End Sub

    Private Sub frmItemQuantity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmShowCheckoutlist.Enabled = True
    End Sub
End Class