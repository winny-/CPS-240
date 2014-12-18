Option Strict On

Public Class MainForm

    Public LogicLayer As New LogicLayer

    Public JobListParent As Control
    Public JobInfoParent As Control
    Public TimeEntryListParent As Control
    Public TimeEntryInfoParent As Control

    Private PleaseSelectJob As Job = Nothing
    Private PleaseSelectTimeEntry As TimeEntry = Nothing

    Public Property SelectedJob As Job
        Get
            Return TryCast(JobsListBox.SelectedItem, Job)
        End Get
        Set(value As Job)
            JobsListBox.SelectedItem = value
        End Set
    End Property

    Public Property SelectedTimeEntry As TimeEntry
        Get
            Return TryCast(TimeEntriesListBox.SelectedItem, TimeEntry)
        End Get
        Set(value As TimeEntry)
            TimeEntriesListBox.SelectedItem = value
        End Set
    End Property

    Public Sub CheckIfAccessDriverIsInstalled()
        If Not LogicLayer.AccessDatabaseDriverInstalled() Then
            Dim s As String = String.Join(ControlChars.NewLine & ControlChars.NewLine, {"The Access OLE (ACE) driver does not appear to be installed. Download from the internet?",
                                                                                        "Make sure to install the version named ""AccessDatabaseEngine.exe""",
                                                                                        "Either way the application will exit."})
            If MessageBox.Show(s, "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Process.Start("http://www.microsoft.com/en-us/download/details.aspx?id=13255")
            End If
            Me.Close()
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If LogicLayer.DatabaseIsOpen Then LogicLayer.CloseDatabase()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'NB: Panel1 and Panel2 properties of the SplitContainer are hardcoded in the .NET Framework.
        JobListParent = JobsSplitContainer.Panel1
        JobInfoParent = JobsSplitContainer.Panel2
        TimeEntryListParent = TimeEntriesSplitContainer.Panel1
        TimeEntryInfoParent = TimeEntriesSplitContainer.Panel2

        CheckIfAccessDriverIsInstalled()

        Display()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim f As New AboutForm
        f.ShowDialog()
    End Sub

    Private Sub ValidateControls()
        Dim haveSelectedJob As Boolean = SelectedJob IsNot Nothing
        Dim haveSelectedTimeEntry As Boolean = SelectedTimeEntry IsNot Nothing
        Dim dbIsOpen As Boolean = LogicLayer.DatabaseIsOpen

        RemoveJobButton.Enabled = haveSelectedJob
        EditJobButton.Enabled = haveSelectedJob
        AddTimeEntryButton.Enabled = haveSelectedJob
        RemoveTimeEntryButton.Enabled = haveSelectedTimeEntry
        EditTimeEntryButton.Enabled = haveSelectedTimeEntry

        NewDatabaseToolStripMenuItem.Enabled = Not dbIsOpen
        CloseDatabaseToolStripMenuItem.Enabled = dbIsOpen
        OpenDatabaseToolStripMenuItem.Enabled = Not dbIsOpen

        NewJobToolStripMenuItem.Enabled = dbIsOpen
        RemoveJobToolStripMenuItem.Enabled = haveSelectedJob
        NewTimeEntryToolStripMenuItem.Enabled = haveSelectedJob
        RemoveTimeEntryToolStripMenuItem.Enabled = haveSelectedTimeEntry

        JobListParent.Enabled = dbIsOpen
        JobInfoParent.Enabled = haveSelectedJob
        TimeEntryListParent.Enabled = haveSelectedJob
        TimeEntryInfoParent.Enabled = haveSelectedTimeEntry
    End Sub

    Private Sub Display()
        Dim seljob As Job = SelectedJob

        JobsListBox.Items.Clear()
        Dim jobs As List(Of Job) = If(LogicLayer.DatabaseIsOpen,
                                      LogicLayer.Jobs(),
                                      New List(Of Job))
        For Each j As Job In jobs : JobsListBox.Items.Add(j) : Next

        SelectedJob = If(PleaseSelectJob IsNot Nothing, PleaseSelectJob, seljob)
        PleaseSelectJob = Nothing
        If SelectedJob Is Nothing Then SelectedJob = jobs.FirstOrDefault()

        ValidateControls()
    End Sub

    Private Sub JobsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobsListBox.SelectedIndexChanged
        TheJobInfoBox.Job = SelectedJob

        Dim selte As TimeEntry = SelectedTimeEntry

        TimeEntriesListBox.Items.Clear()

        TheJobInfoBox.Job = SelectedJob

        If SelectedJob IsNot Nothing AndAlso SelectedJob.TimeEntries.Count > 0 Then
            For Each te As TimeEntry In SelectedJob.TimeEntries : TimeEntriesListBox.Items.Add(te) : Next

            SelectedTimeEntry = If(PleaseSelectTimeEntry IsNot Nothing, PleaseSelectTimeEntry, selte)
            PleaseSelectTimeEntry = Nothing
            If SelectedTimeEntry Is Nothing Then SelectedTimeEntry = SelectedJob.TimeEntries.FirstOrDefault()
        End If

        ValidateControls()
    End Sub

    Private Sub TimeEntriesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TimeEntriesListBox.SelectedIndexChanged
        TheTimeEntryInfoBox.TimeEntry = SelectedTimeEntry
        ValidateControls()
    End Sub



    Private Sub CloseDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseDatabaseToolStripMenuItem.Click
        LogicLayer.CloseDatabase()
        Display()
    End Sub

    Private Sub NewDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDatabaseToolStripMenuItem.Click
        SaveDatabaseDialog.Title = "Create a new database"
        SaveDatabaseDialog.ShowDialog()
        Dim err As String = Nothing
        If Not LogicLayer.CreateDatabase(SaveDatabaseDialog.FileName, err) Then
            MessageBox.Show("Error creating and opening database: " & err)
        End If
        Display()
    End Sub

    Private Sub OpenDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDatabaseToolStripMenuItem.Click
        OpenDatabaseDialog.Title = "Open an existing database"
        If OpenDatabaseDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim err As String = Nothing
            If Not LogicLayer.OpenDatabase(OpenDatabaseDialog.FileName, err) Then
                MessageBox.Show("Error opening existing database: " & err)
            End If
        End If
        Display()
    End Sub

    Private Sub AddJob_Click(sender As Object, e As EventArgs) Handles _
        AddJobButton.Click,
        NewJobToolStripMenuItem.Click

        Dim res As Tuple(Of Job, Boolean) = AddEditJobForm.ShowDialogForNewJob()
        If Not res.Item2 Then Return
        LogicLayer.AddJob(res.Item1)
        PleaseSelectJob = res.Item1
        Display()
    End Sub

    Private Sub RemoveJob_Click(sender As Object, e As EventArgs) Handles _
        RemoveJobButton.Click,
        RemoveJobToolStripMenuItem.Click

        If SelectedJob Is Nothing Then
            Debug.WriteLine("Somehow clicked 'Remove Job' when none selected.")
            Return
        End If

        LogicLayer.RemoveJob(SelectedJob)
        Display()
    End Sub



    Private Sub EditJob_Click(sender As Object, e As EventArgs) Handles EditJobButton.Click
        If SelectedJob Is Nothing Then
            Debug.WriteLine("Somehow clicked 'Edit Job' when none selected.")
            Return
        End If

        Dim res As Tuple(Of Job, Boolean) = AddEditJobForm.ShowDialogForEditJob(SelectedJob)
        If res.Item2 Then
            LogicLayer.EditJob(res.Item1)
            PleaseSelectJob = res.Item1
        End If
        Display()
    End Sub

    Private Sub AddTimeEntry_Click(sender As Object, e As EventArgs) Handles _
        AddTimeEntryButton.Click,
        NewTimeEntryToolStripMenuItem.Click

        Dim res As Tuple(Of TimeEntry, Boolean) = AddEditTimeEntryForm.ShowDialogForNewTimeEntry()
        If Not res.Item2 Then Return
        Dim te As TimeEntry = res.Item1
        te.Job = SelectedJob
        LogicLayer.AddTimeEntry(te)
        PleaseSelectTimeEntry = te
        Display()
    End Sub

    Private Sub RemoveTimeEntry_Click(sender As Object, e As EventArgs) Handles _
        RemoveTimeEntryButton.Click,
        RemoveTimeEntryToolStripMenuItem.Click

        If SelectedTimeEntry Is Nothing Then
            Debug.WriteLine("Somehow clicked 'Remove Time Entry' when none selected.")
            Return
        End If

        LogicLayer.RemoveTimeEntry(SelectedTimeEntry)
        Display()
    End Sub

    Private Sub EditTimeEntry_Click(sender As Object, e As EventArgs) Handles EditTimeEntryButton.Click
        If SelectedTimeEntry Is Nothing Then
            Debug.WriteLine("Somehow clicked 'Edit Time Entry' when none selected.")
            Return
        End If

        Dim res As Tuple(Of TimeEntry, Boolean) = AddEditTimeEntryForm.ShowDialogForEditTimeEntry(SelectedTimeEntry)

        If Not res.Item2 Then Return

        LogicLayer.EditTimeEntry(res.Item1)
        PleaseSelectTimeEntry = res.Item1
        Display()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

End Class
