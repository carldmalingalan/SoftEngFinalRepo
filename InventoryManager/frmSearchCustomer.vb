Imports System.Data.SqlClient

Public Class frmSearchCustomer
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call viewrecords()
    End Sub

    Private Sub viewrecords()
        Call ConnectTOSQLServer()
        strSQL = "select Lastname, Firstname, [Middle Initial], CustomerID from tblCustomer where Lastname like '%@searchtext%' or Firstname like '%@searchtext%'"
        cmd.Parameters.AddWithValue("@searchtext", SqlDbType.VarChar).Value = txtSearchname.Text
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim SearchList As New DataSet()
        dataadapter.Fill(SearchList, "tblCustomer")
        dgvSearchList.DataSource = SearchList
        dgvSearchList.DataMember = "tblCustomer"
        dgvSearchList.Rows(4).Visible = False
        Call DisConnectSQLServer()
    End Sub


End Class