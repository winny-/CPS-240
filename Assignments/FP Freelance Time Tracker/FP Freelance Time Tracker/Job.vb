Option Strict On

Public Class Job

    Public Property GUID As Guid
    Public Property StartDate As DateTime

    Public Property Rate As Decimal
    Public Property Client As Client
    Public Property Notes As String

    Public Property TimeEntries As List(Of TimeEntry)
    Public ReadOnly Property TotalEarned As Decimal
        Get
            Return TimeEntries.Sum(Function(te As TimeEntry) te.TimeSpentInHours) * Rate
        End Get
    End Property

    Public ReadOnly Property HoursSpent As Decimal
        Get
            Return TimeEntries.Sum(Function(te As TimeEntry) te.TimeSpentInHours)
        End Get
    End Property

    Public Sub New()
        GUID = System.Guid.NewGuid()
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim j As Job = TryCast(obj, Job)
        Return j IsNot Nothing AndAlso Me.GUID = j.GUID
    End Function

    Public Overrides Function ToString() As String
        Return String.Join(" ", {Client.Name,
                                 StartDate.ToShortDateString(),
                                 Rate.ToString("C")})
    End Function

    Public Function ToLongString() As String
        Return String.Format("Job for {0} starting {1} at {2:C}/hr",
                             Client.Name,
                             StartDate.ToShortDateString(),
                             Rate)
    End Function

End Class
