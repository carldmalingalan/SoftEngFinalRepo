Imports System.Data.SqlClient

Public Class frmSearchCustomer
    Private selectedRow As Integer

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call viewrecords()
        Dim count = dgvSearchList.RowCount.ToString
        lblResultCount.Text = "Found " + count + " results."
    End Sub

    Private Sub viewrecords()
        Call ConnectTOSQLServer()
        If (txtSearchname.Text.Trim <> "") Then
            strSQL = "select CustomerID, Lastname, Firstname, [Middle Initial] from tblCustomer where Lastname like  '%" & txtSearchname.Text.Trim.Replace("-", "") & "%'  or Firstname like  '%" & txtSearchname.Text.Trim.Replace("-", "") & "%'"
        Else
            strSQL = "select CustomerID, Lastname, Firstname, [Middle Initial] from tblCustomer"
        End If
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim SearchList As New DataSet()
        dataadapter.Fill(SearchList, "tblCustomer")
        dgvSearchList.DataSource = SearchList
        dgvSearchList.DataMember = "tblCustomer"
        Call DisConnectSQLServer()
    End Sub

    Private Sub dgvSearchList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchList.CellClick, dgvSearchList.CellContentClick
        If (dgvSearchList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dgvSearchList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchList.CellDoubleClick, dgvSearchList.CellContentDoubleClick
        If (dgvSearchList.Rows.Count > 0) Then
            Dim ask = MsgBox("Are you sure you want to use this customer?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If (ask = vbYes) Then
                customerNumber = dgvSearchList.Rows(selectedRow).Cells(0).Value()
                ParentForm.Width = 497
            End If
            Console.WriteLine(customerNumber)
        End If
    End Sub



    Private Sub frmSearchCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewrecords()
    End Sub

End Class