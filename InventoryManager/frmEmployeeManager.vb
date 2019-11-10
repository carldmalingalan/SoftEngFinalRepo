

Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient


Public Class frmEmployeeManager

    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean
    Dim saveClass As String
    Dim userID As Int32
    Dim cond As String
    Dim Activecount, inactivecount As String

    Dim HairStat, NailStat, BodyStat As String
    Private ImageFileName As String
    Private Imageloc As String
    Dim fileName As String
    Private fileSavePath As String
    Dim saveDirectory As String = "C:\Users\Monkey\Desktop\ISAD Profile Pictures"
    Private newlocation As String
    Private old_newlocation As String
    Private imgFound As Image
    Private FoundTitle As String
    Private imageName As String
    Public Property selectedRow As Integer

    Private Sub InitializeFlags()
        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True
        flag5 = True
        flag6 = True
        flag7 = True
        flag8 = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearfields()
        InitializeFlags()
        selectedRow = -1
        gbEmployeeDetails.Enabled = False
        dgvEmployeeList.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InitializeFlags()
        FirstNameValidation()
        LastNameValidation()
        MiddleValidation()
        ImageValidation()

        If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Or flag7 = False Or flag8 = False Then

            MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
            Exit Sub
        End If
        If (saveClass = 1) Then
            Dim ask = MsgBox("Are you sure you want to add employee?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If (ask = vbYes) Then
                Try
                    fileName = Path.GetFileName(ImageFileName)
                    fileSavePath = Path.Combine(saveDirectory, fileName)
                    File.Copy(ImageFileName, fileSavePath, True)
                Catch
                    fileSavePath = ""
                End Try
                Call ConnectTOSQLServer()
                strSQL = "insert into tblEmployeeList(Firstname,Lastname,MiddleInitial,Email,ContactNumber,CreatedBy,CreationDate,LastModifiedBy,LastModifiedDate,Image,EmployeeStatus) values (@Firstname,@Lastname,@Middlename,@Email,@ContactNumber,@CreatedBy,getdate(),@Lastmod,getdate(),@Image,'TRUE')"
                cmd = New SqlCommand(strSQL, Connection)
                cmd.Parameters.AddWithValue("@Firstname", SqlDbType.VarChar).Value = txtFirstname.Text
                cmd.Parameters.AddWithValue("@Lastname", SqlDbType.VarChar).Value = txtLastname.Text
                cmd.Parameters.AddWithValue("@MiddleName", SqlDbType.VarChar).Value = txtMiddleInitial.Text
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = txtEmail.Text
                cmd.Parameters.AddWithValue("@ContactNumber", SqlDbType.VarChar).Value = txtContactNumber.Text
                cmd.Parameters.AddWithValue("@CreatedBy", SqlDbType.Int).Value = login_id
                cmd.Parameters.AddWithValue("@Lastmod", SqlDbType.Int).Value = login_id
                cmd.Parameters.AddWithValue("@Image", SqlDbType.VarChar).Value = fileSavePath
                cmd.ExecuteNonQuery()
                newlocation = Nothing
                imageName = Nothing
                pbEmployeePic.BackgroundImage = Nothing
                Me.Cursor = Cursors.Default
                Call DisConnectSQLServer()
                Call clearfields()
                gbEmployeeDetails.Enabled = False
                MsgBox("Successfully added employee details.", MsgBoxStyle.Information, Application.ProductName)
            End If
        ElseIf (saveClass = 2) Then
            Dim ask = MsgBox("Are you sure you want to update employee?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If (ask = vbYes) Then
                Try
                    fileName = Path.GetFileName(ImageFileName)
                    fileSavePath = Path.Combine(saveDirectory, fileName)
                    File.Copy(ImageFileName, fileSavePath, True)
                Catch
                    fileSavePath = ""
                End Try
                Call ConnectTOSQLServer()
                strSQL = "update tblEmployeeList set Lastname = @Lastname, Firstname = @Firstname, MiddleInitial= @Middle,Email = @Email, ContactNumber = @Contact, LastModifiedBy = @Lastmod, LastModifiedDate = getdate(), Image = @Image , EmployeeStatus = @EmpStatus where EmployeeID = @EmpID"
                cmd = New SqlCommand(strSQL, Connection)
                cmd.Parameters.AddWithValue("@Lastname", SqlDbType.VarChar).Value = txtLastname.Text
                cmd.Parameters.AddWithValue("@Firstname", SqlDbType.VarChar).Value = txtFirstname.Text
                cmd.Parameters.AddWithValue("@Middle", SqlDbType.VarChar).Value = txtMiddleInitial.Text
                cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = txtEmail.Text
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.VarChar).Value = txtContactNumber.Text
                cmd.Parameters.AddWithValue("@Lastmod", SqlDbType.Int).Value = login_id
                If (fileSavePath <> "") Then
                    cmd.Parameters.AddWithValue("@Image", SqlDbType.VarChar).Value = fileSavePath
                Else
                    cmd.Parameters.AddWithValue("@Image", SqlDbType.VarChar).Value = Imageloc
                End If
                cmd.Parameters.AddWithValue("@EmpStatus", SqlDbType.VarChar).Value = switchEmployeeStatus.Value
                cmd.Parameters.AddWithValue("@EmpID", SqlDbType.Int).Value = userID
                Console.WriteLine(strSQL)
                cmd.ExecuteNonQuery()
                fileSavePath = Nothing
                imageName = Nothing
                pbEmployeePic.BackgroundImage = Nothing
                Me.Cursor = Cursors.Default
                Call DisConnectSQLServer()
                gbEmployeeDetails.Enabled = False
                MsgBox("Successfully update employee details.", MsgBoxStyle.Information, Application.ProductName)
            End If
            Call clearfields()

        End If
        Call ViewEmployeeList()

    End Sub

    Private Sub dgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        If (dgvEmployeeList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                userID = dgvEmployeeList.Rows(selectedRow).Cells(0).Value()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Using openFileDialog1 As OpenFileDialog = New OpenFileDialog()
            openFileDialog1.Filter = "Image Files (JPEG,GIF,BMP,PNG,ICO)|*.jpg;*.jpeg;*.gif;*.bmp;*.png;*ico"
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                If Not Directory.Exists(saveDirectory) Then
                    Directory.CreateDirectory(saveDirectory)
                End If
                ImageFileName = openFileDialog1.FileName
                pbEmployeePic.BackgroundImage = Image.FromFile(openFileDialog1.FileName.ToUpper)

            End If
        End Using
    End Sub

    Private Sub frmEmployeeManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ViewEmployeeList()
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        dgvEmployeeList.Enabled = False
        btnAddEmployee.Enabled = False
        btnUpdateEmployee.Enabled = False
        btnExportEmployeeList.Enabled = False
        gbEmployeeDetails.Enabled = True
        saveClass = 2
    End Sub

    Private Sub dgvEmployeeList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellContentClick, dgvEmployeeList.CellClick
        Call ConnectTOSQLServer()
        strSQL = "select EmployeeID,Firstname,Lastname,MiddleInitial,Email,ContactNumber,EmployeeStatus,Image from tblEmployeeList where EmployeeID = '" & userID & "'"
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                userID = reader.GetInt32(0)
                txtFirstname.Text = reader.GetString(1)
                txtLastname.Text = reader.GetString(2)
                txtMiddleInitial.Text = reader.GetString(3)
                txtEmail.Text = reader.GetString(4)
                txtContactNumber.Text = reader.GetString(5)
                switchEmployeeStatus.Value = reader.GetString(6)
                Try
                    pbEmployeePic.BackgroundImage = Image.FromFile("" & reader.GetString(7) & "")
                    Imageloc = reader.GetString(7)
                Catch ex As Exception
                    pbEmployeePic.BackgroundImage = pbEmployeePic.ErrorImage
                End Try
            Loop
            reader.NextResult()
        Loop
        reader.Close()
        Call DisConnectSQLServer()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call ViewEmployeeList()
        logInfo = "Searched " & txtSearch.Text.Trim.Replace("-", "") & " in the Employee List."
        Call RecordLog(logInfo)
    End Sub



    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        clearfields()
        btnAddEmployee.Enabled = False
        btnUpdateEmployee.Enabled = False
        btnExportEmployeeList.Enabled = False
        dgvEmployeeList.Enabled = False
        gbEmployeeDetails.Enabled = True
        saveClass = 1
    End Sub

    Private Sub clearfields()
        txtContactNumber.Text = ""
        txtEmail.Text = ""
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtMiddleInitial.Text = ""
        btnAddEmployee.Enabled = True
        btnUpdateEmployee.Enabled = True
        btnExportEmployeeList.Enabled = True
        dgvEmployeeList.Enabled = True
        pbEmployeePic.BackgroundImage = Nothing
    End Sub

    Private Sub FirstNameValidation()
        If txtFirstname.Text.Trim = "" Then
            ErrorProvider1.SetError(txtFirstname, "Blank field Is Not allowed.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False
        ElseIf txtFirstname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtFirstname, "Special characters are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False
        ElseIf IsNumeric(txtFirstname.Text) = True Or txtFirstname.Text.IndexOfAny("1234567890") > -1 Then
            ErrorProvider1.SetError(txtFirstname, "Numbers are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtFirstname, "")
        End If
    End Sub

    Private Sub LastNameValidation()
        If txtLastname.Text.Trim = "" Then
            ErrorProvider1.SetError(txtLastname, "Blank field Is Not allowed.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False
        ElseIf txtLastname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtLastname, "Special characters are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False
        ElseIf IsNumeric(txtLastname.Text) = True Or txtLastname.Text.IndexOfAny("1234567890") > -1 Then
            ErrorProvider1.SetError(txtLastname, "Numbers are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False
        Else
            ErrorProvider1.SetError(txtLastname, "")
        End If
    End Sub

    Private Sub MiddleValidation()
        If txtMiddleInitial.Text.Trim = "" Then
            ErrorProvider1.SetError(txtMiddleInitial, "Blank field Is Not allowed.")
            ErrorProvider1.SetIconPadding(txtMiddleInitial, 5)
            flag3 = False
        ElseIf txtMiddleInitial.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtMiddleInitial, "Special characters are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtMiddleInitial, 5)
            flag3 = False
        ElseIf IsNumeric(txtMiddleInitial.Text) = True Or txtMiddleInitial.Text.IndexOfAny("1234567890") > -1 Then
            ErrorProvider1.SetError(txtMiddleInitial, "Number are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtMiddleInitial, 5)
            flag3 = False
        ElseIf txtMiddleInitial.Text.Length > 1 Then
            ErrorProvider1.SetError(txtMiddleInitial, "Only one letter Is allowed.")
            ErrorProvider1.SetIconPadding(txtMiddleInitial, 5)
            flag3 = False
        Else
            ErrorProvider1.SetError(txtMiddleInitial, "")
        End If
    End Sub



    Private Sub ImageValidation()
        If pbEmployeePic.BackgroundImage Is Nothing Then
            ErrorProvider1.SetError(btnBrowseImage, "Please insert a photo.")
            ErrorProvider1.SetIconPadding(btnBrowseImage, 3)
            flag5 = False
        Else
            ErrorProvider1.SetError(btnBrowseImage, "")
        End If
    End Sub

    Private Sub ViewEmployeeList()
        Call ConnectTOSQLServer()
        If (txtSearch.Text <> "") Then
            cond = " where Lastname = '" & txtSearch.Text.Trim.Replace("-", "") & "' or Firstname = '" & txtSearch.Text.Trim.Replace("-", "") & "'"
        Else
            cond = ""
        End If
        strSQL = "Select EmployeeID, Concat(Lastname,', ',Firstname,' ',MiddleInitial,'.') as [Employee Name] from tblEmployeeList" & cond
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim EmployeeList As New DataSet()

        dataadapter.Fill(EmployeeList, "tblEmployeeList")
        dgvEmployeeList.DataSource = EmployeeList
        dgvEmployeeList.DataMember = "tblEmployeeList"

        strSQL = "Select COUNT(EmployeeID) from tblEmployeeList where EmployeeStatus = '1'"
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

        strSQL = "Select COUNT(EmployeeID) from tblEmployeeList where EmployeeStatus = '0'"
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

        lblActive.Text = ActiveCount
        lblInactive.Text = InactiveCount
        Call DisConnectSQLServer()
    End Sub
End Class