Option Strict On

<Serializable>
Public Class Game

    Private _Matches As New List(Of Match)
    Public ReadOnly Property Matches As List(Of Match)
        Get
            Return _Matches.ToList()
        End Get
    End Property

    Public ReadOnly Property TotalMatches As Integer
        Get
            Return Matches.Count
        End Get
    End Property

    Private _Players As New List(Of Player)
    Public ReadOnly Property Players As List(Of Player)
        Get
            Return _Players.ToList()
        End Get
    End Property

    Public Function Play() As Match
        Dim m As New Match(Players)
        _Matches.Add(m)
        Return m
    End Function

    Public Function AddPlayer(p As Player) As Boolean
        If Not NameIsUnique(p.Name) Then Return False
        _Players.Add(p)
        Return True
    End Function

    Public Function RemovePlayer(p As Player) As Boolean
        Return _Players.Remove(p)
    End Function

    Public Function NameIsUnique(name As String) As Boolean
        Return Players.All(Function(p As Player) p.Name.ToLower() <> name.ToLower())
    End Function

End Class
