Option Strict On

Imports System.Text.RegularExpressions

''' <summary>
''' An individual's bank account
''' </summary>
''' <remarks>Account is immutable except through the Withdraw(String) and Deposit(String) methods.</remarks>
Partial Public Class Account

    '*****************************************************************
    'Constants
    '*****************************************************************

    'The spaces at the line beginnings are to even out the left horzontal padding to match the vertical padding.
    Private Const DETAILS_FORMAT As String =
        " UUID: {0}" & ControlChars.NewLine &
        " Name: {1} {2}" & ControlChars.NewLine &
        " Balance: {3:C}"

    '*****************************************************************
    'Private fields and public properties
    '*****************************************************************

    Private _FirstName As String
    Private _LastName As String
    Private _Transactions As New List(Of Transaction)
    Private _UUID As Guid
    Private _Created As DateTime

    Public ReadOnly Property Funds As Decimal
        Get
            Return Transactions.Sum(Function(t As Transaction) t.Amount * If(t.Kind = Transaction.TransactionType.Deposit, 1D, -1D))
        End Get
    End Property

    Public ReadOnly Property FirstName As String
        Get
            Return _FirstName
        End Get
    End Property

    Public ReadOnly Property LastName As String
        Get
            Return _LastName
        End Get
    End Property

    Public ReadOnly Property Transactions As List(Of Transaction)
        Get
            Return _Transactions
        End Get
    End Property

    Public ReadOnly Property UUID As Guid
        Get
            Return _UUID
        End Get
    End Property

    Public ReadOnly Property Created As DateTime
        Get
            Return _Created
        End Get
    End Property

    Public Property DataDelegate As DataLayer = Nothing

    '*****************************************************************
    'Constructors
    '*****************************************************************

    Public Sub New(first As String, last As String, uuid As Guid, dateCreated As DateTime, transactions As List(Of Transaction))
        _FirstName = first
        _LastName = last
        _UUID = uuid
        _Created = dateCreated
        _Transactions = transactions
    End Sub

    Public Sub New(first As String, last As String)
        Me.New(first, last, Guid.NewGuid(), DateTime.Now(), New List(Of Transaction))
    End Sub

    '*****************************************************************
    'Banking logic
    '*****************************************************************

    Private Sub AddTransaction(ByVal amount As Decimal, ByVal kind As Transaction.TransactionType)
        Dim t As New Transaction(Date.Now(), kind, amount, Me, Guid.NewGuid())
        If DataDelegate IsNot Nothing Then DataDelegate.AddTransaction(t)
        _Transactions.Add(t)
    End Sub

    Public Function CanWithdraw(ByVal amount As Decimal) As Boolean
        Return amount <= Funds
    End Function

    ''' <summary>
    ''' Make a withdrawal from the account
    ''' </summary>
    ''' <param name="amount">The amount to withdraw</param>
    ''' <returns>Boolean indicating the success or failure of the withdrawal</returns>
    ''' <remarks>Withdraw does its best to prevent out of order operations on the account.</remarks>
    Public Function Withdraw(ByVal amount As Decimal) As Boolean
        Debug.Assert(ValidateCurrency(amount))

        Dim v As Boolean
        SyncLock Me 'Only one person in the vault at once
            v = CanWithdraw(amount)
            If v Then
                AddTransaction(amount, Transaction.TransactionType.Withdrawal)
            End If
        End SyncLock

        Return v
    End Function

    ''' <summary>
    ''' Make a deposit into the account
    ''' </summary>
    ''' <param name="amount">The amount to deposit</param>
    ''' <returns>Always True because deposits are untracked</returns>
    ''' <remarks>Deposit does its best to prevent out of order Withdraws or Deposits</remarks>
    Public Function Deposit(ByVal amount As Decimal) As Boolean
        Debug.Assert(ValidateCurrency(amount))

        SyncLock Me 'Only one person in the vault at once
            AddTransaction(amount, Transaction.TransactionType.Deposit)
        End SyncLock

        Return True 'No double-entry bookkeeping here
    End Function

    '*****************************************************************
    'Display as String
    '*****************************************************************

    Public Overrides Function ToString() As String
        Return FirstName & " " & LastName
    End Function

    Public Function ToDetailsString() As String
        Return String.Format(DETAILS_FORMAT, UUID, FirstName, LastName, Funds)
    End Function

    '*****************************************************************
    'Input validation
    '*****************************************************************

    Public Shared Function ValidateName(ByVal name As String) As Boolean
        'Basically anything that starts with a letter and ends with a letter is okay.
        'Hyphens, spaces, and apostraphe are all okay in the middle.
        Dim validFormat As Boolean = Regex.IsMatch(name, "^(?![-' ])[a-zA-Z-' ]*[a-zA-Z]$")

        Return validFormat
    End Function

    Public Shared Function ValidateCurrency(ByVal amount As Decimal) As Boolean
        Return amount > 0 And HasNDecimalPlacesOrLess(amount, 2)
    End Function

    Public Shared Function ValidateCurrency(ByVal amount As String) As Boolean
        Return TryParseCurrency(amount, Nothing)
    End Function

    Public Shared Function TryParseCurrency(ByVal s As String, ByRef n As Decimal) As Boolean
        Dim valid As Boolean = Decimal.TryParse(s, n) AndAlso ValidateCurrency(n)
        If Not valid Then n = 0 'Behave like Decimal.TryParse(String, Decimal)
        Return valid
    End Function

    Public Shared Function HasNDecimalPlacesOrLess(ByVal value As Decimal, ByVal nPlaces As Integer) As Boolean
        Dim x As Decimal = If(nPlaces = 0,
                              value,
                              value * CDec(Math.Pow(10, nPlaces)))
        Dim wantedPart As Decimal = Math.Truncate(x)
        Return x = wantedPart
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim otherAccount As Account = TryCast(obj, Account)
        Return otherAccount IsNot Nothing AndAlso Me.UUID = otherAccount.UUID
    End Function

End Class
