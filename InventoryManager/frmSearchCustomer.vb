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

    Private Sub dgvSearchList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchList.CellDoubleClick, dgvSearchList.CellDoubleClick
        If (dgvSearchList.Rows.Count > 0) Then
            Dim ask = MsgBox("Are you sure you want to use this customer?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If (ask = vbYes) Then
                customerNumber = dgvSearchList.Rows(selectedRow).Cells(0).Value()
                'frmTransactionManager.txtCustomerNumber.Text = dgvSearchList.Rows(selectedRow).Cells(0).Value()
                'frmTransactionManager.txtCustLastname.Text = dgvSearchList.Rows(selectedRow).Cells(1).Value()
                'frmTransactionManager.txtCustFirstname.Text = dgvSearchList.Rows(selectedRow).Cells(2).Value()
                'frmTransactionManager.txtCustMiddlename.Text = dgvSearchList.Rows(selectedRow).Cells(3).Value()
                'frmTransactionManager.gbTransDetails.Enabled = True
                'frmTransactionManager.txtCustFirstname.Enabled = False
                'frmTransactionManager.txtCustLastname.Enabled = False
                'frmTransactionManager.txtCustMiddlename.Enabled = False
                frmTransactionManager.Width = 497
            End If
        End If
    End Sub

    Private Sub frmSearchCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewrecords()
    End Sub

End Class