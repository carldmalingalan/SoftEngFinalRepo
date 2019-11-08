Imports System.Data.SqlClient

Public Class frmItemQuantity
    Private Sub frmItemQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadItemlIst()
    End Sub

    Private Sub loadItemlIst()
        lblTxn.Text = "Trans#" & lastTransID
        Call ConnectTOSQLServer()
        strSQL = "select * from vw_InventoryView where ItemID = '" & itemNumber & "'"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.Read()
            lblName.Text = reader.GetString(1)
            lblQty.Text = reader.GetDecimal(2)
            lblCrit.Text = reader.GetString(3)
            lblDesc.Text = reader.GetString(4)
            lblCateg.Text = reader.GetString(5)

        Loop
        reader.NextResult()
        Call DisConnectSQLServer()
    End Sub

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click

    End Sub
End Class