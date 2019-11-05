Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadCharts()
    End Sub

    Private Sub LoadCharts()
        Call ConnectTOSQLServer()
        strSQL = "select count(TransactionID) as CategoryCount, [Service Category] from vw_ServiceDashboardCount group by [Service Category]"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataSet
        Dim oCmd1 As New SqlCommand(strSQL, Connection)
        dataadapter.Fill(ds, "vw_ServiceDashboardCount")
        chartCategories.DataSource = ds.Tables("vw_ServiceDashboardCount")
        Dim Series1 As Series = chartCategories.Series("Series1")
        Series1.Name = "Service Type"
        chartCategories.Series(Series1.Name).XValueMember = "Service Category"
        chartCategories.Series(Series1.Name).YValueMembers = "CategoryCount"
        Console.WriteLine(strSQL)
        strSQL = "select count(TransactionID) as CountofTransactions, Fullname from vw_EmployeeServiceCountDashboard group by Fullname"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ds1 As New DataSet
        Dim oCmd As New SqlCommand(strSQL, Connection)
        dataadapter.Fill(ds1, "vw_EmployeeServiceCountDashboard")
        Console.WriteLine(strSQL)
        chartEmployeeTransactions.DataSource = ds1.Tables("vw_EmployeeServiceCountDashboard")
        Dim Series2 As Series = chartEmployeeTransactions.Series("Series2")
        Series2.Name = "Employee Transactions"
        chartEmployeeTransactions.Series(Series2.Name).XValueMember = "Fullname"
        chartEmployeeTransactions.Series(Series2.Name).YValueMembers = "CountofTransactions"
        Call DisConnectSQLServer()
    End Sub

End Class