Imports System.Data.SqlClient

Public Class frmShowDetailsTransaction
    Dim itemcoll(100) As String
    Private Sub frmShowDetailsTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ConnectTOSQLServer()
        strSQL = "select TransactionRefID,Date,Time, [Assigned To],[Customer Name],[Created By] from vw_Transactions where TransactionRefID = " & transactionCheck
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.Read()
            lblTransID.Text = CStr(reader.GetInt32(0))
            lblDate.Text = CStr(reader.GetDateTime(1))
            lblTime.Text = reader.GetString(2)
            lblEmpAssigned.Text = reader.GetString(3)
            lblCustName.Text = reader.GetString(4)
            lblAuthor.Text = reader.GetString(5)
        Loop
        reader.NextResult()
        reader.Close()
        strSQL = "select Name from vw_Transactions as Services where TransactionRefID = " & transactionCheck
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim TransactionList As New DataSet()
        dataadapter.Fill(TransactionList, "[vw_Transactions]")
        dgvServiceAvailed.DataSource = TransactionList
        dgvServiceAvailed.DataMember = "[vw_Transactions]"

        strSQL = "select [ItemID],[Item Name],SUM([Quantity Used]) as [Quantity Used] from vw_Checkout where TransactionNumber = " & transactionCheck & " group by ItemID,[Item Name] "
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ItemList As New DataSet()
        dataadapter.Fill(ItemList, "[vw_Checkout]")
        dgvItemsCheckout.DataSource = ItemList
        dgvItemsCheckout.DataMember = "[vw_Checkout]"

        Call DisConnectSQLServer()
    End Sub
End Class