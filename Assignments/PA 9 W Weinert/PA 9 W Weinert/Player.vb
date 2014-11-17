Option Strict On

Imports System.Text.RegularExpressions

<Serializable>
Public Class Player

    Private _Name As String
    Public ReadOnly Property Name As String
        Get
            Return _Name
        End Get
    End Property

    Public ReadOnly Property Wins As Integer
        Get
            Return Matches.Where(Function(m As Match) m.Winner = Me).Count
        End Get
    End Property

    Public ReadOnly Property Losses As Integer
        Get
            Return Matches.Where(Function(m As Match) m.Winner <> Me).count
        End Get
    End Property

    Public Property Matches As New List(Of Match)

    Public Sub New(name As String)
        _Name = name
    End Sub

    Public Shared Operator =(a As Player, b As Player) As Boolean
        Return a.Name = b.Name
    End Operator

    Public Shared Operator <>(a As Player, b As Player) As Boolean
        Return Not a = b
    End Operator

    Public Shared Function ValidateName(name As String) As Boolean
        Return Regex.IsMatch(name, "^[a-zA-Z]+$")
    End Function

End Class
