Imports System.Data.SqlClient

Public Class frmTransactions

    Private str1 As String
    Private HairBool, BodyBool, NailBool As String
    Private selectedRow As Integer
    Private transID As Integer

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewTransactions()
    End Sub

    Private Sub btnSaveTransaction_Click(sender As Object, e As EventArgs) Handles btnSaveTransaction.Click
        If (txtCustomer.Text <> "" And cboEmployeeAssigned.Text <> "" And cboServiceAvailed.Text <> "") Then
            Dim ask = MsgBox("Do you want to continue saving this transaction?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                Call AddTransaction(txtCustomer.Text, cboBody.CheckState, cboHair.CheckState, cboNails.CheckState, cboServiceAvailed.SelectedValue, cboEmployeeAssigned.SelectedValue, txtRemarks.Text)
                MsgBox("Successfully added transaction.", MsgBoxStyle.Information, Application.ProductName)
                Call clearfields()
                Call viewTransactions()
            End If
        Else
            MsgBox("Invalid entry. Please complete details.", MsgBoxStyle.Critical, Application.ProductName)
        End If
    End Sub

    Private Sub viewTransactions()
        Call ConnectTOSQLServer()
        strSQL = "select TransactionID as TransID,Date,CustomerName from vw_Transactions"
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim TransactionList As New DataSet()
        dataadapter.Fill(TransactionList, "vw_Transactions")
        dgvTransactionsList.DataSource = TransactionList
        dgvTransactionsList.DataMember = "vw_Transactions"
        Call DisConnectSQLServer()
    End Sub

    Private Sub clearfields()
        txtCustomer.Text = ""
        txtRemarks.Text = ""
        cboBody.Checked = False
        cboHair.Checked = False
        cboNails.Checked = False
        gbTransDetails.Enabled = False
        cboEmployeeAssigned.DataSource = Nothing
        cboServiceAvailed.DataSource = Nothing
        cboEmployeeAssigned.Items.Clear()
        cboServiceAvailed.Items.Clear()
    End Sub

    Private Sub dgvTransactionsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsList.CellContentClick, dgvTransactionsList.CellClick
        If (dgvTransactionsList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                TransID = dgvTransactionsList.Rows(selectedRow).Cells(0).Value()
                Call ConnectTOSQLServer()
                strSQL = "select * from vw_Transactions where TransactionID = " & transID
                Console.WriteLine()
                cmd = New SqlCommand(strSQL, Connection)
                reader = cmd.ExecuteReader()
                Do While reader.HasRows
                    Do While reader.Read()
                        txtCustomer.Text = reader.GetString(0)
                        cboBody.CheckState = reader.GetString(3)
                        cboHair.CheckState = reader.GetString(4)
                        cboNails.CheckState = reader.GetString(5)
                        cboServiceAvailed.Text = reader.GetString(6)
                        cboEmployeeAssigned.Text = reader.GetString(7)
                        txtRemarks.Text = reader.GetString(9)
                    Loop
                    reader.NextResult()
                Loop
                reader.Close()
                Call DisConnectSQLServer()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnVoidTransaction_Click(sender As Object, e As EventArgs) Handles btnVoidTransaction.Click
        If (login_accesstype = "ADMINISTRATOR") Then

        Else
            frmAdminPrompt.ShowDialog()
        End If
    End Sub

    Private Sub btnAddTransactions_Click(sender As Object, e As EventArgs) Handles btnAddTransactions.Click
        gbTransDetails.Enabled = True
    End Sub

    Private Sub cboNails_CheckedChanged(sender As Object, e As EventArgs) Handles cboNails.CheckedChanged, cboHair.CheckedChanged, cboBody.CheckedChanged
        Call ConnectTOSQLServer()
        If (cboBody.Checked = True) Then
            BodyBool = "1"
        Else
            BodyBool = "0"
        End If
        If (cboHair.Checked = True) Then
            HairBool = "1"
        Else
            HairBool = "0"
        End If
        If (cboNails.Checked = True) Then
            NailBool = "1"
        Else
            NailBool = "0"
        End If
        strSQL = "Select [ServiceName],[ServiceID] from [JandA].[dbo].[tblServices]  where Body = " & BodyBool & " and Hair = " & HairBool & " and Nails = " & NailBool
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader)
        cboServiceAvailed.DataSource = dt
        cboServiceAvailed.DisplayMember = "ServiceName"
        cboServiceAvailed.ValueMember = "ServiceID"

        strSQL = "select CONCAT(Lastname,', ',Firstname,' ',Middlename,'.') as Name, EmployeeID  FROM [JandA].[dbo].[tblEmployeeList] where Body = " & BodyBool & " and Hair = " & HairBool & " and Nails = " & NailBool
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        Dim dt1 As New DataTable()
        dt1.Load(cmd.ExecuteReader)
        cboEmployeeAssigned.DataSource = dt1
        cboEmployeeAssigned.DisplayMember = "Name"
        cboEmployeeAssigned.ValueMember = "EmployeeID"
        Call DisConnectSQLServer()
    End Sub

End Class