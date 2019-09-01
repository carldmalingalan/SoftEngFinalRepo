Option Explicit On
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports System.Configuration
Imports System.Data.SqlTypes
Imports Excel = Microsoft.Office.Interop.Excel
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
    Public sqlConnectionString = "Server=MARCO\SQLEXPRESS;Database=JandA;Trusted_Connection=True;"

    Public accountID As Int32
    Public itemID As Int32
    Public saveType As String 'accounts
    Public saveType1 As String 'items
    Public saveType2 As String 'transactions
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

    Public Sub PasswordChange(NewPassword As String)
        Call ConnectTOSQLServer()
        strSQL = "update tblLogins set Password = @Password, LastModified = @AccountID, LastModifiedDate = getdate() where AccountID = @AccountID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = GetHash(NewPassword)
        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.VarChar).Value = login_id
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
        strSQL = "update tblLogins set AccountType = 'ACTIVE' where AccountID = @AccountID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.VarChar).Value = AccountID
        cmd.ExecuteNonQuery()
        Console.WriteLine(strSQL)
        Call DisConnectSQLServer()
    End Sub

    Public Sub DeactivateAccount(AccountID As Int32)
        Call ConnectTOSQLServer()
        strSQL = "update tblLogins set AccountType = 'INACTIVE' where AccountID = @AccountID"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.Parameters.AddWithValue("@AccountID", SqlDbType.Int).Value = AccountID
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


    Public Sub AddEmployee(Firstname As String, Lastname As String, Middle As String, Contact As String, Email As String, Body As String, Hair As String, Nails As String)
        Call ConnectTOSQLServer()
        strSQL = ""
        Call DisConnectSQLServer()

    End Sub
End Module
