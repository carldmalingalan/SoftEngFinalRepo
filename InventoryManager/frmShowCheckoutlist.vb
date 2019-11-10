Imports System.Data.SqlClient

Public Class frmShowCheckoutlist
    Public Property SelectedRows As DataGridViewSelectedRowCollection
    Private selectedRow, selected_RowCheckOut As Integer
    Private cond As String


    Private Sub frmShowCheckoutlist_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadItemList()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cond = " and Name like '%" & txtSearchname.Text.Trim.Replace("-", "") & "%'"
        loadItemList()
    End Sub

    Private Sub loadItemList()
        Call ConnectTOSQLServer()
        strSQL = "select ItemID,Name,Quantity,Classification from vw_InventoryView where Quantity > 0" & cond
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim SearchList As New DataSet()
        dataadapter.Fill(SearchList, "vw_InventoryView")
        dgvSearchItem.DataSource = SearchList
        dgvSearchItem.DataMember = "vw_InventoryView"
        Call DisConnectSQLServer()
    End Sub

    Private Sub dgvSearchItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchItem.CellContentClick, dgvSearchItem.CellClick
        If (dgvSearchItem.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                Console.WriteLine(selectedRow)
                itemNumber = dgvSearchItem.Rows(selectedRow).Cells(1).Value()
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub dgvItemForCheckOut_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemForCheckOut.CellContentClick, dgvItemForCheckOut.CellClick
        If (dgvItemForCheckOut.Rows.Count > 0) Then
            Try
                selected_RowCheckOut = e.RowIndex
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dgvSearchItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchItem.CellDoubleClick, dgvSearchItem.CellContentDoubleClick
        If (dgvSearchItem.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                itemNumber = dgvSearchItem.Rows(selectedRow).Cells(0).Value()
                Me.Enabled = False
                Console.WriteLine(itemNumber)
                Dim ab As New frmItemQuantity
                ab.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub loadItemHasbeenCheckout()
        Call ConnectTOSQLServer()
        strSQL = "select CheckOutID, TransactionNumber as Trans#, ItemID, [Item Name],[Quantity Used] from vw_Checkout where TransactionNumber = " & lastTransID
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim CheckoutList As New DataSet()
        dataadapter.Fill(CheckoutList, "vw_Checkout")
        dgvItemForCheckOut.DataSource = CheckoutList
        dgvItemForCheckOut.DataMember = "vw_Checkout"
        Call DisConnectSQLServer()
    End Sub

    Private Sub frmShowCheckoutlist_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        loadItemList()
        loadItemHasbeenCheckout()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        If (selected_RowCheckOut >= 0) Then
            Dim ask = MsgBox("Are you sure you want to edit the quantity in the checkout?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                btnType = "EDIT"
                itemIDCheckout = dgvItemForCheckOut.Rows(selected_RowCheckOut).Cells(2).Value()
                quantitycheckout = dgvItemForCheckOut.Rows(selected_RowCheckOut).Cells(4).Value()
                Me.Enabled = False
                Console.WriteLine(itemIDCheckout)
                Dim ab As New frmItemQuantity
                ab.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ask = MsgBox("Are you sure you are done?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If (selected_RowCheckOut >= 0) Then
            Dim ask = MsgBox("Are you sure you want to remove this item in the checkout?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                checkoutiD = dgvItemForCheckOut.Rows(selected_RowCheckOut).Cells(0).Value()
                quantitycheckout = dgvItemForCheckOut.Rows(selected_RowCheckOut).Cells(4).Value()
                itemIDCheckout = dgvItemForCheckOut.Rows(selected_RowCheckOut).Cells(2).Value()
                Call RemoveItemCheckout()
                MsgBox("Successfully removed item.", MsgBoxStyle.Information, Application.ProductName)
                loadItemList()
                loadItemHasbeenCheckout()
            End If
        End If
    End Sub
End Class