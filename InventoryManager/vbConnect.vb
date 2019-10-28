Option Explicit On
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports System.Configuration
Imports System.Data.SqlTypes
Imports System.Security.Cryptography
Imports System.Text

Module vbConnect

    Public Connection As SqlConnection
    Private Server As String
    Private Database As String
    Public cmd As SqlCommand
    Public strSQL As String
    Public reader As SqlDataReader
    Public dataadapter As New SqlDataAdapter

    Public login_name As String
    Public login_id As Int32
    Public login_username As String
    Public login_accesstype As String
    Public login_accountstatus As String

    Public restrictedCharactersForUsername As String = "!@#$%^&*()+=[]\{}|;':,./<>?€‚ƒ„…†‡ˆ‰Š‹ŒŽ‘’""•–—˜™š›œžŸ¡¢£¤¥¦§¨©ª«¬®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ" & Chr(34) & " " 'Underscores and dash are only allowed
    Public restrictedCharactersForName As String = "!@#$%^&*()=_+[]\{}|;':,/<>?€‚ƒ„…†‡ˆ‰Š‹ŒŽ‘’""•–—˜™š›œžŸ¡¢£¤¥¦§¨©ª«¬®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ" & Chr(34) 'Dot, dash and spaces are only allowed
    Public restrictedCharactersForPassword As String = "!-=[]\{}|;':,/<>€‚ƒ„…†‡ˆ‰Š‹ŒŽ‘’""•–—˜™š›œžŸ¡¢£¤¥¦§¨©ª«¬®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ?" & Chr(34) 'Letters and numbers are only allowed

    Public defaultPassword As String = "41E5653FC7AEB894026D6BB7B2DB7F65902B454945FA8FD65A6327047B5277FB"
    Public sqlConnectionString = "Server=MONKEYPC\MARCODATABASE;Database=JandA2;Trusted_Connection=True;"

    Public accountID As Int32
    Public itemID As Int32
    Public saveType As String 'accounts
    Public saveType1 As String 'items
    Public saveType2 As String 'transactions

    Public voidID As Int32
    Function GetHash(theInput As String) As String

        Using hasher As SHA256 = SHA256.Create()    ' create hash object
            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))
            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()
            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n
            Return sBuilder.ToString()
        End Using
    End Function

    Public Sub ConnectTOSQLServer()
        Connection = New SqlConnection(sqlConnectionString)
        Try
            Connection.Open()
        Catch ex As Exception
            MsgBox("Can not open connection ! ")
            End
        End Try
    End Sub

    Public Sub DisConnectSQLServer()
        Try
            Connection.Close()
        Catch ex As Exception
            MsgBox("Can not close connection ! ")
        End Try
    End Sub

    Public Sub Login(Username As String, Password As String)
        Call ConnectTOSQLServer()
        Console.WriteLine(Environment.UserName)
        login_name = ""
        strSQL = "select AccountName,AccountID,Username,AccessType,AccountType as AccountStatus from tbllogins where Username = @Username and Password = @Password"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = GetHash(Password)
        cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                login_name = reader.GetString(0)
                login_id = reader.GetInt32(1)
                login_username = reader.GetString(2)
                login_accesstype = reader.GetString(3)
                login_accountstatus = reader.GetString(4)
            Loop
            reader.NextResult()
        Loop
        reader.Close()
        Call DisConnectSQLServer()
    End Sub

    Public Sub PasswordChange(NewPassword As String, SecretQuestionID As Int32, Answer As String)
        Call ConnectTOSQLServer()
        strSQL = "update tblLogins set Password = @Password, SecretQuestion = @SecretQuestionID, Answer = @Answer, LastModified = @AccountID, LastModifiedDate = getdate() where AccountID = @AccountID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = GetHash(NewPassword)
        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.VarChar).Value = login_id
        cmd.Parameters.AddWithValue("@SecretQuestionID", SqlDbType.Int).Value = SecretQuestionID
        cmd.Parameters.AddWithValue("@Answer", SqlDbType.VarChar).Value = Answer
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub CreateAccount(Username As String, Lastname As String, Firstname As String, Role As String)
        Call ConnectTOSQLServer()
        strSQL = "insert into tblLogins(Lastname,Firstname,Username,Password,AccessType,AccountType,CreationDate,CreatedBy,LastModified,LastModifiedDate) values(@Lastname,@Firstname,@Username,@Password,@AccessType,'ACTIVE',GETDATE(),@Creator,@Modifier,GETDATE())"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Lastname", SqlDbType.VarChar).Value = Lastname
        cmd.Parameters.AddWithValue("@Firstname", SqlDbType.VarChar).Value = Firstname
        cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username
        cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = GetHash("admin12345")
        cmd.Parameters.AddWithValue("@AccessType", SqlDbType.VarChar).Value = Role
        cmd.Parameters.AddWithValue("@Creator", SqlDbType.VarChar).Value = login_id
        cmd.Parameters.AddWithValue("@Modifier", SqlDbType.VarChar).Value = login_id
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub UpdateAccount(Username As String, Lastname As String, Firstname As String, Role As String, AccountID As Int32)
        Call ConnectTOSQLServer()
        strSQL = "update tblLogins set Lastname = @Lastname, Firstname = @Firstname, Username = @Username, LastModified = @Modifier, LastModifiedDate = getdate() where AccountID = @AccountID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Lastname", SqlDbType.VarChar).Value = Lastname
        cmd.Parameters.AddWithValue("@Firstname", SqlDbType.VarChar).Value = Firstname
        cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username
        cmd.Parameters.AddWithValue("@AccessType", SqlDbType.VarChar).Value = Role
        cmd.Parameters.AddWithValue("@Modifier", SqlDbType.VarChar).Value = login_id
        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.Int).Value = AccountID
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub ActivateAccount(AccountID As Int32)
        Call ConnectTOSQLServer()
        strSQL = "update tblLogins set AccountType = 'ACTIVE',LastModified=@Modifier, LastModifiedDate = getdate() where AccountID = @AccountID"

        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.VarChar).Value = AccountID
        cmd.Parameters.AddWithValue("@Modifier", SqlDbType.VarChar).Value = login_id

        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub DeactivateAccount(AccountID As Int32)
        Call ConnectTOSQLServer()
        strSQL = "update tblLogins set AccountType = 'INACTIVE', LastModified=@Modifier, LastModifiedDate = getdate() where AccountID = @AccountID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.Int).Value = AccountID
        cmd.Parameters.AddWithValue("@Modifier", SqlDbType.VarChar).Value = login_id

        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub ResetAccount(accountID As Int32)
        Call ConnectTOSQLServer()
        strSQL = "update tblLogins set Password = '" & defaultPassword & "' where AccountID = @AccountID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.Int).Value = accountID
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub


    Public Sub AddItem(Itemname As String, ItemQuantity As String, ItemDescription As String, ItemClass As String)
        Call ConnectTOSQLServer()
        strSQL = "insert into tblInventory(ItemName,ItemQuantity,ItemDescription,ItemClassification) values (@ItemName,@ItemQuantity,@ItemDescription,@ItemClassification)"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ItemName", SqlDbType.VarChar).Value = Itemname
        cmd.Parameters.AddWithValue("@ItemQuantity", SqlDbType.VarChar).Value = ItemQuantity
        cmd.Parameters.AddWithValue("@ItemDescription", SqlDbType.VarChar).Value = ItemDescription
        cmd.Parameters.AddWithValue("@ItemClassification", SqlDbType.VarChar).Value = ItemClass
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Public Sub UpdateItem(Itemname As String, ItemQuantity As String, ItemDescription As String, ItemClass As String, ItemID As Int32)
        Call ConnectTOSQLServer()
        strSQL = "update tblInventory set ItemName = @ItemName, ItemQuantity = @ItemQuantity, ItemDescription = @ItemDescription, ItemClassification = @ItemClassification where ItemID = @ItemID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ItemName", SqlDbType.VarChar).Value = Itemname
        cmd.Parameters.AddWithValue("@ItemQuantity", SqlDbType.VarChar).Value = ItemQuantity
        cmd.Parameters.AddWithValue("@ItemDescription", SqlDbType.VarChar).Value = ItemDescription
        cmd.Parameters.AddWithValue("@ItemClassification", SqlDbType.VarChar).Value = ItemClass
        cmd.Parameters.AddWithValue("@ItemID", SqlDbType.Int).Value = ItemID

        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub


    Public Sub AddService(ServiceName As String, ServiceDetails As String, Body As String, Hair As String, Nails As String, Status As String, Description As String, Face As String)
        Call ConnectTOSQLServer()
        strSQL = "INSERT INTO [dbo].[tblServices]([Name],[Details],[Body],[Hair],[Nails],[Face],[Status],[Description])VALUES(@ServiceName,@ServiceDetails,@Body,@Hair,@Nails,@ServiceStatus,@Description,@Face)"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ServiceName", SqlDbType.VarChar).Value = ServiceName
        cmd.Parameters.AddWithValue("@ServiceDetails", SqlDbType.VarChar).Value = ServiceDetails
        cmd.Parameters.AddWithValue("@Body", SqlDbType.VarChar).Value = Body
        cmd.Parameters.AddWithValue("@Hair", SqlDbType.VarChar).Value = Hair
        cmd.Parameters.AddWithValue("@Nails", SqlDbType.VarChar).Value = Nails
        cmd.Parameters.AddWithValue("@Face", SqlDbType.VarChar).Value = Face
        cmd.Parameters.AddWithValue("@ServiceStatus", SqlDbType.VarChar).Value = Status
        cmd.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = Description

        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub UpdateService(ServiceName As String, ServiceDetails As String, Body As String, Hair As String, Nails As String, Status As String, ServiceID As Int32, Description As String, Face As String)
        Call ConnectTOSQLServer()
        strSQL = "update tblServices set Name = @ServiceName, Details = @ServiceDetails, Body = @Body, Hair = @Hair, Nails = @Nails,Face = @Face ,Status = @ServiceStatus, Description = @Description where ServiceID = @ServiceID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ServiceName", SqlDbType.VarChar).Value = ServiceName
        cmd.Parameters.AddWithValue("@ServiceDetails", SqlDbType.VarChar).Value = ServiceDetails
        cmd.Parameters.AddWithValue("@Body", SqlDbType.VarChar).Value = Body
        cmd.Parameters.AddWithValue("@Hair", SqlDbType.VarChar).Value = Hair
        cmd.Parameters.AddWithValue("@Nails", SqlDbType.VarChar).Value = Nails
        cmd.Parameters.AddWithValue("@Face", SqlDbType.VarChar).Value = Face
        cmd.Parameters.AddWithValue("@ServiceStatus", SqlDbType.VarChar).Value = Status
        cmd.Parameters.AddWithValue("@ServiceID", SqlDbType.Int).Value = ServiceID
        cmd.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = Description

        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub AddTransaction(customer As String, body As String, hair As String, nails As String, service As Int32, emp As Int32, remarks As String)
        Call ConnectTOSQLServer()
        strSQL = "insert into tblTransactions(CustomerName,Date,Body,Hair,Nails,ServiceAvailedID,EmployeeAssignedID,CreationDate,CreatedBy,DataStatus,Remarks) values (@Customer,getdate(),@Body,@Hair,@Nails,@Service,@Emp,getdate(),@creator,'ACTIVE',@Remarks)"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Customer", SqlDbType.VarChar).Value = customer
        cmd.Parameters.AddWithValue("@Body", SqlDbType.VarChar).Value = body
        cmd.Parameters.AddWithValue("@Hair", SqlDbType.VarChar).Value = hair
        cmd.Parameters.AddWithValue("@Nails", SqlDbType.VarChar).Value = nails
        cmd.Parameters.AddWithValue("@Service", SqlDbType.Int).Value = service
        cmd.Parameters.AddWithValue("@Emp", SqlDbType.Int).Value = emp
        cmd.Parameters.AddWithValue("@creator", SqlDbType.Int).Value = login_id
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = remarks
        Console.WriteLine(strSQL)
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Public Sub PasswordRecovery(Username As String, Question As String, Answer As String)
        Call ConnectTOSQLServer()
        login_name = ""
        strSQL = "select AccountName,AccountID,Username,AccessType,AccountType as AccountStatus from tbllogins where SecretQuestion = @SecretQ and Username = @Username and Answer = @Answer"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@SecretQ", SqlDbType.VarChar).Value = Question
        cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username
        cmd.Parameters.AddWithValue("@Answer", SqlDbType.VarChar).Value = Answer
        reader = cmd.ExecuteReader()
        Console.WriteLine(strSQL)
        strSQL = "select AccountName,AccountID,Username,AccessType,AccountType as AccountStatus from tbllogins where SecretQuestion = '" & Question & "' and Username = '" & Username & "' and Answer = '" & Answer & "'"
        Console.WriteLine(strSQL)
        Do While reader.HasRows
            Do While reader.Read()
                login_name = reader.GetString(0)
                login_id = reader.GetInt32(1)
                login_username = reader.GetString(2)
                login_accesstype = reader.GetString(3)
                login_accountstatus = reader.GetString(4)
            Loop
            reader.NextResult()
        Loop
        Try
            If reader.Read() Then
                strSQL = "update tblLogins set Password = @Default where AccountID = @AccountID"
                cmd = New SqlCommand(strSQL, Connection)
                cmd.Parameters.AddWithValue("@Default", SqlDbType.VarChar).Value = defaultPassword
                cmd.Parameters.AddWithValue("@AccountID", SqlDbType.Int).Value = login_id
                cmd.ExecuteNonQuery()
                Console.WriteLine(strSQL)
            End If
        Finally
            reader.Close()
        End Try
        reader.Close()
        Call DisConnectSQLServer()
    End Sub

End Module
