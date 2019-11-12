Imports System
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class frmTransactionManager
    Private selectedRow, choicetype As Integer
    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean
    Dim indexChecked As String
    Dim headline As String
    Private cfName, cLName, cMName As String
    Private i As Integer

    Private Sub frmTransactionManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 497
        LoadiTems2()
        clearfields()
        clbServices.MultiColumn = False
        clbServices.MultiColumn = True
    End Sub


    Private Sub LoadiTems2()
        Call ConnectTOSQLServer()

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
        cboEmployeeAssigned.ValueMember = "EmployeeID"
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

    Private Sub getcustomerdata()
        Call ConnectTOSQLServer()
        strSQL = "SELECT CustomerID, Lastname, Firstname, [Middle Initial] FROM dbo.tblCustomer where CustomerID = '" & customerNumber & "'"
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.Read()
            txtCustomerNumber.Text = customerNumber
            txtCustLastname.Text = reader.GetString(1)
            txtCustFirstname.Text = reader.GetString(2)
            txtCustMiddlename.Text = reader.GetString(3)
        Loop
        reader.NextResult()
        gbTransDetails.Enabled = True
        Call DisConnectSQLServer()
    End Sub

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

    Private Sub frmTransactionManager_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If (Me.Width = 497 And choicetype = 2) Then
            Call getcustomerdata()
        End If
    End Sub

    Private Sub gbTransDetails_Enter(sender As Object, e As EventArgs) Handles gbTransDetails.Enter
        clbServices.Visible = False
        clbServices.Left = 159
        clbServices.Top = 154
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        choicetype = 1
        clearfields()
        gbTransDetails.Enabled = True
        Me.Width = 497
    End Sub

    Private Sub txtServices_TextChanged(sender As Object, e As EventArgs) Handles txtServices.TextChanged

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

    Private Sub btnChecklistBox_Click(sender As Object, e As EventArgs) Handles btnChecklistBox.Click, txtServices.Click
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


    Private Sub ServiceValidation()
        If clbServices.CheckedItems.Count < 1 Then
            ErrorProvider1.SetError(btnChecklistBox, "Please select atleast one service.")
            ErrorProvider1.SetIconPadding(btnChecklistBox, 5)
            flag7 = False
        Else
            ErrorProvider1.SetError(btnChecklistBox, "")
        End If
    End Sub

    Private Sub EmployeeValidation()
        If (cboEmployeeAssigned.SelectedIndex = -1) Then
            ErrorProvider1.SetError(cboEmployeeAssigned, "Please select an employee.")
            ErrorProvider1.SetIconPadding(cboEmployeeAssigned, 5)
            flag8 = False
        Else
            ErrorProvider1.SetError(cboEmployeeAssigned, "")
        End If
    End Sub

    Private Sub btnSaveTransaction_Click_1(sender As Object, e As EventArgs) Handles btnSaveTransaction.Click
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If (ask = vbYes) Then

            InitializeFlags()
            FirstNameValidation()
            LastNameValidation()
            ServiceValidation()
            EmployeeValidation()

            If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Or flag7 = False Or flag8 = False Then
                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
                Exit Sub
            End If

            Call AddCustomer(txtCustLastname.Text, txtCustFirstname.Text, txtCustMiddlename.Text)
            txtCustomerNumber.Text = lastIdentity
            Call AddTransactionRef(txtCustomerNumber.Text)
            Call ConnectTOSQLServer()

            For i As Integer = 0 To clbServices.Items.Count - 1
                If (clbServices.GetItemChecked(i)) Then
                    Dim dtrv As DataRowView = CType(clbServices.Items(i), DataRowView)
                    Dim dtr As DataRow = dtrv.Row
                    Dim dtrValueMember As String = dtr(clbServices.ValueMember).ToString()
                    strSQL = "insert into tblTransactions(Date,ServiceID,EmployeeID,CustomerID,CreationDate,CreatedBy,DataStatus,ModdedBy,ModdedDate,Remarks,TransactionRefID)values(convert(varchar,getdate(),110),@ServiceID,@EmployeeID,@CustomerID,getdate(),@Creator,'ACTIVE',@Modder,getdate(),@Remarks,@Transref)"
                    cmd = New SqlCommand(strSQL, Connection)
                    cmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = cboEmployeeAssigned.SelectedValue
                    cmd.Parameters.AddWithValue("@CustomerID", SqlDbType.Int).Value = lastIdentity
                    cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = txtRemarks.Text
                    cmd.Parameters.AddWithValue("@Creator", SqlDbType.Int).Value = login_id
                    cmd.Parameters.AddWithValue("@Modder", SqlDbType.Int).Value = login_id
                    cmd.Parameters.AddWithValue("@ServiceID", SqlDbType.Int).Value = dtrValueMember
                    cmd.Parameters.AddWithValue("@Transref", SqlDbType.Int).Value = lastTransID
                    cmd.ExecuteNonQuery()
                End If
                Console.WriteLine(strSQL)
            Next

            Call DisConnectSQLServer()
                MsgBox("Successfully created transaction.", MsgBoxStyle.Information, Application.ProductName)
                frmTransactions.Enabled = True
                Call DisConnectSQLServer()


            Dim ask2 = MsgBox("Are there item/s checked out?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask2 = vbYes Then
                Dim ab As New frmShowCheckoutlist
                ab.ShowDialog()
                Me.Close()
            Else
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



    Private Sub btnCancelTransaction_Click(sender As Object, e As EventArgs) Handles btnCancelTransaction.Click
        Me.Close()
    End Sub

End Class