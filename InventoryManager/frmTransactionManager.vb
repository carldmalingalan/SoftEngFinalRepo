Imports System.Data.SqlClient

Public Class frmTransactionManager
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
        If (txtCustFirstname.Text <> "" And txtCustLastname.Text <> "" And txtCustMiddlename.Text <> "" And (cboBody.Checked = False And cboFace.Checked = False And cboHair.Checked = False And cboNails.Checked = False) And cboEmployeeAssigned.SelectedIndex = -1 And cboServiceAvailed.SelectedIndex = -1) Then
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
        cboBody.Checked = False
        cboHair.Checked = False
        cboNails.Checked = False
        cboFace.Checked = False
        gbTransDetails.Enabled = False
    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        gbTransDetails.Enabled = True
    End Sub

    Private Sub btnExistingCustomer_Click(sender As Object, e As EventArgs) Handles btnExistingCustomer.Click
        frmSearchCustomer.ShowDialog()
    End Sub
End Class