Option Strict On

Public Class TimeEntry

    Public Property GUID As Guid
    Public Property EntryDate As DateTime
    Public Property Job As Job

    ''' <summary>
    ''' In minutes
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TimeSpent As Decimal

    Public ReadOnly Property TimeSpentInHours As Decimal
        Get
            Return TimeSpent / 60D
        End Get
    End Property

    Public ReadOnly Property TimeSpentAsTimeSpan As TimeSpan
        Get
            Return TimeSpan.FromMinutes(CDbl(TimeSpent))
        End Get
    End Property

    Public ReadOnly Property TimeSpentInHoursMinutes As Tuple(Of Decimal, Decimal)
        Get
            Dim hours As Decimal = Math.Truncate(TimeSpent / 60D)
            Return Tuple.Create(hours, TimeSpent - hours * 60D)
        End Get
    End Property

    Public Property Comment As String

    Public Sub New()
        GUID = System.Guid.NewGuid()
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim te As TimeEntry = TryCast(obj, TimeEntry)
        Return te IsNot Nothing AndAlso Me.GUID = te.GUID
    End Function

    Public Overrides Function ToString() As String
        Return String.Join(" ", {EntryDate.ToShortDateString(),
                                 TimeSpentAsTimeSpan.ToString()})
    End Function

    Public Function ToLongString() As String
        Return String.Format("Time entry on {0} for {1:F2} hours",
                             EntryDate.ToShortDateString(),
                             TimeSpentInHours)
    End Function

End Class
