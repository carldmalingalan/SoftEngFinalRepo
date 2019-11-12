Imports System.Data.SqlClient

Public Class frmInventoryItemLogs

    Private cond As String

    Private Sub frmInventoryItemLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cond = ""
        viewrecords()
    End Sub

    Private Sub viewrecords()
        Call ConnectTOSQLServer()
        strSQL = "select * from vw_ItemCheckIN where ItemID = " & itemID & cond
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader
        Console.WriteLine(strSQL)
        While reader.Read()
            lblItemID.Text = itemID
            lblItemName.Text = reader.GetString(3)
            lblAdded.Text = reader.GetString(6)
        End While
        reader.Close()


        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim UserList As New DataSet()

        dataadapter.Fill(UserList, "vw_ItemCheckIN")
        dgvItemLogs.DataSource = UserList
        dgvItemLogs.DataMember = "vw_ItemCheckIN"

        Call DisConnectSQLServer()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        cond = " and convert(varchar, Date, 110) = '" & dtpDate.Value.ToString("MM/dd/yyyy") & "'"
        viewrecords()
    End Sub
End Class