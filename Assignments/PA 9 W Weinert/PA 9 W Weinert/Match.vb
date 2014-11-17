Option Strict On

<Serializable>
Public Class Match

    Private _Winner As Player
    Public ReadOnly Property Winner As Player
        Get
            Return _Winner
        End Get
    End Property

    Private _Players As List(Of Player)
    Public ReadOnly Property Players As List(Of Player)
        Get
            Return _Players.ToList() 'Return a copy
        End Get
    End Property

    Public Sub New(players As List(Of Player))
        _Players = players
        ChooseWinner()
        _Players.ForEach(Sub(p As Player) p.Matches.Add(Me))
    End Sub

    Private Sub ChooseWinner()
        Static r As New Random
        _Winner = Players(r.Next(0, Players.Count))
    End Sub

End Class
