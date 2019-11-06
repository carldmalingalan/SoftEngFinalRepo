Imports System
Imports System.Data.SqlClient

Public Class frmTransactionManager
    Private selectedRow, choicetype As Integer
    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean
    Dim indexChecked As String
    Dim headline As String


    Private Sub frmTransactionManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 497
        LoadiTems2()
        clearfields()
        clbServices.MultiColumn = False
        clbServices.MultiColumn = True
    End Sub


    Private Sub LoadiTems2()
        Call ConnectTOSQLServer()
        'strSQL = "select ServiceID, Name from tblServices where Status = '1' order by ServiceId"
        'Dim da As New SqlDataAdapter(strSQL, Connection)
        'Dim table As New DataTable()
        'da.Fill(table)
        'cboServiceAvailed.DataSource = New BindingSource(table, Nothing)
        'cboServiceAvailed.DisplayMember = "Name"
        ''write the column name which will be diplayed
        ''you can even use  valueMember property, 
        ''Names - DisplayMember - this is was you see in comboBox
        ''IDs - ValueMember can be used as additional value of Person
        'cboServiceAvailed.ValueMember = "ServiceID"
        ''column name for value 

        strSQL = "select * from tblServices where Status = 1 "
        'Fill the DataTable with records from Table.
        Dim da21 As New SqlDataAdapter(strSQL, Connection)
        Dim dt As DataTable = New DataTable()
        da21.Fill(dt)
        'Assign DataTable as DataSource.
        clbServices.DataSource = dt
        clbServices.DisplayMember = "Name"
        clbServices.ValueMember = "ServiceID"

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

    'Private Sub btnSaveTransaction_Click(sender As Object, e As EventArgs)
    '    If (txtCustFirstname.Text <> "" And txtCustLastname.Text <> "" And txtCustMiddlename.Text <> "" And cboEmployeeAssigned.SelectedIndex = -1 And cboServiceAvailed.SelectedIndex = -1) Then
    '        Dim ask = MsgBox("Do you want to continue saving this transaction?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
    '        If ask = vbYes Then
    '            '  Call AddTransaction(txtCustomer.Text, cboBody.CheckState, cboHair.CheckState, cboNails.CheckState, cboServiceAvailed.SelectedValue, cboEmployeeAssigned.SelectedValue, txtRemarks.Text)
    '            MsgBox("Successfully added transaction.", MsgBoxStyle.Information, Application.ProductName)
    '            Call clearfields()
    '        End If
    '    Else
    '        MsgBox("Invalid entry. Please complete details.", MsgBoxStyle.Critical, Application.ProductName)
    '    End If
    'End Sub

    Private Sub OpenPanel(ByVal Childform As Object)
        If Panel1.Controls.Count > 0 Then
            Panel1.Controls.RemoveAt(0)
        End If
        Dim fh1 As Form = TryCast(Childform, Form)
        fh1.TopLevel = False
        fh1.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh1.Dock = DockStyle.Fill
        Panel1.Controls.Add(fh1)
        Panel1.Tag = fh1
        fh1.Show()
    End Sub

    Private Sub clearfields()
        txtCustFirstname.Text = ""
        txtCustLastname.Text = ""
        txtCustMiddlename.Text = ""
        txtCustomerNumber.Text = ""
        txtRemarks.Text = ""
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
        OpenPanel(New frmSearchCustomer)
    End Sub

    Private Sub txtCustMiddlename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustMiddlename.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnChecklistBox_Click(sender As Object, e As EventArgs) Handles btnChecklistBox.Click
        If (clbServices.Visible = False) Then
            clbServices.Visible = True
            clbServices.Left = 159
            clbServices.Top = 154
        ElseIf (clbServices.Visible = True) Then
            clbServices.Visible = False
            clbServices.Left = 159
            clbServices.Top = 154
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
                Call ConnectTOSQLServer()

                For i As Integer = 0 To clbServices.Items.Count - 1
                    If (clbServices.GetItemChecked(i)) Then
                        Dim dtrv As DataRowView = CType(clbServices.Items(i), DataRowView)
                        Dim dtr As DataRow = dtrv.Row
                        Dim dtrValueMember As String = dtr(clbServices.ValueMember).ToString()
                        strSQL = "insert into tblTransactions(Date,ServiceID,EmployeeID,CustomerID,CreationDate,CreatedBy,DataStatus,ModdedBy,ModdedDate,Remarks)values(convert(varchar,getdate(),110),@ServiceID,@EmployeeID,@CustomerID,getdate(),@Creator,'ACTIVE',@Modder,getdate(),@Remarks)"
                        cmd = New SqlCommand(strSQL, Connection)
                        cmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = cboEmployeeAssigned.SelectedValue
                        cmd.Parameters.AddWithValue("@CustomerID", SqlDbType.Int).Value = lastIdentity
                        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = txtRemarks.Text
                        cmd.Parameters.AddWithValue("@Creator", SqlDbType.Int).Value = login_id
                        cmd.Parameters.AddWithValue("@Modder", SqlDbType.Int).Value = login_id
                        cmd.Parameters.AddWithValue("@ServiceID", SqlDbType.Int).Value = dtrValueMember
                        cmd.ExecuteNonQuery()
                    End If
                Next

                Call DisConnectSQLServer()
                    MsgBox("Successfully created transaction.", MsgBoxStyle.Information, Application.ProductName)
                frmTransactions.Enabled = True
                Me.Close()
                ElseIf (choicetype = 2) Then
                '          Call AddTransaction(cboServiceAvailed.SelectedValue, txtCustomerNumber.Text, cboEmployeeAssigned.SelectedValue, txtRemarks.Text)
                For i As Integer = 0 To clbServices.Items.Count - 1
                    If (clbServices.GetItemChecked(i)) Then
                        Dim dtrv As DataRowView = CType(clbServices.Items(i), DataRowView)
                        Dim dtr As DataRow = dtrv.Row
                        Dim dtrValueMember As String = dtr(clbServices.ValueMember).ToString()
                        strSQL = "insert into tblTransactions(Date,ServiceID,EmployeeID,CustomerID,CreationDate,CreatedBy,DataStatus,ModdedBy,ModdedDate,Remarks)values(convert(varchar,getdate(),110),@ServiceID,@EmployeeID,@CustomerID,getdate(),@Creator,'ACTIVE',@Modder,getdate(),@Remarks)"
                        cmd = New SqlCommand(strSQL, Connection)
                        cmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = cboEmployeeAssigned.SelectedValue
                        cmd.Parameters.AddWithValue("@CustomerID", SqlDbType.Int).Value = txtCustomerNumber.Text
                        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = txtRemarks.Text
                        cmd.Parameters.AddWithValue("@Creator", SqlDbType.Int).Value = login_id
                        cmd.Parameters.AddWithValue("@Modder", SqlDbType.Int).Value = login_id
                        cmd.Parameters.AddWithValue("@ServiceID", SqlDbType.Int).Value = dtrValueMember
                        cmd.ExecuteNonQuery()
                    End If
                Next
                MsgBox("Successfully created transaction.", MsgBoxStyle.Information, Application.ProductName)
                frmTransactions.Enabled = True
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
    End Sub

    Private Sub btnCancelTransaction_Click(sender As Object, e As EventArgs) Handles btnCancelTransaction.Click
        Me.Close()
    End Sub
End Class