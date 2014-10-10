Option Strict On

Imports System.Text.RegularExpressions

Public Class Account

    '*****************************************************************
    'Constants
    '*****************************************************************

    Public Const MAX_ACCOUNTS As Integer = 5

    Private Const ID_FORMAT As String = "Q{0:D1}"
    Private Const DETAILS_FORMAT As String =
        "ID: {0}" & ControlChars.NewLine &
        "Name: {1}" & ControlChars.NewLine &
        "Balance: {2:C}"

    '*****************************************************************
    'Shared fields and properties
    '*****************************************************************

    Private Shared _totalFunds As Decimal
    Private Shared _idCount As Integer = 1

    Public Shared ReadOnly Property totalFunds As Decimal
        Get
            Return _totalFunds
        End Get
    End Property

    '*****************************************************************
    'Private fields and public properties
    '*****************************************************************

    Private _funds As Decimal
    Private _name As String
    Private _id As String

    Public ReadOnly Property funds As Decimal
        Get
            Return _funds
        End Get
    End Property

    Public ReadOnly Property name As String
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property id As String
        Get
            Return _id
        End Get
    End Property

    '*****************************************************************
    'Constructors
    '*****************************************************************

    Public Sub New(ByVal name As String)
        _name = name
        _id = newID()
    End Sub

    '*****************************************************************
    'Banking logic
    '*****************************************************************

    Private Shared Function newID() As String
        Dim n As Integer = _idCount
        _idCount += 1
        Return String.Format(ID_FORMAT, n)
    End Function

    Public Function canWithdraw(ByVal amount As Decimal) As Boolean
        Return amount <= funds
    End Function

    Public Function withdraw(ByVal amount As Decimal) As Boolean
        Debug.Assert(amount > 0)
        Dim v As Boolean
        SyncLock Me 'Only one person in the vault at once
            v = canWithdraw(amount)
            If v Then
                _funds -= amount
                _totalFunds -= amount
            End If
        End SyncLock
        Return v
    End Function

    Public Function deposit(ByVal amount As Decimal) As Boolean
        Debug.Assert(amount > 0)
        SyncLock Me 'Only one person in the vault at once
            _funds += amount
            _totalFunds += amount
        End SyncLock
        Return True
    End Function

    '*****************************************************************
    'Display as String
    '*****************************************************************

    Public Overrides Function ToString() As String
        Return name
    End Function

    Public Function details() As String
        Return String.Format(DETAILS_FORMAT, id, name, funds)
    End Function

    '*****************************************************************
    'Input validation
    '*****************************************************************

    Public Shared Function NameIsValid(ByVal name As String) As Boolean
        'Basically anything that starts with a letter and ends with a letter is okay.
        'Hyphens, spaces, and apostraphe are all okay in the middle.
        Return Regex.IsMatch(name, "^(?![-' ])[a-zA-Z-' ]*[a-zA-Z]$")
    End Function

    Public Shared Function CurrencyIsValid(ByVal amount As Decimal) As Boolean
        Return amount > 0
    End Function

    Public Shared Function CurrencyIsValid(ByVal amount As String) As Boolean
        Dim n As Decimal
        Return TryParseCurrency(amount, n)
    End Function

    Public Shared Function TryParseCurrency(ByVal s As String, ByRef n As Decimal) As Boolean
        Dim valid As Boolean = Decimal.TryParse(s, n) AndAlso CurrencyIsValid(n)
        If Not valid Then n = 0
        Return valid
    End Function

End Class
