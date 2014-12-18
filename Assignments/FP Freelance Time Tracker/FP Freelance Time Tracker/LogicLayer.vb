Option Strict On

Public Class LogicLayer

    Private Property DataLayer As New DataLayer

    Public ReadOnly Property DatabaseIsOpen As Boolean
        Get
            Return DataLayer.ConnectionIsOpen
        End Get
    End Property

    Public Function AccessDatabaseDriverInstalled() As Boolean
        Return DataLayer.AccessDatabaseDriverInstalled()
    End Function

    Public Function Jobs() As List(Of Job)
        Return DataLayer.Jobs()
    End Function

    Public Function CreateDatabase(fname As String, ByRef err As String) As Boolean
        Return DataLayer.CreateDatabase(fname, err)
    End Function

    Public Function OpenDatabase(fname As String, ByRef err As String) As Boolean
        Return DataLayer.OpenDatabase(fname, err)
    End Function

    Public Function CloseDatabase() As Boolean
        Return DataLayer.CloseDatabase()
    End Function

    Public Function AddJob(j As Job) As Boolean
        Return DataLayer.AddJob(j)
    End Function

    Public Function EditJob(j As Job) As Boolean
        Return DataLayer.ModifyJob(j)
    End Function

    Public Function RemoveJob(j As Job) As Boolean
        Return DataLayer.RemoveJob(j)
    End Function

    Public Function AddTimeEntry(te As TimeEntry) As Boolean
        Return DataLayer.AddTimeEntry(te)
    End Function

    Public Function EditTimeEntry(te As TimeEntry) As Boolean
        Return DataLayer.ModifyTimeEntry(te)
    End Function

    Public Function RemoveTimeEntry(te As TimeEntry) As Boolean
        Return RemoveTimeEntry(te)
    End Function

End Class
