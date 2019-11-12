Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

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

    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Validation()
        If CDec(txtQuantityOut.Text.Trim) > CDec(lblQty.Text) Then
            ErrorProvider1.SetError(txtQuantityOut, "Quantity must be lower than stored value.")
            ErrorProvider1.SetIconPadding(txtQuantityOut, 5)
            flag1 = False
        ElseIf (txtQuantityOut.Text.Trim = "") Then
            ErrorProvider1.SetError(txtQuantityOut, "Blank field is not allowed.")
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
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            Initializeflag()
            Validation()
            If (flag1 = False) Then
                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
                Exit Sub
            End If
            checkoutqty = txtQuantityOut.Text.Trim
            Call AddCheckOut(checkoutqty)
            Call UpdateItemThruTransaction(checkoutqty)
            frmShowCheckoutlist.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub frmItemQuantity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmShowCheckoutlist.Enabled = True
    End Sub



    Private Sub txtQuantityOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityOut.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class