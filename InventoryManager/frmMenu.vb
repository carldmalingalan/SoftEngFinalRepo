Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (login_accesstype = "ADMINISTRATOR") Then
            btnAccounts.Enabled = True
            btnDashboard.Enabled = True
            btnEmployeeList.Enabled = True
            btnInventory.Enabled = True
            btnServices.Enabled = True
            btnSettings.Enabled = True
            btnTransactions.Enabled = True
            btnExit.Enabled = True
        ElseIf (login_accesstype = "TRANSACTIONS") Then
            btnAccounts.Enabled = False
            btnDashboard.Enabled = True
            btnEmployeeList.Enabled = False
            btnInventory.Enabled = False
            btnServices.Enabled = False
            btnSettings.Enabled = False
            btnTransactions.Enabled = True
            btnExit.Enabled = True
        ElseIf (login_accesstype = "INVENTORY") Then
            btnAccounts.Enabled = False
            btnDashboard.Enabled = True
            btnEmployeeList.Enabled = False
            btnInventory.Enabled = True
            btnServices.Enabled = False
            btnSettings.Enabled = False
            btnTransactions.Enabled = False
            btnExit.Enabled = True
        End If
        Call btnAccounts_EnabledChanged()
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
        lblAccounts.ForeColor = Color.Red
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblSettings.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black

        OpenPanel(New frmAccounts)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Red
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblSettings.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black

        OpenPanel(New frmInventory)
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Red
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblSettings.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black

        OpenPanel(New frmTransactions)
    End Sub

    Private Sub btnEmployeeList_Click(sender As Object, e As EventArgs) Handles btnEmployeeList.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Red
        lblDashboard.ForeColor = Color.Black
        lblSettings.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black

        OpenPanel(New frmEmployeeManager)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Red
        lblSettings.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black

        OpenPanel(New frmDashboard)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblSettings.ForeColor = Color.Red
        lblServices.ForeColor = Color.Black

    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblSettings.ForeColor = Color.Black
        lblServices.ForeColor = Color.Red
        OpenPanel(New frmServices)
    End Sub

    Private Sub btnAccounts_EnabledChanged()
        If (btnAccounts.Enabled = False) Then
            btnAccounts.Image = btnAccounts.ErrorImage
        End If
        If (btnDashboard.Enabled = False) Then
            btnDashboard.Image = btnAccounts.ErrorImage
        End If
        If (btnEmployeeList.Enabled = False) Then
            btnEmployeeList.Image = btnEmployeeList.ErrorImage
        End If
        If (btnInventory.Enabled = False) Then
            btnInventory.Image = btnInventory.ErrorImage
        End If
        If (btnServices.Enabled = False) Then
            btnServices.Image = btnServices.ErrorImage
        End If
        If (btnSettings.Enabled = False) Then
            btnSettings.Image = btnSettings.ErrorImage
        End If
        If (btnTransactions.Enabled = False) Then
            btnTransactions.Image = btnTransactions.ErrorImage
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click

    End Sub
End Class