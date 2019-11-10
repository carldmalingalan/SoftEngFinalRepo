Imports System.Data.SqlClient

Public Class frmItemQuantity
    Dim flag1 As Boolean
    Private Sub frmItemQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadItemlIst()
    End Sub
    Private Sub Initializeflag()
        flag1 = True
    End Sub

    Private Sub loadItemlIst()
        lblTxn.Text = "Trans#" & lastTransID
        Call ConnectTOSQLServer()
        strSQL = "select * from vw_InventoryView where ItemID = '" & itemNumber & "'"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.Read()
            lblName.Text = reader.GetString(1)
            lblQty.Text = CStr(reader.GetDecimal(2))
            lblDesc.Text = reader.GetString(4)
            lblCateg.Text = reader.GetString(5)
        Loop
        reader.NextResult()
        Call DisConnectSQLServer()
    End Sub

    Private Sub Validation()
        If txtQuantityOut.Text.Trim > lblQty.Text Then
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
        If (ask = vbYes) Then
            Call AddCheckOut(txtQuantityOut.Text.Trim)
            Call UpdateItemThruTransaction(txtQuantityOut.Text.Trim)
            Close()
        End If
    End Sub
End Class