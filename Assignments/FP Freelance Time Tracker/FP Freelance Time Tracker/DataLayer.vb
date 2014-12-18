Option Strict On

Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.Win32

Public Class DataLayer

    Public Const DefaultProvider As String = "Microsoft.ACE.OLEDB.12.0"

    Public Property FileName As String = Nothing

    Public Property ConnectionString As String
    Public Property MainConnection As OleDbConnection

    Public ReadOnly Property ConnectionIsOpen As Boolean
        Get
            Return MainConnection IsNot Nothing AndAlso
                MainConnection.State = ConnectionState.Open
        End Get
    End Property

    Public Function CreateDatabase(fname As String, Optional ByRef err As String = Nothing) As Boolean
        File.WriteAllBytes(fname, My.Resources.TestTimeTracker)
        Return OpenDatabase(fname, err)
    End Function

    Public Function OpenDatabase(fname As String, Optional ByRef err As String = Nothing) As Boolean
        If Not File.Exists(fname) Then
            err = "File does not exist: " & fname
            Debug.WriteLine(err)
            Return False
        End If
        Dim builder As New OleDbConnectionStringBuilder()
        builder.Provider = DefaultProvider
        builder.DataSource = fname
        ConnectionString = builder.ConnectionString
        Try
            MainConnection = New OleDbConnection(ConnectionString)
            MainConnection.Open()
            FileName = fname
        Catch ex As Exception
            err = "Failed to open database: " & ex.ToString()
            Debug.WriteLine(err)
            If ConnectionIsOpen Then MainConnection.Close()
            Return False
        End Try
        Return True
    End Function

    Public Function CloseDatabase() As Boolean
        If ConnectionIsOpen Then MainConnection.Close()
        FileName = Nothing
        Return Not ConnectionIsOpen
    End Function

    Public Function CreateCommand(query As String) As OleDbCommand
        Dim command As OleDbCommand = MainConnection.CreateCommand()
        command.CommandText = query
        Return command
    End Function

    Public Function AddJob(j As Job) As Boolean
        Dim command As OleDbCommand = CreateCommand("INSERT INTO Job VALUES (?, ?, ?, ?, ?)")
        With command.Parameters
            .Add("@GUID", OleDbType.VarWChar).Value = j.GUID.ToString()
            .Add("@Rate", OleDbType.Currency).Value = j.Rate
            .Add("@StartDate", OleDbType.Date).Value = j.StartDate
            .Add("@Notes", OleDbType.VarWChar).Value = j.Notes
            .Add("@Client", OleDbType.VarWChar).Value = j.Client.Name
        End With
        Return command.ExecuteNonQuery() = 1
    End Function

    Public Function ModifyJob(j As Job) As Boolean
        Dim command As OleDbCommand = CreateCommand("UPDATE Job SET Rate = ?, StartDate = ?, Notes = ?, Client = ? WHERE GUID=?")
        With command.Parameters
            .Add("@Rate", OleDbType.Currency).Value = j.Rate
            .Add("@StartDate", OleDbType.Date).Value = j.StartDate
            .Add("@Notes", OleDbType.VarWChar).Value = j.Notes
            .Add("@Client", OleDbType.VarWChar).Value = j.Client.Name
            .Add("@GUID", OleDbType.VarWChar).Value = j.GUID.ToString()
        End With
        Return command.ExecuteNonQuery() = 1
    End Function

    Public Function RemoveJob(j As Job) As Boolean
        Dim command As OleDbCommand = CreateCommand("DELETE FROM TimeEntry WHERE JobGUID=?")
        command.Parameters.Add("@JobGUID", OleDbType.VarWChar).Value = j.GUID.ToString()
        command.ExecuteNonQuery()
        Return RemoveOnlyJob(j)
    End Function

    Private Function RemoveOnlyJob(j As Job) As Boolean
        Dim command As OleDbCommand = CreateCommand("DELETE FROM Job WHERE GUID=?")
        command.Parameters.Add("@GUID", OleDbType.VarWChar).Value = j.GUID.ToString()
        Return command.ExecuteNonQuery() = 1
    End Function

    Public Function AddTimeEntry(te As TimeEntry) As Boolean
        Dim command As OleDbCommand = CreateCommand("INSERT INTO TimeEntry VALUES (?, ?, ?, ?, ?)")
        With command.Parameters
            .Add("@GUID", OleDbType.VarWChar).Value = te.GUID.ToString()
            .Add("@JobGUID", OleDbType.VarWChar).Value = te.Job.GUID.ToString()
            .Add("@Comment", OleDbType.VarWChar).Value = te.Comment
            .Add("@TimeSpent", OleDbType.Decimal).Value = te.TimeSpent
            .Add("@EntryDate", OleDbType.Date).Value = te.EntryDate
        End With
        Return command.ExecuteNonQuery() = 1
    End Function

    Public Function ModifyTimeEntry(te As TimeEntry) As Boolean
        Dim command As OleDbCommand = CreateCommand("UPDATE TimeEntry SET Comment = ?, TimeSpent = ?, EntryDate = ? WHERE GUID=?")
        With command.Parameters
            .Add("@Comment", OleDbType.VarWChar).Value = te.Comment
            .Add("@TimeSpent", OleDbType.Decimal).Value = te.TimeSpent
            .Add("@EntryDate", OleDbType.Date).Value = te.EntryDate
            .Add("@GUID", OleDbType.VarWChar).Value = te.GUID.ToString()
        End With
        Return command.ExecuteNonQuery() = 1
    End Function

    Public Function RemoveTimeEntry(te As TimeEntry) As Boolean
        Dim command As OleDbCommand = CreateCommand("DELETE FROM TimeEntry WHERE GUID=?")
        command.Parameters.Add("@GUID", OleDbType.VarWChar).Value = te.GUID.ToString()
        Return command.ExecuteNonQuery() = 1
    End Function

    Public Function Jobs() As List(Of Job)
        Dim command As OleDbCommand = CreateCommand("SELECT * FROM Job LEFT OUTER JOIN TimeEntry On Job.GUID=TimeEntry.JobGUID")
        Dim reader As OleDbDataReader = command.ExecuteReader()

        Dim L As New List(Of Job)
        While reader.Read()
            Dim guid As Guid = System.Guid.Parse(reader.GetString(0))

            Dim job As Job = (From jj As Job In L Where jj.GUID = guid).SingleOrDefault()

            If job Is Nothing Then
                job = New Job
                job.TimeEntries = New List(Of TimeEntry)
                job.GUID = guid
                job.Rate = reader.GetDecimal(1)
                job.StartDate = reader.GetDateTime(2)
                job.Notes = reader.GetString(3)
                job.Client = New Client With {.Name = reader.GetString(4)}
                L.Add(job)
            Else
                job.TimeEntries = job.TimeEntries
            End If

            If Not reader.IsDBNull(5) Then
                Dim te As New TimeEntry
                te.Job = job
                te.GUID = System.Guid.Parse(reader.GetString(5))
                te.Comment = reader.GetString(7)
                te.TimeSpent = reader.GetDecimal(8)
                te.EntryDate = reader.GetDateTime(9)
                job.TimeEntries.Add(te)
            End If
        End While
        Return L
    End Function


    Public Shared Function OLEProviderInstalled(provider As String) As Boolean
        Dim providerKey As RegistryKey = Registry.ClassesRoot.OpenSubKey(provider)
        Return providerKey IsNot Nothing AndAlso
            providerKey.OpenSubKey("CLSID") IsNot Nothing
    End Function

    Public Shared Function CanOpenDatabase() As Boolean
        Dim tempFile As String = Path.GetTempFileName()
        File.WriteAllBytes(tempFile, My.Resources.Dummy)
        Dim connectionStringBuilder As New OleDbConnectionStringBuilder
        connectionStringBuilder.Provider = DefaultProvider
        connectionStringBuilder.DataSource = tempFile
        Dim conn As New OleDbConnection(connectionStringBuilder.ConnectionString)
        Dim success As Boolean
        Try
            conn.Open()
            success = True
        Catch ex As Exception

        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
            File.Delete(tempFile)
        End Try

        Return success
    End Function

    Public Shared Function AccessDatabaseDriverInstalled() As Boolean
        Return OLEProviderInstalled(DefaultProvider) AndAlso CanOpenDatabase()
    End Function

End Class
