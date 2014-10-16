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

    Public Const MAX_ACCOUNTS As Integer = 4

    Private Const ID_FORMAT As String = "Q{0:D1}"
    'The spaces at the line beginnings are to even out the left horzontal padding to match the vertical padding.
    Private Const DETAILS_FORMAT As String =
        " ID: {0}" & ControlChars.NewLine &
        " Name: {1}" & ControlChars.NewLine &
        " Balance: {2:C}"

    '*****************************************************************
    'Shared fields and properties
    '*****************************************************************

    Private Shared _UsedNames As New List(Of String)
    Private Shared _TotalFunds As Decimal
    Private Shared _IdCount As Integer = 1

    Public Shared ReadOnly Property TotalFunds As Decimal
        Get
            Return _TotalFunds
        End Get
    End Property

    '*****************************************************************
    'Private fields and public properties
    '*****************************************************************

    Private _Funds As Decimal
    Private _Name As String
    Private _Id As String
    Private _Transactions As New List(Of Transaction)

    Public ReadOnly Property Funds As Decimal
        Get
            Return _Funds
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return _Name
        End Get
    End Property

    Public ReadOnly Property Id As String
        Get
            Return _Id
        End Get
    End Property

    Public ReadOnly Property Transactions As List(Of Transaction)
        Get
            Return _Transactions
        End Get
    End Property

    '*****************************************************************
    'Constructors
    '*****************************************************************

    Public Sub New(ByVal name As String)
        If Not ValidateName(name) Then Throw New Exception(String.Format("Name ""{0}"" is not valid.", name))
        _UsedNames.Add(name.ToLower())
        _Name = name
        _Id = MakeNewID()
    End Sub

    '*****************************************************************
    'Banking logic
    '*****************************************************************

    Private Shared Function MakeNewID() As String
        Dim n As Integer = _IdCount
        _IdCount += 1
        Return String.Format(ID_FORMAT, n)
    End Function

    Private Sub AddTransaction(ByVal amount As Decimal, ByVal kind As Transaction.TransactionType)
        _Transactions.Add(New Transaction(Date.Now(), kind, amount, Me))
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
                _Funds -= amount
                _TotalFunds -= amount
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
            _Funds += amount
            _TotalFunds += amount
            AddTransaction(amount, Transaction.TransactionType.Deposit)
        End SyncLock

        Return True 'No double-entry bookkeeping here
    End Function

    '*****************************************************************
    'Display as String
    '*****************************************************************

    Public Overrides Function ToString() As String
        Return Name
    End Function

    Public Function ToDetailsString() As String
        Return String.Format(DETAILS_FORMAT, Id, Name, Funds)
    End Function

    '*****************************************************************
    'Input validation
    '*****************************************************************

    Public Shared Function ValidateName(ByVal name As String) As Boolean
        'Basically anything that starts with a letter and ends with a letter is okay.
        'Hyphens, spaces, and apostraphe are all okay in the middle.
        Dim validFormat As Boolean = Regex.IsMatch(name, "^(?![-' ])[a-zA-Z-' ]*[a-zA-Z]$")

        'True and only true if all elements satisfy the lambda's condition.
        Dim isUnique As Boolean = _UsedNames.All(Function(n As String) n <> name.ToLower())

        Return validFormat And isUnique
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
                              value * Pow(10, nPlaces))
        Dim wantedPart As Decimal = Math.Truncate(x)
        Return x = wantedPart
    End Function

    Public Shared Function Pow(ByVal base As Decimal, ByVal exponent As Integer) As Decimal
        Dim result As Decimal = 1
        Debug.Assert(exponent > 0) 'Bad and hacky implementation
        For i As Integer = exponent To 1 Step -1
            result *= base
        Next
        Return result
    End Function

End Class
