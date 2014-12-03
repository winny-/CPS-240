Option Strict On

Imports PA_10_W_Weinert.Account

Public Class LogicLayer

    Private Property DataLayer As New DataLayer

    Public ReadOnly Property DatabaseIsOpen As Boolean
        Get
            Return DataLayer.ConnectionIsOpen
        End Get
    End Property

    Public ReadOnly Property FileName As String
        Get
            Return DataLayer.FileName
        End Get
    End Property

    Public ReadOnly Property TotalFunds As Decimal
        Get
            Return Accounts.Sum(Function(a As Account) a.Funds)
        End Get
    End Property

    Public Property LastFileOpened As String
        Get
            Return CType(Application.UserAppDataRegistry.GetValue("lastfile"), String)
        End Get
        Private Set(value As String)
            Application.UserAppDataRegistry.SetValue("lastfile", value)
        End Set
    End Property

    Public Property BankName As String
        Get
            Dim o As Object = Nothing
            DataLayer.GetMetadata("BankName", o)
            Return TryCast(o, String)
        End Get
        Set(value As String)
            DataLayer.SetMetadata("BankName", value)
        End Set
    End Property

    Public Function CloseDatabase() As Boolean
        Return DataLayer.CloseDatabase()
    End Function

    Public Function OpenFile(fname As String) As Boolean
        LastFileOpened = fname
        Return DataLayer.OpenDatabase(fname)
    End Function

    Public Function NewFile(fname As String) As Boolean
        If Not DataLayer.CreateDatabase(fname) Then Return False
        LastFileOpened = fname
        Dim fullUserName As String = System.Security.Principal.WindowsIdentity.GetCurrent().Name
        Dim domainlessUserName As String = fullUserName.Substring(fullUserName.IndexOf("\"c) + 1)
        BankName = "First Bank of " & domainlessUserName
        Return True
    End Function

    Public Function OpenDefaultFile() As Boolean
        Return DataLayer.OpenDatabase(DataLayer.DefaultDBPath)
    End Function

    Public Function Accounts() As List(Of Account)
        Return DataLayer.Accounts()
    End Function

    Public Function Transactions() As List(Of Transaction)
        Return DataLayer.Transactions()
    End Function

    Public Function AddAccount(a As Account) As Boolean
        Return DataLayer.AddAccount(a)
    End Function

    Public Function RemoveAccount(a As Account) As Boolean
        Return DataLayer.RemoveAccount(a)
    End Function

    Public Function AddTransaction(t As Transaction) As Boolean
        Return DataLayer.AddTransaction(t)
    End Function

    Public Function OpenLastFileOrDefault() As Boolean
        If LastFileOpened Is Nothing Then
            Return OpenDefaultFile()
        Else
            Return OpenFile(LastFileOpened)
        End If
    End Function

    Public Shared Function HasDatabaseSupport() As Boolean
        Return DataLayer.OLEProviderInstalled(DataLayer.DefaultProvider)
    End Function

End Class
