
Imports System.Data.SqlClient
Public Class frmServices

    Private saveClass, category As String
    Private selectedRow As Integer
    Dim flag1, flag2, flag3, flag4 As Boolean
    Private serviceID As Int32
    Dim Service_Category As Integer

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
            saveClass = CType(2, String)
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
        strSQL = "select Name,Details,Status,Description,[Service Category] from tblServices where ServiceID = " & serviceID
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        While reader.HasRows
            txtServiceName.Text = reader.GetString(0)
            switchServiceStatus.Value = reader.GetString(1)
            txtRemarks.Text = reader.GetString(2)
            category = reader.GetString(3)

            Console.WriteLine(category)
            If CInt(category) = 1 Then
                rdoBody.Checked = True
            ElseIf CInt(category) = 2 Then
                rdoFace.Checked = True
            ElseIf CInt(category) = 3 Then
                rdoHair.Checked = True
            ElseIf CInt(category) = 4 Then
                rdoNails.Checked = True
            End If
        End While
        reader.Close()
        Call DisConnectSQLServer()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub viewServices()
        Call ConnectTOSQLServer()
        strSQL = "select ServiceID,Name from tblServices"
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
        Dim ask = MsgBox("Do you want to save this service?", CType(MsgBoxStyle.Information + vbYesNo, MsgBoxStyle), Application.ProductName)
        If ask = vbYes Then
            If (rdoBody.Checked = True) Then
                Service_Category = 1
            ElseIf (rdoFace.Checked = True) Then
                Service_Category = 2
            ElseIf (rdoHair.Checked = True) Then
                Service_Category = 3
            ElseIf (rdoNails.Checked = True) Then
                Service_Category = 4
            End If
            If (CInt(saveClass) = 1) Then ' add
                Call AddService(txtServiceName.Text, CType(switchServiceStatus.Value, String), txtRemarks.Text, CType(Service_Category, String))
                MsgBox("Service has been successfully added into the list.", MsgBoxStyle.Information, Application.ProductName)
            ElseIf (CInt(saveClass) = 2) Then 'update
                Call UpdateService(txtServiceName.Text, CType(switchServiceStatus.Value, String), serviceID, txtRemarks.Text, CType(Service_Category, String))
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
End Class