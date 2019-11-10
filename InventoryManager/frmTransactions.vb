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
        strSQL = "SELECT * FROM [dbo].[vw_TransactionListFinal] where Date = '" & dtpTransactionDate.Value.ToString("MM/dd/yyyy") & "'"
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim TransactionList As New DataSet()
        dataadapter.Fill(TransactionList, "[vw_TransactionListFinal]")
        dgvTransactionsList.DataSource = TransactionList
        dgvTransactionsList.DataMember = "[vw_TransactionListFinal]"
        Call DisConnectSQLServer()
    End Sub




    Private Sub btnVoidTransaction_Click(sender As Object, e As EventArgs) Handles btnVoidTransaction.Click
        If (login_accesstype <> "ADMINISTRATOR") Then
            Dim ask = MsgBox("Administrator Authorization Required! Please request for admin credential authorization.", MsgBoxStyle.Information + vbOKCancel, Application.ProductName)
            If (ask = vbOK) Then
                frmAdminPrompt.ShowDialog()
            End If
        Else

        End If
    End Sub

    Private Sub dtpTransactionDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpTransactionDate.ValueChanged
        Call viewTransactions()
    End Sub

    Private Sub btnUpdateTransactions_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmTransactions_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
        frmTransactions_Load(sender, e)
    End Sub

    Private Sub dgvTransactionsList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsList.CellContentDoubleClick, dgvTransactionsList.CellDoubleClick

    End Sub
End Class