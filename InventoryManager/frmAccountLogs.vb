Imports System.Data.SqlClient

Public Class frmAccountLogs
    Dim cond = ""
    Private Sub frmAccountLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblname.Text = accname
        lblId.Text = accID
        cond = " and Date =  " & dtpDate.Value.ToString("MM/dd/yyyy")
        loadlogs()
    End Sub

    Private Sub loadlogs()
        Call ConnectTOSQLServer()

        strSQL = "select Log#,LoginID,AccountName,CONVERT(varchar, Datetime, 101) AS Date, CONVERT(char(5), Datetime, 108) AS Time, Details from vw_applogs where  LoginID = " & accID & " and CONVERT(varchar, Datetime, 101) =  '" & dtpDate.Value.ToString("MM/dd/yyyy") & "' order by date,time asc"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Console.WriteLine(strSQL)

        Dim Loglist As New DataSet()
        dataadapter.Fill(Loglist, "[vw_applogs]")
        dgvLogs.DataSource = Loglist
        dgvLogs.DataMember = "[vw_applogs]"
        Call DisConnectSQLServer()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged

        loadlogs()
    End Sub
End Class