Option Strict On

Public Class LogicLayer

    Private Property _MyDataLayer As New DataLayer

    Public ReadOnly Property CanPlay As Boolean
        Get
            Return Game.Players.Count >= 2 'Need at least two players.
        End Get
    End Property

    Public ReadOnly Property FileName As String
        Get
            Return _MyDataLayer.FileName
        End Get
    End Property

    Public ReadOnly Property ShortFileName As String
        Get
            Return System.IO.Path.GetFileNameWithoutExtension(FileName)
        End Get
    End Property

    Public ReadOnly Property Game As Game
        Get
            Return _MyDataLayer.Game
        End Get
    End Property

    Public ReadOnly Property HaveFile As Boolean
        Get
            Return _MyDataLayer.FileName IsNot Nothing AndAlso
                _MyDataLayer.Game IsNot Nothing
        End Get
    End Property

    Public Function CloseFile() As Boolean
        Dim success As Boolean = _MyDataLayer.WriteGame()
        If success Then _MyDataLayer.Reset()
        Return success
    End Function

    Public Function OpenFile(fname As String) As Boolean
        _MyDataLayer.FileName = fname
        Return _MyDataLayer.ReadGame()
    End Function

    Public Function NewFile(fname As String) As Boolean
        If Not CloseFile() Then Return False
        _MyDataLayer.FileName = fname
        Return _MyDataLayer.WriteGame()
    End Function

    Public Function AddPlayer(p As Player) As Boolean
        Return _MyDataLayer.Game.AddPlayer(p) AndAlso _MyDataLayer.WriteGame()
    End Function

    Public Function RemovePlayer(p As Player) As Boolean
        Return _MyDataLayer.Game.RemovePlayer(p) AndAlso _MyDataLayer.WriteGame()
    End Function

    Public Function Play() As Match
        Dim m As Match = _MyDataLayer.Game.Play()
        _MyDataLayer.WriteGame()
        Return m
    End Function

End Class
