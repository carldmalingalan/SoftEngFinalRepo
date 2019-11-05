Imports System.Data.SqlClient

Public Class frmTransactionManager
    Private selectedRow, choicetype As Integer
    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean

    Private Sub frmTransactionManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 497
        LoadiTems2()
        clearfields()
    End Sub


    Private Sub LoadiTems2()
        Call ConnectTOSQLServer()
        strSQL = "select ServiceID, Name from tblServices where Status = '1' order by ServiceId"
        Dim da As New SqlDataAdapter(strSQL, Connection)
        Dim table As New DataTable()
        da.Fill(table)
        cboServiceAvailed.DataSource = New BindingSource(table, Nothing)
        cboServiceAvailed.DisplayMember = "Name"
        'write the column name which will be diplayed
        'you can even use  valueMember property, 
        'Names - DisplayMember - this is was you see in comboBox
        'IDs - ValueMember can be used as additional value of Person
        cboServiceAvailed.ValueMember = "ServiceID"
        'column name for value 

        strSQL = "select EmployeeID,Fullname from tblEmployeeList where EmployeeStatus = '1' order by EmployeeID"
        Dim da2 As New SqlDataAdapter(strSQL, Connection)
        Dim table2 As New DataTable()
        da2.Fill(table2)
        cboEmployeeAssigned.DataSource = New BindingSource(table2, Nothing)
        cboEmployeeAssigned.DisplayMember = "Fullname"
        'write the column name which will be diplayed
        'you can even use  valueMember property, 
        'Names - DisplayMember - this is was you see in comboBox
        'IDs - ValueMember can be used as additional value of Person
        cboEmployeeAssigned.ValueMember = "EmployeeID"
        'column name for value 
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
        cboServiceAvailed.SelectedIndex = -1
        cboEmployeeAssigned.SelectedIndex = -1
        gbTransDetails.Enabled = False
        txtCustMiddlename.Enabled = True
        txtCustLastname.Enabled = True
        txtCustFirstname.Enabled = True
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        choicetype = 1
        clearfields()
        gbTransDetails.Enabled = True
        Me.Width = 497
    End Sub

    Private Sub btnExistingCustomer_Click(sender As Object, e As EventArgs) Handles btnExistingCustomer.Click
        choicetype = 2
        gbTransDetails.Enabled = False
        clearfields()
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call viewrecords()
        Dim count = dgvSearchList.RowCount.ToString
        lblResultCount.Text = "Found " + count + " results."
    End Sub

    Private Sub viewrecords()
        Call ConnectTOSQLServer()
        If (txtSearchname.Text.Trim <> "") Then
            strSQL = "select CustomerID, Lastname, Firstname, [Middle Initial] from tblCustomer where Lastname like '%@searchtext%' or Firstname like '%@searchtext%'"
        Else
            strSQL = "select CustomerID, Lastname, Firstname, [Middle Initial] from tblCustomer"
        End If

        cmd.Parameters.AddWithValue("@searchtext", SqlDbType.VarChar).Value = txtSearchname.Text
        Console.WriteLine(strSQL)
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
                txtCustomerNumber.Text = dgvSearchList.Rows(selectedRow).Cells(0).Value()
                txtCustLastname.Text = dgvSearchList.Rows(selectedRow).Cells(1).Value()
                txtCustFirstname.Text = dgvSearchList.Rows(selectedRow).Cells(2).Value()
                txtCustMiddlename.Text = dgvSearchList.Rows(selectedRow).Cells(3).Value()
                Me.Width = 497
                gbTransDetails.Enabled = True
                txtCustFirstname.Enabled = False
                txtCustLastname.Enabled = False
                txtCustMiddlename.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSaveTransaction_Click_1(sender As Object, e As EventArgs) Handles btnSaveTransaction.Click
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If (ask = vbYes) Then
            InitializeFlags()
            FirstNameValidation()
            LastNameValidation()
            ComboboxValidation()
            If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Or flag7 = False Or flag8 = False Then
                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
                Exit Sub
            End If

            If (choicetype = 1) Then
                Call AddCustomer(txtCustLastname.Text, txtCustFirstname.Text, txtCustMiddlename.Text)
                txtCustomerNumber.Text = lastIdentity
                Call AddTransaction(cboServiceAvailed.SelectedValue, txtCustomerNumber.Text, cboEmployeeAssigned.SelectedValue, txtRemarks.Text)
                MsgBox("Successfully created transaction.", MsgBoxStyle.Information, Application.ProductName)
                frmMenu.Enabled = True
                Me.Close()
            ElseIf (choicetype = 2) Then
                Call AddTransaction(cboServiceAvailed.SelectedValue, txtCustomerNumber.Text, cboEmployeeAssigned.SelectedValue, txtRemarks.Text)
                MsgBox("Successfully created transaction.", MsgBoxStyle.Information, Application.ProductName)
                frmMenu.Enabled = True
                Me.Close()
            End If

        End If
    End Sub

    Private Sub InitializeFlags()
        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True
        flag5 = True
        flag6 = True
        flag7 = True
        flag8 = True
    End Sub

    Private Sub LastNameValidation()
        If txtCustLastname.Text.Trim = "" Then
            ErrorProvider1.SetError(txtCustLastname, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtCustLastname, 5)
            flag2 = False
        ElseIf txtCustLastname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtCustLastname, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtCustLastname, 5)
            flag2 = False
        ElseIf IsNumeric(txtCustLastname.Text) = True Or txtCustLastname.Text.IndexOfAny("1234567890") > -1 Then
            ErrorProvider1.SetError(txtCustLastname, "Numeric characters are not characters allowed in this field.")
            ErrorProvider1.SetIconPadding(txtCustLastname, 5)
            flag2 = False
        Else
            ErrorProvider1.SetError(txtCustLastname, "")
        End If
    End Sub

    Private Sub FirstNameValidation()
        If txtCustFirstname.Text.Trim = "" Then
            ErrorProvider1.SetError(txtCustFirstname, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtCustFirstname, 5)
            flag1 = False
        ElseIf txtCustFirstname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtCustFirstname, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtCustFirstname, 5)
            flag1 = False
        ElseIf IsNumeric(txtCustFirstname.Text) = True Or txtCustFirstname.Text.IndexOfAny("1234567890") > -1 Then
            ErrorProvider1.SetError(txtCustFirstname, "Numeric characters are not characters allowed in this field.")
            ErrorProvider1.SetIconPadding(txtCustFirstname, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtCustFirstname, "")
        End If
    End Sub

    Private Sub ComboboxValidation()
        If cboEmployeeAssigned.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cboEmployeeAssigned, "Please assign an Employee.")
            ErrorProvider1.SetIconPadding(cboEmployeeAssigned, 5)
            flag3 = False
        Else
            ErrorProvider1.SetError(cboEmployeeAssigned, "")
        End If
        If cboServiceAvailed.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cboServiceAvailed, "Please select a Service.")
            ErrorProvider1.SetIconPadding(cboServiceAvailed, 5)
            flag4 = False
        Else
            ErrorProvider1.SetError(cboServiceAvailed, "")
        End If

    End Sub

    Private Sub btnCancelTransaction_Click(sender As Object, e As EventArgs) Handles btnCancelTransaction.Click
        Me.Close()
    End Sub
End Class