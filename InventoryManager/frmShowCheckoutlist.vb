Imports System.Data.SqlClient

Public Class frmShowCheckoutlist

    Private selectedRow As Integer

    Private Sub frmShowCheckoutlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loadCheckoutitems()
        Call ConnectTOSQLServer()
        strSQL = "select * from vw_checkout where TransactionNumber = " & lastTransID
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim CheckoutList As New DataSet()
        dataadapter.Fill(CheckoutList, "vw_checkout")
        dgvItemForCheckOut.DataSource = CheckoutList
        dgvItemForCheckOut.DataMember = "vw_checkout"
        Call DisConnectSQLServer()
    End Sub
    Private Sub dgvItemForCheckOut_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemForCheckOut.CellContentClick, dgvItemForCheckOut.CellClick
        If (dgvItemForCheckOut.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub


End Class