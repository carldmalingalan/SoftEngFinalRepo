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
        strSQL = "SELECT TransactionNumber,convert(varchar,TransactionDate,101) as [Date],RIGHT(CONVERT(VARCHAR, TransactionDate, 100),7) as [Time], [Customer Name], [Service/s Availed] = STUFF((SELECT DISTINCT ', ' + [Service] FROM vw_TransactionsListing b WHERE b.TransactionNumber = a.TransactionNumber FOR XML PATH('')), 1, 2, ''), [Employee Assigned] FROM vw_TransactionsListing a where convert(varchar,TransactionDate,101) = '" & dtpTransactionDate.Value.ToString("MM/dd/yyyy") & "' GROUP BY TransactionNumber,TransactionDate, [Customer Name], [Employee Assigned]"
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim TransactionList As New DataSet()
        dataadapter.Fill(TransactionList, "[vw_TransactionListFinal]")
        dgvTransactionsList.DataSource = TransactionList
        dgvTransactionsList.DataMember = "[vw_TransactionListFinal]"
        Call DisConnectSQLServer()
    End Sub

    Private Sub btnVoidTransaction_Click(sender As Object, e As EventArgs) Handles btnVoidTransaction.Click
        If (selectedRow >= 0) Then
            If (login_accesstype <> "ADMINISTRATOR") Then
                Dim ask = MsgBox("Administrator Authorization Required! Please request for admin credential authorization.", MsgBoxStyle.Information + vbOKCancel, Application.ProductName)
                If (ask = vbOK) Then
                    frmAdminPrompt.ShowDialog()
                End If
            Else
                If (dtpTransactionDate.Value.ToShortDateString < Date.Today) Then
                    MsgBox("Only transactions within the day can be voided.", MsgBoxStyle.Critical, Application.ProductName)
                Else
                    Dim ask = MsgBox("Are you sure you want to void this transaction?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
                    If ask = vbYes Then
                        Call VoidTransaction(dgvTransactionsList.Rows(selectedRow).Cells(0).Value())
                        MsgBox("Successfully voided transaction!", MsgBoxStyle.Information, Application.ProductName)
                        viewTransactions()
                    End If
                End If
            End If
        Else
            MsgBox("Select a transaction first.", MsgBoxStyle.Information, Application.ProductName)
        End If
    End Sub

    Private Sub dtpTransactionDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpTransactionDate.ValueChanged
        Call viewTransactions()
    End Sub

    Private Sub frmTransactions_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
        frmTransactions_Load(sender, e)
    End Sub

    Private Sub dgvTransactionsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsList.CellContentClick, dgvTransactionsList.CellClick
        If (dgvTransactionsList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                Console.WriteLine(selectedRow)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dgvTransactionsList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsList.CellDoubleClick
        If (dgvTransactionsList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                transactionCheck = dgvTransactionsList.Rows(selectedRow).Cells(0).Value()
                Dim ab As New frmShowDetailsTransaction
                ab.Show()
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportExcel(dgvTransactionsList)
    End Sub

    Private Sub btnExportPdf_Click(sender As Object, e As EventArgs) Handles btnExportPdf.Click
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            ' declaration textbox2 to save file dialog name
            Dim txt As String = SaveFileDialog1.FileName & ".pdf"
            Call ExporttoPDF(txt, dgvTransactionsList)
        End If
    End Sub
End Class