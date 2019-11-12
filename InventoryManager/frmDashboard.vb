Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadCharts()
    End Sub

    Private Sub LoadCharts()
        Call ConnectTOSQLServer()
        strSQL = "select count(TransactionID) as CategoryCount, [Service Category] from vw_ServiceDashboardCount where Date between '" & dtpDateFrom.Value.ToString("yyyy-MM-dd") & "' and '" & dtpDateTO.Value.ToString("yyyy-MM-dd") & "' group by [Service Category]"
        Dim da1 As New SqlDataAdapter(strSQL, Connection)
        Dim ds1 As New DataSet()
        da1.Fill(ds1, "x")
        chartCategories.ChartAreas(0).AxisX.Interval = 1
        chartCategories.Series("Series1").XValueMember = "Service Category"
        chartCategories.Series("Series1").YValueMembers = "CategoryCount"
        chartCategories.BorderSkin.BackColor = Color.AliceBlue
        chartCategories.DataSource = ds1.Tables("x")
        chartCategories.DataBind()



        strSQL = "select Count(transactionNumber) as count, [Employee Assigned] from (select * from (SELECT TransactionNumber,cast(TransactionDate as date) as Date,RIGHT(CONVERT(VARCHAR, TransactionDate, 100),7) as [Time], [Customer Name], [Service/s Availed] = STUFF((SELECT DISTINCT ', ' + [Service] FROM vw_TransactionsListing b WHERE b.TransactionNumber = a.TransactionNumber FOR XML PATH('')), 1, 2, ''), [Employee Assigned] FROM vw_TransactionsListing a GROUP BY TransactionNumber,TransactionDate, [Customer Name], [Employee Assigned]) c ) x where Date between '" & dtpDateFrom.Value.ToString("yyyy-MM-dd") & "' and '" & dtpDateTO.Value.ToString("yyyy-MM-dd") & "' group by [Employee Assigned]"
        Dim da As New SqlDataAdapter(strSQL, Connection)
        Dim ds As New DataSet()
        da.Fill(ds, "x")


        chartEmployeeTransactions.ChartAreas(0).AxisX.Interval = 1
        chartEmployeeTransactions.Series("Series1").XValueMember = "Employee Assigned"
        chartEmployeeTransactions.Series("Series1").YValueMembers = "count"
        chartEmployeeTransactions.BorderSkin.BackColor = Color.AliceBlue
        chartEmployeeTransactions.DataSource = ds.Tables("x")
        chartEmployeeTransactions.DataBind()

        strSQL = "select count(*) from (select * from (SELECT TransactionNumber,cast(TransactionDate as date) as Date,RIGHT(CONVERT(VARCHAR, TransactionDate, 100),7) as [Time], [Customer Name], [Service/s Availed] = STUFF((SELECT DISTINCT ', ' + [Service] FROM vw_TransactionsListing b WHERE b.TransactionNumber = a.TransactionNumber FOR XML PATH('')), 1, 2, ''), [Employee Assigned] FROM vw_TransactionsListing a GROUP BY TransactionNumber,TransactionDate, [Customer Name], [Employee Assigned]) c ) x where Date between '" & dtpDateFrom.Value.ToString("yyyy-MM-dd") & "' and '" & dtpDateTO.Value.ToString("yyyy-MM-dd") & "' group by [Employee Assigned]"
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        While reader.Read()
            lblTotalTransactions.Text = CStr(reader.GetInt32(0))
        End While



        Call DisConnectSQLServer()
    End Sub

    Private Sub chartEmployeeTransactions_Click(sender As Object, e As EventArgs) Handles chartEmployeeTransactions.Click

    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        dtpDateTO.MinDate = dtpDateFrom.Value
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call LoadCharts()
    End Sub
End Class