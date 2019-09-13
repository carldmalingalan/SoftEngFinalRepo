Imports System.Data.SqlClient

Public Class frmAccounts

    Private Property selectedRow As Integer
    Private ActiveCount, InactiveCount As Int32

    Private Sub frmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JandADataSet1.tblLogins' table. You can move, or remove it, as needed.
        Me.TblLoginsTableAdapter1.Fill(Me.JandADataSet1.tblLogins)
        'TODO: This line of code loads data into the 'JandADataSet.tblLogins' table. You can move, or remove it, as needed.
        Me.TblLoginsTableAdapter.Fill(Me.JandADataSet.tblLogins)
        Call viewUserlist_reload()

    End Sub



    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        saveType = 1
        frmCreateAccount.Show()
        frmMenu.Enabled = False
    End Sub

    Private Sub viewUserlist_reload()
        Call ConnectTOSQLServer()
        strSQL = "SELECT AccountID, Lastname, Firstname, AccountName, Username, AccessType, AccountType FROM dbo.tblLogins"
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim UserList As New DataSet()

        dataadapter.Fill(UserList, "tblLogins")
        dgvUserList.DataSource = UserList
        dgvUserList.DataMember = "tblLogins"

        strSQL = "select COUNT(accountID) from tblLogins where AccountType = 'ACTIVE'"
        Console.WriteLine()
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                ActiveCount = reader.GetInt32(0)
            Loop
            reader.NextResult()
        Loop
        reader.Close()

        strSQL = "select COUNT(accountID) from tblLogins where AccountType = 'INACTIVE'"
        Console.WriteLine()
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                InactiveCount = reader.GetInt32(0)
            Loop
            reader.NextResult()
        Loop
        reader.Close()

        lblActiveCount.Text = ActiveCount
        lblInactiveCount.Text = InactiveCount
        Call DisConnectSQLServer()
    End Sub

    Private Sub frmAccounts_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        frmAccounts_Load(sender, e)
    End Sub

    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        saveType = 2
        frmCreateAccount.Show()
        frmCreateAccount.txtFirstname.Text = dgvUserList.Rows(selectedRow).Cells(2).Value()
        frmCreateAccount.txtLastname.Text = dgvUserList.Rows(selectedRow).Cells(1).Value()
        frmCreateAccount.txtUsername.Text = dgvUserList.Rows(selectedRow).Cells(4).Value()
        accountID = dgvUserList.Rows(selectedRow).Cells(0).Value()
        Dim role = dgvUserList.Rows(selectedRow).Cells(5).Value()
        If (role = "ADMINISTRATOR") Then
            frmCreateAccount.rdoAdministrator.Checked = True
        ElseIf (role = "INVENTORY") Then
            frmCreateAccount.rdoInventory.Checked = True
        ElseIf (role = "TRANSACTIONS") Then
            frmCreateAccount.rdoTransactions.Checked = True
        End If
        frmMenu.Enabled = False

    End Sub

    Private Sub dgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellClick
        If (dgvUserList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
            Catch ex As Exception
            End Try
            If (dgvUserList.Rows(selectedRow).Cells(6).Value() = "ACTIVE") Then
                btnDeactivateAccount.Text = "Deactivate Account"
            Else
                btnDeactivateAccount.Text = "Activate Account"

            End If
        End If
    End Sub

    Private Sub btnResetAccount_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        If (selectedRow < 1) Then
            MsgBox("Please select an account first.", MsgBoxStyle.Information, Application.ProductName)
        Else
            Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                accountID = dgvUserList.Rows(selectedRow).Cells(0).Value()
                Call ResetAccount(accountID)
                MsgBox("Password has been reset to default. Please use admin12345.", MsgBoxStyle.Information, Application.ProductName)
            End If
        End If
    End Sub

    Private Sub dgvUserList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellContentClick

    End Sub

    Private Sub btnDeactivateAccount_Click(sender As Object, e As EventArgs) Handles btnDeactivateAccount.Click
        If (selectedRow < 1) Then
            MsgBox("Please select an account first.", MsgBoxStyle.Information, Application.ProductName)
        Else
            Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                accountID = dgvUserList.Rows(selectedRow).Cells(0).Value()
                Dim Status = dgvUserList.Rows(selectedRow).Cells(6).Value()
                If Status = "ACTIVE" Then
                    Call DeactivateAccount(accountID)
                    MsgBox("Account has been deactivated.", MsgBoxStyle.Information, Application.ProductName)

                ElseIf Status = "INACTIVE" Then
                    Call ActivateAccount(accountID)
                    MsgBox("Account has been reactivated.", MsgBoxStyle.Information, Application.ProductName)
                End If
                Call viewUserlist_reload()
            End If
        End If
    End Sub
End Class