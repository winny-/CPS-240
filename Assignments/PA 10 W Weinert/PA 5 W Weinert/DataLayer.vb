Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports PA_10_W_Weinert.Account

Public Class DataLayer

    Public ReadOnly Property DefaultDBPath As String
        Get
            Return Path.Combine(Directory.GetCurrentDirectory, "TestBank.accdb")
        End Get
    End Property

    Public Property FileName As String = Nothing

    Public Const DefaultProvider As String = "Microsoft.ACE.OLEDB.12.0"

    Public Property ConnectionString As String
    Public Property MainConnection As OleDbConnection

    Private Property MetadataNOSQLTable As NoSQLTable

    Public ReadOnly Property ConnectionIsOpen As Boolean
        Get
            Return MainConnection IsNot Nothing AndAlso
                MainConnection.State = ConnectionState.Open
        End Get
    End Property

    Public Function CreateDatabase(fname As String) As Boolean
        File.WriteAllBytes(fname, My.Resources.TestBank)

        Return OpenDatabase(fname)
    End Function

    Public Function OpenDatabase(fname As String) As Boolean
        If Not File.Exists(fname) Then Return False
        Dim builder As New OleDbConnectionStringBuilder()
        builder.Provider = DefaultProvider
        builder.DataSource = fname

        ConnectionString = builder.ConnectionString

        Try
            MainConnection = New OleDbConnection(ConnectionString)
            MainConnection.Open()

            MetadataNOSQLTable = New NoSQLTable(MainConnection, "Metadata")

            FileName = fname
        Catch ex As Exception
            If ConnectionIsOpen Then MainConnection.Close()
            Return False
        End Try

        Return True
    End Function

    Public Function CloseDatabase() As Boolean
        If ConnectionIsOpen Then MainConnection.Close()
        FileName = Nothing
        Return Not ConnectionIsOpen
    End Function

    Public Function GetMetadata(key As String, ByRef obj As Object) As Boolean
        Debug.Assert(ConnectionIsOpen)
        Return MetadataNOSQLTable.GetValue(key, obj)
    End Function

    Public Function SetMetadata(key As String, obj As Object) As Boolean
        Debug.Assert(ConnectionIsOpen)
        Return MetadataNOSQLTable.SetValue(key, obj)
    End Function

    Public Function CreateCommand(query As String) As OleDbCommand
        Dim command As OleDbCommand = MainConnection.CreateCommand()
        command.CommandText = query
        Return command
    End Function

    Public Function AddTransaction(t As Account.Transaction) As Boolean
        Dim command As OleDbCommand = CreateCommand("INSERT INTO [Transaction] VALUES (?, ?, ?, ?, ?)")
        With command.Parameters
            .Add("@UUID", OleDbType.VarWChar).Value = t.UUID.ToString()
            .Add("@AccountUUID", OleDbType.VarWChar).Value = t.Account.UUID.ToString()
            .Add("@TransactionType", OleDbType.VarWChar).Value = t.Kind.ToString()
            .Add("@Time", OleDbType.Date).Value = t.Time
            .Add("@Amount", OleDbType.Decimal).Value = t.Amount
        End With
        Return command.ExecuteNonQuery() = 1
    End Function

    Public Function AddAccount(a As Account) As Boolean
        Dim command As OleDbCommand = CreateCommand("INSERT INTO Account VALUES (?, ?, ?, ?)")
        With command.Parameters
            .Add("@UUID", OleDbType.VarWChar).Value = a.UUID.ToString()
            .Add("@FirstName", OleDbType.VarWChar).Value = a.FirstName
            .Add("@LastName", OleDbType.VarWChar).Value = a.LastName
            .Add("@Created", OleDbType.Date).Value = a.Created
        End With
        Return command.ExecuteNonQuery() = 1
    End Function

    Public Function RemoveAccount(a As Account) As Boolean
        Dim nTransactions As Integer = a.Transactions.Count
        Dim command As OleDbCommand = CreateCommand("DELETE FROM Account WHERE UUID=?")
        command.Parameters.Add("@UUID", OleDbType.VarWChar).Value = a.UUID.ToString()
        If command.ExecuteNonQuery() <> 1 Then Return False
        Dim command2 As OleDbCommand = CreateCommand("DELETE FROM [Transaction] WHERE AccountUUID=?")
        command2.Parameters.Add("@AccountUUID", OleDbType.VarWChar).Value = a.UUID.ToString()
        Debug.Assert(command2.ExecuteNonQuery() = nTransactions, "Failed to delete all transactions.")
        Return True
    End Function

    Public Function Accounts() As List(Of Account)
        Dim command As OleDbCommand = CreateCommand("SELECT * FROM Account LEFT OUTER JOIN [Transaction] ON Account.UUID=[Transaction].AccountUUID")
        Dim reader As OleDbDataReader = command.ExecuteReader()
        Dim D As New Dictionary(Of Account, List(Of Transaction))
        While reader.Read()
            Dim uuid As Guid = Guid.Parse(reader.GetString(0))
            Dim account As Account = (From kvp As KeyValuePair(Of Account, List(Of Transaction)) In D
                                      Where kvp.Key.UUID = uuid
                                      Select kvp.Key
                                      ).SingleOrDefault()
            Dim transactionList As List(Of Transaction)
            If account Is Nothing Then
                transactionList = New List(Of Transaction)
                account = New Account(reader.GetString(1),
                                      reader.GetString(2),
                                      Guid.Parse(reader.GetString(0)),
                                      reader.GetDateTime(3),
                                      transactionList)
                account.DataDelegate = Me
                D.Add(account, transactionList)
            Else
                transactionList = D(account)
            End If
            If Not reader.IsDBNull(4) Then
                Dim o As Object = [Enum].Parse(GetType(Transaction.TransactionType), reader.GetString(6))
                transactionList.Add(New Transaction(reader.GetDateTime(7),
                                                    DirectCast(o, Transaction.TransactionType),
                                                    reader.GetDecimal(8),
                                                    account,
                                                    Guid.Parse(reader.GetString(4))))
            End If
        End While
        Return D.Keys.ToList()
    End Function

    Public Function Transactions() As List(Of Transaction)
        Return (From t As Transaction In Accounts.SelectMany(Function(a As Account) a.Transactions)
                Order By t.Time Ascending
                ).ToList()
    End Function

End Class
