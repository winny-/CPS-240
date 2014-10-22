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

    '*****************************************************************
    'Get all, rented, or available videos as a list
    '*****************************************************************

    Public ReadOnly Property Videos As List(Of Video)
        Get
            Return _Videos
        End Get
    End Property

    Public ReadOnly Property RentedVideos As List(Of Video)
        Get
            Return Videos.Where(Function(v As Video) Not v.Available).ToList()
        End Get
    End Property

    Public ReadOnly Property AvailableVideos As List(Of Video)
        Get
            Return Videos.Where(Function(v As Video) v.Available).ToList()
        End Get
    End Property

    '*****************************************************************
    'Videos (list) property operation wrappers
    '*****************************************************************

    Public Sub Add(ByVal v As Video)
        _Videos.Add(v)
    End Sub

    Public Sub Remove(ByVal v As Video)
        _Videos.Remove(v)
    End Sub

    '*****************************************************************
    'Video operation wrappers
    '*****************************************************************

    Public Sub Rent(ByVal v As Video)
        v.Rent()
    End Sub

    Public Function Return_(ByVal v As Video) As Decimal
        Dim cost As Decimal = CostForDuration(v.Return_())
        _TotalFees += cost
        Return cost
    End Function

    '*****************************************************************
    'Utility
    '*****************************************************************

    Public Function CostForDuration(ByVal duration As TimeSpan) As Decimal
        'We floor seconds because every whole second counts towards the cost.
        'Explicitly use an integral data type.
        Dim wholeSeconds As Integer = CInt(Math.Ceiling(duration.TotalSeconds))

        Return wholeSeconds * RatePerSecond
    End Function

    Public Function TitleIsUnique(ByVal title As String) As Boolean
        'True and only True when title is not used by a known video.
        Return Videos.All(Function(v As Video) v.Title.ToLower() <> title.ToLower())
    End Function

End Class
