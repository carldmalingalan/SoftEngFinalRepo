Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadCharts()
    End Sub

    Private Sub LoadCharts()
        strSQL = "select COUNT(Category) as CategoryCount, Category from vw_transaction group by Category"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataSet
        chartCategories.DataSource = ds.Tables("vw_transaction")
        Dim Series1 As Series = chartCategories.Series("Series1")
        Series1.Name = "Service Type"
        chartCategories.Series(Series1.Name).XValueMember = "Category"
        chartCategories.Series(Series1.Name).YValueMembers = "CategoryCount"

        strSQL = "select COUNT([Assigned To]) as [Employee Name Count], [Assigned To]  from vw_transaction group by [Assigned To]"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds1 As New DataSet
        chartEmployeeTransactions.DataSource = ds.Tables("vw_transaction")
        Dim Series2 As Series = chartEmployeeTransactions.Series("Series2")
        Series2.Name = "Employee Transactions"
        chartEmployeeTransactions.Series(Series2.Name).XValueMember = "Assigned To"
        chartEmployeeTransactions.Series(Series2.Name).YValueMembers = "Employee Name Count"
    End Sub

    Private Sub chartEmployeeTransactions_Click(sender As Object, e As EventArgs) Handles chartEmployeeTransactions.Click

    End Sub
End Class