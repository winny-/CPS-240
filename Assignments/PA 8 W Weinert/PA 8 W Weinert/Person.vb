Option Strict On

Imports System.Text.RegularExpressions

Public Class Person
    Implements IComparable(Of Person)

    Private _ID As Integer
    Private _Name As String
    Private _Cash As Decimal

    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return _Name
        End Get
    End Property

    Public ReadOnly Property Cash As Decimal
        Get
            Return _Cash
        End Get
    End Property

    Public Sub New(name As String, id As Integer, cash As Decimal)
        If id < 0 Then Throw New ArgumentException()
        If Not ValidateCash(cash) Then Throw New ArgumentException()
        _Name = name
        _ID = id
        _Cash = cash
    End Sub

    Public Sub AddCash(amount As Decimal)
        If amount <= 0 OrElse Not ValidateCash(amount) Then Throw New ArgumentException()
        _Cash += amount
    End Sub

    Public Shared Operator =(a As Person, b As Person) As Boolean
        Return a.Name = b.Name AndAlso a.ID = b.ID AndAlso a.Cash = b.Cash
    End Operator

    Public Shared Operator <>(a As Person, b As Person) As Boolean
        Return Not a = b
    End Operator
    Public Shared Operator <(a As Person, b As Person) As Boolean
        If a = b Then Return False
        If a.ID <> b.ID Then Return a.ID < b.ID
        If a.Name <> b.Name Then Return a.Name < b.Name
        If a.Cash <> b.Cash Then Return a.Cash < b.Cash
        Debug.Fail("Failed to compared Persons")
        Return False
    End Operator

    Public Shared Operator >(a As Person, b As Person) As Boolean
        Return b < a
    End Operator

    Public Overrides Function ToString() As String
        Return String.Format("P{0} {1}: {2:C}", ID, Name, Cash)
    End Function

    Public Overloads Function CompareTo(other As Person) As Integer Implements IComparable(Of PA_8_W_Weinert.Person).CompareTo
        Return If(Me = other,
          0,
          If(Me < other,
             -1,
             1))
    End Function

    Public Shared Function ValidateName(name As String) As Boolean
        Return Regex.IsMatch(name, "^[A-Za-z]+$")
    End Function

    Public Shared Function ValidateCash(amount As Decimal) As Boolean
        Return amount >= 0 AndAlso amount.HasNDecimalPlacesOrLess(2)
    End Function

    Public Function ToRecord() As String
        Return String.Join(ControlChars.NewLine, {"P" & ID.ToString(),
                                                  Name,
                                                  Cash.ToString()})
    End Function

End Class