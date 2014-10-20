Option Strict On

Imports PA_6_W_Weinert

Public Class BusinessAndDataLayer

    Public Const RatePerSecond As Decimal = 0.1D

    Private _TotalFees As Decimal = 0
    Private _Videos As New List(Of Video)

    Public ReadOnly Property TotalFees As Decimal
        Get
            Return _TotalFees
        End Get
    End Property

    Public ReadOnly Property Videos As List(Of Video)
        Get
            Return _Videos
        End Get
    End Property

    Public ReadOnly Property RentedVideos As List(Of Video)
        Get
            Return (From v In Videos Where v.CurrentState = Video.State.Rented).ToList()
        End Get
    End Property

    Public ReadOnly Property AvailableVideos As List(Of Video)
        Get
            Return (From v In Videos Where v.CurrentState = Video.State.Available).ToList()
        End Get
    End Property

    Public Sub Add(ByVal v As Video)
        _Videos.Add(v)
    End Sub

    Public Sub Remove(ByVal v As Video)
        _Videos.Remove(v)
    End Sub

    Public Sub Rent(ByVal v As Video)
        v.Rent()
    End Sub

    Public Function Return_(ByVal v As Video) As Decimal
        Dim cost As Decimal = CostForDuration(v.Return_())
        _TotalFees += cost
        Return cost
    End Function

    Public Function CostForDuration(ByVal duration As TimeSpan) As Decimal
        Return CDec(Math.Ceiling(duration.TotalSeconds)) * RatePerSecond
    End Function

    Public Function TitleIsUnique(ByVal title As String) As Boolean
        Return Videos.All(Function(v As Video) v.Title <> title)
    End Function

End Class
