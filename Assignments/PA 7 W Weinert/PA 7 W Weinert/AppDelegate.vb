Option Strict On

Public Class AppDelegate

    Private _Misses As Integer = 0
    Private _TotalMisses As Integer = 0
    Private _GameCount As Integer = 0
    Private _InGame As Boolean

    Public Property Deck As DeckUtility.Deck

    Public ReadOnly Property Misses As Integer
        Get
            Return _Misses
        End Get
    End Property

    Public ReadOnly Property TotalMisses As Integer
        Get
            Return _TotalMisses
        End Get
    End Property

    Public ReadOnly Property AverageMisses As Double
        Get
            If GameCount = 0 Then Return -1
            Return CDbl(TotalMisses) / CDbl(GameCount)
        End Get
    End Property

    Public ReadOnly Property GameCount As Integer
        Get
            Return _GameCount
        End Get
    End Property

    Public ReadOnly Property InGame As Boolean
        Get
            Return _InGame
        End Get
    End Property

    Public Sub New()
        Deck = DeckUtility.DefaultDeck
    End Sub

    Public Function CardWasMiss() As Integer
        _Misses += 1
        Return Misses
    End Function

    Public Sub GameWasStarted()
        _InGame = True
    End Sub

    Public Sub GameWasFinished()
        _GameCount += 1
        _TotalMisses += _Misses
        _Misses = 0
        _InGame = False
    End Sub

End Class
