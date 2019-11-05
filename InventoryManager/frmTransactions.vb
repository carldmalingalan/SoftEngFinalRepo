Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmTransactions
    Private fForm As frmTransactionManager = New frmTransactionManager()
    Dim cond As String
    Private str1 As String
    Private selectedRow As Integer
    Private transID As Integer

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewTransactions()
    End Sub

    Private Sub btnAddTransactions_Click(sender As Object, e As EventArgs) Handles btnAddTransactions.Click
        Dim ab As New frmTransactionManager
        ab.ShowDialog()
    End Sub


    Private Sub viewTransactions()
        Call ConnectTOSQLServer()
        strSQL = "SELECT * FROM [dbo].[vw_Transactions] where Date = '" & dtpTransactionDate.Value.ToString("MM/dd/yyyy") & "'"
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim TransactionList As New DataSet()
        dataadapter.Fill(TransactionList, "[vw_transactions]")
        dgvTransactionsList.DataSource = TransactionList
        dgvTransactionsList.DataMember = "[vw_transactions]"
        Call DisConnectSQLServer()
    End Sub


    'Private Sub dgvTransactionsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsList.CellContentClick, dgvTransactionsList.CellClick
    '    If (dgvTransactionsList.Rows.Count > 0) Then
    '        Try
    '            selectedRow = e.RowIndex
    '            transID = dgvTransactionsList.Rows(selectedRow).Cells(0).Value()
    '            Call ConnectTOSQLServer()
    '            strSQL = "select * from tblTransactions where TransactionID = " & transID
    '            Console.WriteLine()
    '            cmd = New SqlCommand(strSQL, Connection)
    '            reader = cmd.ExecuteReader()
    '            Do While reader.HasRows
    '                Do While reader.Read()
    '                    txtCustomer.Text = reader.GetString(0)
    '                    cboBody.CheckState = reader.GetString(3)
    '                    cboHair.CheckState = reader.GetString(4)
    '                    cboNails.CheckState = reader.GetString(5)
    '                    cboServiceAvailed.Text = reader.GetString(6)
    '                    cboEmployeeAssigned.Text = reader.GetString(7)
    '                    txtRemarks.Text = reader.GetString(9)
    '                Loop
    '                reader.NextResult()
    '            Loop
    '            reader.Close()
    '            Call DisConnectSQLServer()
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub

    Private Sub btnVoidTransaction_Click(sender As Object, e As EventArgs) Handles btnVoidTransaction.Click
        If (login_accesstype <> "ADMINISTRATOR") Then
            Dim ask = MsgBox("Administrator Authorization Required! Please request for admin credential authorization.", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If (ask = vbYes) Then
                frmAdminPrompt.ShowDialog()
            End If
        End If
    End Sub

    Private Sub dtpTransactionDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpTransactionDate.ValueChanged
        Call viewTransactions()
    End Sub

    Private Sub btnUpdateTransactions_Click(sender As Object, e As EventArgs) Handles btnUpdateTransactions.Click

    End Sub
End Class