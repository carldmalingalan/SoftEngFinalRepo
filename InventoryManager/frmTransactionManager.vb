Imports System.Data.SqlClient

Public Class frmTransactionManager
    Private selectedRow As Integer
    Public Sub LoadiTems()
        Call ConnectTOSQLServer()
        strSQL = "select EmployeeID,Fullname from tblEmployeeList where EmployeeStatus = 'TRUE' order by EmployeeID"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                cboEmployeeAssigned.Items.Add(reader.GetString(1))
            Loop
            reader.NextResult()
        Loop
        reader.Close()

        strSQL = "select ServiceID,Name from tblServices"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                cboServiceAvailed.Items.Add(reader.GetString(1))
            Loop
            reader.NextResult()
        Loop
        reader.Close()

        Call DisConnectSQLServer()
    End Sub

    Private Sub btnSaveTransaction_Click(sender As Object, e As EventArgs)
        If (txtCustFirstname.Text <> "" And txtCustLastname.Text <> "" And txtCustMiddlename.Text <> "" And cboEmployeeAssigned.SelectedIndex = -1 And cboServiceAvailed.SelectedIndex = -1) Then
            Dim ask = MsgBox("Do you want to continue saving this transaction?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                '  Call AddTransaction(txtCustomer.Text, cboBody.CheckState, cboHair.CheckState, cboNails.CheckState, cboServiceAvailed.SelectedValue, cboEmployeeAssigned.SelectedValue, txtRemarks.Text)
                MsgBox("Successfully added transaction.", MsgBoxStyle.Information, Application.ProductName)
                Call clearfields()
            End If
        Else
            MsgBox("Invalid entry. Please complete details.", MsgBoxStyle.Critical, Application.ProductName)
        End If
    End Sub

    Private Sub clearfields()
        txtCustFirstname.Text = ""
        txtCustLastname.Text = ""
        txtCustMiddlename.Text = ""
        txtCustomerNumber.Text = ""
        txtRemarks.Text = ""
        gbTransDetails.Enabled = False
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        gbTransDetails.Enabled = True
        Me.Width = 497
    End Sub

    Private Sub btnExistingCustomer_Click(sender As Object, e As EventArgs) Handles btnExistingCustomer.Click
        Me.Width = 926
    End Sub

    Private Sub txtCustMiddlename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustMiddlename.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmTransactionManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 497
        LoadiTems()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call viewrecords()
        Dim count = dgvSearchList.RowCount.ToString
        lblResultCount.Text = "Found " + count + " results."
    End Sub

    Private Sub viewrecords()
        Call ConnectTOSQLServer()
        strSQL = "select CustomerID, Lastname, Firstname, [Middle Initial] from tblCustomer where Lastname like '%@searchtext%' or Firstname like '%@searchtext%'"
        cmd.Parameters.AddWithValue("@searchtext", SqlDbType.VarChar).Value = txtSearchname.Text
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim SearchList As New DataSet()
        dataadapter.Fill(SearchList, "tblCustomer")
        dgvSearchList.DataSource = SearchList
        dgvSearchList.DataMember = "tblCustomer"
        ' dgvSearchList.Rows(4).Visible = False
        Call DisConnectSQLServer()
    End Sub

    Private Sub dgvSearchList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchList.CellContentClick, dgvSearchList.CellClick
        If (dgvSearchList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dgvSearchList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchList.CellContentDoubleClick, dgvSearchList.CellDoubleClick
        If (dgvSearchList.Rows.Count > 0) Then
            Dim ask = MsgBox("Are you sure you want to use this customer?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If (ask = vbYes) Then
                txtCustomerNumber.Text = dgvSearchList.Rows(selectedRow).Cells(1).Value()
                txtCustLastname.Text = dgvSearchList.Rows(selectedRow).Cells(2).Value()
                txtCustFirstname.Text = dgvSearchList.Rows(selectedRow).Cells(3).Value()
                txtCustMiddlename.Text = dgvSearchList.Rows(selectedRow).Cells(4).Value()
                Me.Width = 497
            End If
        End If
    End Sub

    Private Sub btnCancelTransaction_Click(sender As Object, e As EventArgs) Handles btnCancelTransaction.Click
        Me.Close()
    End Sub
End Class