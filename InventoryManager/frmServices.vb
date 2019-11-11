
Imports System.Data.SqlClient
Public Class frmServices

    Private saveClass, category As String
    Private selectedRow As Integer
    Dim flag1, flag2, flag3, flag4 As Boolean
    Private serviceID As Int32
    Dim Service_Category As String

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
        btnCreateService.Enabled = False
        btnUpdateService.Enabled = False
        btnExportServices.Enabled = False
        saveClass = CType(1, String)
    End Sub

    Private Sub clearfields()
        txtServiceName.Text = ""
        txtRemarks.Text = ""
        rdoBody.Checked = False
        rdoFace.Checked = False
        rdoHair.Checked = False
        rdoNails.Checked = False
        switchServiceStatus.Value = False
        dgvServiceList.Enabled = True
        gbServiceDetails.Enabled = False
        btnCreateService.Enabled = True
        btnUpdateService.Enabled = True
        btnExportServices.Enabled = True
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
        If (dgvServiceList.Rows.Count >= 0) Then
            Try
                selectedRow = e.RowIndex
                serviceID = dgvServiceList.Rows(selectedRow).Cells(0).Value()
                GatherServiceData()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub GatherServiceData()
        Call ConnectTOSQLServer()
        strSQL = "select Name,Description,Status,[Service Category] from tblServices where ServiceID = " & serviceID
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                txtServiceName.Text = reader.GetString(0)
                txtRemarks.Text = reader.GetString(1)
                switchServiceStatus.Value = reader.GetBoolean(2)
                category = reader.GetString(3)
                If category = "Body" Then
                    rdoBody.Checked = 1
                ElseIf category = "Face" Then
                    rdoFace.Checked = 1
                ElseIf category = "Hair" Then
                    rdoHair.Checked = 1
                ElseIf category = "Nails" Then
                    rdoNails.Checked = 1
                End If
            Loop
            reader.NextResult()
        Loop
        Call DisConnectSQLServer()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub viewServices()
        Call ConnectTOSQLServer()
        strSQL = "select ServiceID,Name,Description,Status,[Service Category] from tblServices"
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ServiceList As New DataSet()

        dataadapter.Fill(ServiceList, "tblServices")
        dgvServiceList.DataSource = ServiceList
        dgvServiceList.DataMember = "tblServices"
        Call DisConnectSQLServer()
    End Sub

    Private Sub btnExportServices_Click(sender As Object, e As EventArgs) Handles btnExportServices.Click
        ExportExcel(dgvServiceList)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearfields()
        InitializeFlags()
        validateFields()
        gbServiceDetails.Enabled = False
        dgvServiceList.Enabled = True
        ErrorProvider1.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InitializeFlags()
        validateFields()
        If (flag1 = False Or flag2 = False Or flag3 = False) Then
            Exit Sub
        End If
        Dim ask = MsgBox("Do you want to save this service?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = Global.Microsoft.VisualBasic.Constants.vbYes Then
            If (rdoBody.Checked = True) Then
                Service_Category = "Body"
            ElseIf (rdoFace.Checked = True) Then
                Service_Category = "Face"
            ElseIf (rdoHair.Checked = True) Then
                Service_Category = "Hair"
            ElseIf (rdoNails.Checked = True) Then
                Service_Category = "Nails"
            End If
            If saveClass = 1 Then ' add
                Call AddService(txtServiceName.Text, switchServiceStatus.Value, txtRemarks.Text, Service_Category)
                MsgBox("Service has been successfully added into the list.", MsgBoxStyle.Information, Application.ProductName)
            ElseIf saveClass = 2 Then 'update
                Call UpdateService(txtServiceName.Text, switchServiceStatus.Value, serviceID, txtRemarks.Text, Service_Category)
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
        If (rdoBody.Checked = False And rdoFace.Checked = False And rdoHair.Checked = False And rdoNails.Checked = False) Then
            ErrorProvider1.SetError(rdoNails, "Blank type is not allowed.")
            ErrorProvider1.SetIconPadding(rdoNails, 5)
            flag2 = False
        End If
    End Sub

    Private Sub dgvServiceList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiceList.CellDoubleClick
        If (dgvServiceList.Rows.Count >= 0) Then
            Try
                selectedRow = e.RowIndex
                serviceID = dgvServiceList.Rows(selectedRow).Cells(0).Value()
                GatherServiceData()
            Catch ex As Exception
            End Try
            Call btnUpdateService_Click(sender, e)
        End If
    End Sub
End Class