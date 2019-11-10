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
    Public itemID, itemIDCheckout As Int32
    Public saveType As String 'accounts
    Public saveType1 As String 'items
    Public saveType2 As String 'transactions
    Public lastIdentity, lastTransID As Int32
    Public voidID As Int32
    Public logInfo As String
    Public checkoutqty As String
    Public customerNumber, itemNumber As Integer
    Public checkoutiD, quantitycheckout, transactionCheck As Integer
    Public btnType As String
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


    Public Sub AddItem(Itemname As String, ItemQuantity As String, ItemDescription As String, ItemClass As String, Crit As String, Expi As Object)
        Call ConnectTOSQLServer()
        strSQL = "insert into tblInventory(Name,Quantity,[Description],Classification,Expiration,[Critical Point],CreatedBy,CreationDate) values (@Name,@Quantity,@Desc,@Class,@Expi,@Crit,@Creator,getdate())"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Itemname
        cmd.Parameters.AddWithValue("@Quantity", SqlDbType.VarChar).Value = ItemQuantity
        cmd.Parameters.AddWithValue("@Desc", SqlDbType.VarChar).Value = ItemDescription
        cmd.Parameters.AddWithValue("@Class", SqlDbType.VarChar).Value = ItemClass
        cmd.Parameters.AddWithValue("@Expi", SqlDbType.Date).Value = Expi
        cmd.Parameters.AddWithValue("@Crit", SqlDbType.VarChar).Value = Crit
        cmd.Parameters.AddWithValue("@Creator", SqlDbType.VarChar).Value = login_id

        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Public Sub UpdateItem(Itemname As String, ItemQuantity As Decimal, ItemDescription As String, ItemClass As String, Crit As Decimal, Expi As Object, ItemID As Int32)
        Call ConnectTOSQLServer()
        strSQL = "update tblInventory Set Name = @Name, Quantity = (Quantity + @Quantity), [Description] = @Desc, Classification = @Class, Expiration=@Expi, [Critical Point] = @crit where ItemID = @ItemID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = Itemname
        cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Decimal).Value = ItemQuantity
        cmd.Parameters.AddWithValue("@Desc", SqlDbType.VarChar).Value = ItemDescription
        cmd.Parameters.AddWithValue("@Class", SqlDbType.VarChar).Value = ItemClass
        cmd.Parameters.AddWithValue("@Expi", SqlDbType.Date).Value = Expi
        cmd.Parameters.AddWithValue("@Crit", SqlDbType.Decimal).Value = Crit
        cmd.Parameters.AddWithValue("@ItemID", SqlDbType.Int).Value = ItemID
        Console.WriteLine(strSQL)
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub


    Public Sub AddService(ServiceName As String, Status As String, Description As String, ServiceCategory As String)
        Call ConnectTOSQLServer()
        strSQL = "INSERT INTO [dbo].[tblServices]([Name],[Service Category],[Status],[Description])VALUES(@ServiceName,@ServiceCategory,@ServiceStatus,@Description)"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ServiceName", SqlDbType.VarChar).Value = ServiceName
        cmd.Parameters.AddWithValue("@ServiceCategory", SqlDbType.VarChar).Value = ServiceCategory
        cmd.Parameters.AddWithValue("@ServiceStatus", SqlDbType.VarChar).Value = Status
        cmd.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = Description

        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub UpdateService(ServiceName As String, Status As String, ServiceID As Int32, Description As String, ServiceCategory As String)
        Call ConnectTOSQLServer()
        strSQL = "update tblServices Set Name = @ServiceName, [Service Category] = @ServiceCategory ,Status = @ServiceStatus, Description = @Description where ServiceID = @ServiceID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ServiceName", SqlDbType.VarChar).Value = ServiceName
        cmd.Parameters.AddWithValue("@ServiceCategory", SqlDbType.VarChar).Value = ServiceCategory
        cmd.Parameters.AddWithValue("@ServiceStatus", SqlDbType.VarChar).Value = Status
        cmd.Parameters.AddWithValue("@ServiceID", SqlDbType.Int).Value = ServiceID
        cmd.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = Description

        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub AddTransaction(ServiceID As Int32, CustomerID As Int32, EmployeeID As Int32, Remarks As String)
        Call ConnectTOSQLServer()
        strSQL = "insert into tblTransactions(Date,ServiceID,EmployeeID,CustomerID,CreationDate,CreatedBy,DataStatus,ModdedBy,ModdedDate,Remarks)values(convert(varchar,getdate(),110),@ServiceID,@EmployeeID,@CustomerID,getdate(),@Creator,'ACTIVE',@Modder,getdate(),@Remarks)"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@ServiceID", SqlDbType.Int).Value = ServiceID
        cmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = EmployeeID
        cmd.Parameters.AddWithValue("@CustomerID", SqlDbType.Int).Value = CustomerID
        cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = Remarks
        cmd.Parameters.AddWithValue("@Creator", SqlDbType.Int).Value = login_id
        cmd.Parameters.AddWithValue("@Modder", SqlDbType.Int).Value = login_id
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

    Public Sub RecordLog(Details As String)
        Call ConnectTOSQLServer()
        strSQL = "insert into tblAppLogs(LoginID, [Datetime],Details) values (@LoginID,GETDATE(),@Details)"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@LoginID", SqlDbType.Int).Value = login_id
        cmd.Parameters.AddWithValue("@Details", SqlDbType.VarChar).Value = Details
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub AddCustomer(Lastname As String, Firstname As String, Middle As String)
        Call ConnectTOSQLServer()
        strSQL = "insert into tblCustomer(Lastname, Firstname, [Middle Initial],CreatedBy,CreationDate)values(@Lastname,@Firstname,@Middle,@Author,getdate())"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Lastname", SqlDbType.VarChar).Value = Lastname
        cmd.Parameters.AddWithValue("@Firstname", SqlDbType.VarChar).Value = Firstname
        cmd.Parameters.AddWithValue("@Middle", SqlDbType.VarChar).Value = Middle
        cmd.Parameters.AddWithValue("@Author", SqlDbType.Int).Value = login_id
        cmd.ExecuteNonQuery()

        Console.WriteLine(strSQL)
        strSQL = "select CustomerID from tblCustomer where Createdby = @Login order by CreationDate DESC"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Login", SqlDbType.Int).Value = login_id
        reader = cmd.ExecuteReader()
        Console.WriteLine(strSQL)
        If reader.Read() = True Then
            lastIdentity = reader.GetInt32(0)
        End If
        Call DisConnectSQLServer()
    End Sub


    Public Sub AddTransactionRef(custID As Int32)
        Call ConnectTOSQLServer()
        strSQL = "insert into tblTransactionList    (CustomerID,AuthorID,TransactionDate,DataStatus ) values (@custID,@authID,getdate(),'ACTIVE')"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@custID", SqlDbType.VarChar).Value = custID
        cmd.Parameters.AddWithValue("@authID", SqlDbType.VarChar).Value = login_id
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)

        strSQL = "select TransactionNumber from tblTransactionList where AuthorID = @Login order by TransactionDate DESC"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Login", SqlDbType.Int).Value = login_id
        reader = cmd.ExecuteReader()
        Console.WriteLine(strSQL)
        If reader.Read() = True Then
            lastTransID = reader.GetInt32(0)
        End If
        Call DisConnectSQLServer()
    End Sub

    Public Sub AddCheckOut(Quantity As String)
        Call ConnectTOSQLServer()
        strSQL = "insert tblCheckOutTable(TransactionID,ItemID,Quantity,DataStatus)values(@transID,@itemID,@quantity,'ACTIVE')"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@transID", SqlDbType.VarChar).Value = lastTransID
        cmd.Parameters.AddWithValue("@itemID", SqlDbType.VarChar).Value = itemNumber
        cmd.Parameters.AddWithValue("@quantity", SqlDbType.Decimal).Value = Quantity
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL & lastTransID & " " & itemNumber & " " & Quantity)
        Call DisConnectSQLServer()
    End Sub

    Public Sub UpdateItemThruTransaction(Quantity As Decimal)
        Call ConnectTOSQLServer()
        strSQL = "update tblInventory set Quantity = Quantity - @Quantity where ItemID = @ItemID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@itemID", SqlDbType.VarChar).Value = itemNumber
        cmd.Parameters.AddWithValue("@quantity", SqlDbType.Decimal).Value = Quantity
        cmd.ExecuteNonQuery()

        Console.WriteLine(strSQL)

        Call DisConnectSQLServer()
    End Sub

    Public Sub RemoveItemCheckout()
        Call ConnectTOSQLServer()
        strSQL = "update tblInventory set Quantity = Quantity + @Quantity where ItemID = @itemID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@itemID", SqlDbType.VarChar).Value = itemIDCheckout
        cmd.Parameters.AddWithValue("@Quantity", SqlDbType.VarChar).Value = quantitycheckout
        cmd.ExecuteNonQuery()
        strSQL = "update tblCheckOutTable set DataStatus = 'DELETED' where CheckoutID = " & checkoutiD
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()

        Call DisConnectSQLServer()
    End Sub

    Public Sub VoidTransaction(TransNumber As Int32)
        Call ConnectTOSQLServer()
        strSQL = "Update tblTransactionList set DataStatus = 'DELETED', Voidedby = " & login_id & " where TransactionNumber = " & TransNumber
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()
        strSQL = "update tblTransactions set DataStatus = 'DELETED',ModdedBy = " & login_id & ",ModdedDate = getdate() where TransactionRefID = " & TransNumber
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()
        strSQL = "update tblCheckOutTable set DataStatus = 'DELETED' where TransactionID = " & TransNumber
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()
        strSQL = "UPDATE tblInventory SET Quantity = A.Quantity + B.total FROM dbo.tblInventory AS A INNER JOIN dbo.vw_summarizedTransaction AS B ON A.ItemID = B.ItemID INNER JOIN dbo.tblTransactionList AS C ON C.TransactionNumber = B.TransactionID where B.TransactionID = " & TransNumber
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub
End Module
