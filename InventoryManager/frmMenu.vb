Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenPanel(ByVal Childform As Object)
        If panelMenu.Controls.Count > 0 Then
            panelMenu.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Childform, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        panelMenu.Controls.Add(fh)
        panelMenu.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        OpenPanel(New frmAccounts)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        OpenPanel(New frmInventory)
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        OpenPanel(New frmTransactions)
    End Sub

    Private Sub btnEmployeeList_Click(sender As Object, e As EventArgs) Handles btnEmployeeList.Click
        OpenPanel(New frmEmployeeManager)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpenPanel(New frmDashboard)
    End Sub
End Class