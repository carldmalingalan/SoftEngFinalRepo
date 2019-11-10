Imports System.Data.SqlClient

Public Class frmSearchItemCheckout
    Private cond As String
    Private selectedRow As Integer
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
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dgvSearchItem_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchItem.CellContentDoubleClick, dgvSearchItem.CellDoubleClick
        If (dgvSearchItem.Rows.Count > 0) Then
            Dim ask = MsgBox("Are you sure this item has been used?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If (ask = vbYes) Then
                itemNumber = dgvSearchItem.Rows(selectedRow).Cells(0).Value()
                Dim ab As New frmItemQuantity
                ab.ShowDialog()
            End If
            Console.WriteLine(itemNumber)
        End If
    End Sub

    Private Sub frmItemCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadItemList()
    End Sub

    Private Sub frmSearchItemCheckout_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
        frmItemCheckout_Load(sender, e)
    End Sub

    Private Sub btnShowItemCheckedOut_Click(sender As Object, e As EventArgs) Handles btnShowItemCheckedOut.Click

    End Sub
End Class