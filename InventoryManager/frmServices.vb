Imports System.Data.SqlClient

Public Class frmServices

    Private saveClass As String
    Private selectedRow As Integer
    Dim flag1, flag2, flag3, flag4 As Boolean
    Dim serviceID As Int32

    Private Sub frmServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewServices()
    End Sub


    Private Sub InitializeFlags()
        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True
    End Sub
    Private Sub btnCreateService_Click(sender As Object, e As EventArgs) Handles btnCreateService.Click
        gbServiceDetails.Enabled = True
        dgvServiceList.Enabled = False
        clearfields()
        saveClass = 1
    End Sub

    Private Sub clearfields()
        txtServiceDetails.Text = ""
        txtServiceName.Text = ""
        cboBody.Checked = False
        cboHair.Checked = False
        cboNails.Checked = False
        switchServiceStatus.Value = False
        dgvServiceList.Enabled = True
        gbServiceDetails.Enabled = False
        serviceID = Nothing
    End Sub

    Private Sub btnUpdateService_Click(sender As Object, e As EventArgs) Handles btnUpdateService.Click
        If (serviceID > 0) Then
            gbServiceDetails.Enabled = True
            dgvServiceList.Enabled = False
            saveClass = 2
        Else
            MsgBox("Please add a service first.", MsgBoxStyle.Information, Application.ProductName)
        End If
    End Sub

    Private Sub dgvServiceList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceList.CellContentClick, dgvServiceList.CellClick
        If (dgvServiceList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                serviceID = dgvServiceList.Rows(selectedRow).Cells(0).Value()
                Call ConnectTOSQLServer()
                strSQL = "select * from tblServices where ServiceID = " & serviceID
                Console.WriteLine()
                cmd = New SqlCommand(strSQL, Connection)
                reader = cmd.ExecuteReader()
                Do While reader.HasRows
                    Do While reader.Read()
                        txtServiceName.Text = reader.GetString(1)
                        txtServiceDetails.Text = reader.GetString(2)
                        cboBody.CheckState = reader.GetString(3)
                        cboHair.CheckState = reader.GetString(4)
                        cboNails.CheckState = reader.GetString(5)
                        switchServiceStatus.Value = reader.GetString(6)
                    Loop
                    reader.NextResult()
                Loop
                reader.Close()
                Call DisConnectSQLServer()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub viewServices()
        Call ConnectTOSQLServer()
        strSQL = "select ServiceID,ServiceName from tblServices"
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ServiceList As New DataSet()

        dataadapter.Fill(ServiceList, "tblServices")
        dgvServiceList.DataSource = ServiceList
        dgvServiceList.DataMember = "tblServices"
        Call DisConnectSQLServer()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearfields()
        gbServiceDetails.Enabled = False
        dgvServiceList.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InitializeFlags()
        validateFields()
        If (flag1 = False Or flag2 = False Or flag3 = False) Then
            Exit Sub
        End If
        Dim ask = MsgBox("Do you want to save this service?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            If (saveClass = 1) Then ' add
                Call AddService(txtServiceName.Text, txtServiceDetails.Text, cboBody.CheckState, cboHair.CheckState, cboNails.CheckState, switchServiceStatus.Value)
                MsgBox("Service has been successfully added into the list.", MsgBoxStyle.Information, Application.ProductName)
            ElseIf (saveClass = 2) Then 'update
                Call UpdateService(txtServiceName.Text, txtServiceDetails.Text, cboBody.CheckState, cboHair.CheckState, cboNails.CheckState, switchServiceStatus.Value, serviceID)
                MsgBox("Service has been successfully update into the list.", MsgBoxStyle.Information, Application.ProductName)
            End If
            Call clearfields()
            Call viewServices()
        End If
    End Sub

    Private Sub validateFields()
        If (txtServiceName.Text.Trim = "") Then
            ErrorProvider1.SetError(txtServiceName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtServiceName, 5)
            flag1 = False
        End If
        If (cboBody.Checked = False And cboHair.Checked = False And cboNails.Checked = False) Then
            ErrorProvider1.SetError(cboNails, "Blank type is not allowed.")
            ErrorProvider1.SetIconPadding(cboNails, 5)
            flag2 = False
        End If
    End Sub
End Class