<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewTimeEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveTimeEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DockedSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.JobsSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.JobsListBox = New System.Windows.Forms.ListBox()
        Me.RemoveJobButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddJobButton = New System.Windows.Forms.Button()
        Me.TheJobInfoBox = New FP_Freelance_Time_Tracker.JobInfoBox()
        Me.EditJobButton = New System.Windows.Forms.Button()
        Me.TimeEntriesSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RemoveTimeEntryButton = New System.Windows.Forms.Button()
        Me.TimeEntriesListBox = New System.Windows.Forms.ListBox()
        Me.AddTimeEntryButton = New System.Windows.Forms.Button()
        Me.EditTimeEntryButton = New System.Windows.Forms.Button()
        Me.TheTimeEntryInfoBox = New FP_Freelance_Time_Tracker.TimeEntryInfoBox()
        Me.OpenDatabaseDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDatabaseDialog = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DockedSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockedSplitContainer.Panel1.SuspendLayout()
        Me.DockedSplitContainer.Panel2.SuspendLayout()
        Me.DockedSplitContainer.SuspendLayout()
        CType(Me.JobsSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JobsSplitContainer.Panel1.SuspendLayout()
        Me.JobsSplitContainer.Panel2.SuspendLayout()
        Me.JobsSplitContainer.SuspendLayout()
        CType(Me.TimeEntriesSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimeEntriesSplitContainer.Panel1.SuspendLayout()
        Me.TimeEntriesSplitContainer.Panel2.SuspendLayout()
        Me.TimeEntriesSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.JobToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1069, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDatabaseToolStripMenuItem, Me.OpenDatabaseToolStripMenuItem, Me.CloseDatabaseToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewDatabaseToolStripMenuItem
        '
        Me.NewDatabaseToolStripMenuItem.Name = "NewDatabaseToolStripMenuItem"
        Me.NewDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewDatabaseToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.NewDatabaseToolStripMenuItem.Text = "&New Database"
        '
        'OpenDatabaseToolStripMenuItem
        '
        Me.OpenDatabaseToolStripMenuItem.Name = "OpenDatabaseToolStripMenuItem"
        Me.OpenDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenDatabaseToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.OpenDatabaseToolStripMenuItem.Text = "&Open Database"
        '
        'CloseDatabaseToolStripMenuItem
        '
        Me.CloseDatabaseToolStripMenuItem.Name = "CloseDatabaseToolStripMenuItem"
        Me.CloseDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseDatabaseToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CloseDatabaseToolStripMenuItem.Text = "&Close Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'JobToolStripMenuItem
        '
        Me.JobToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewJobToolStripMenuItem, Me.RemoveJobToolStripMenuItem, Me.ToolStripSeparator2, Me.NewTimeEntryToolStripMenuItem, Me.RemoveTimeEntryToolStripMenuItem})
        Me.JobToolStripMenuItem.Name = "JobToolStripMenuItem"
        Me.JobToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.JobToolStripMenuItem.Text = "&Job"
        '
        'NewJobToolStripMenuItem
        '
        Me.NewJobToolStripMenuItem.Name = "NewJobToolStripMenuItem"
        Me.NewJobToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.NewJobToolStripMenuItem.Text = "&New Job"
        '
        'RemoveJobToolStripMenuItem
        '
        Me.RemoveJobToolStripMenuItem.Name = "RemoveJobToolStripMenuItem"
        Me.RemoveJobToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RemoveJobToolStripMenuItem.Text = "&Remove Job"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'NewTimeEntryToolStripMenuItem
        '
        Me.NewTimeEntryToolStripMenuItem.Name = "NewTimeEntryToolStripMenuItem"
        Me.NewTimeEntryToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.NewTimeEntryToolStripMenuItem.Text = "Ne&w Time Entry"
        '
        'RemoveTimeEntryToolStripMenuItem
        '
        Me.RemoveTimeEntryToolStripMenuItem.Name = "RemoveTimeEntryToolStripMenuItem"
        Me.RemoveTimeEntryToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RemoveTimeEntryToolStripMenuItem.Text = "Re&move Time Entry"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'DockedSplitContainer
        '
        Me.DockedSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockedSplitContainer.Location = New System.Drawing.Point(0, 24)
        Me.DockedSplitContainer.Name = "DockedSplitContainer"
        '
        'DockedSplitContainer.Panel1
        '
        Me.DockedSplitContainer.Panel1.Controls.Add(Me.JobsSplitContainer)
        '
        'DockedSplitContainer.Panel2
        '
        Me.DockedSplitContainer.Panel2.Controls.Add(Me.TimeEntriesSplitContainer)
        Me.DockedSplitContainer.Size = New System.Drawing.Size(1069, 534)
        Me.DockedSplitContainer.SplitterDistance = 508
        Me.DockedSplitContainer.TabIndex = 1
        '
        'JobsSplitContainer
        '
        Me.JobsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobsSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.JobsSplitContainer.Name = "JobsSplitContainer"
        '
        'JobsSplitContainer.Panel1
        '
        Me.JobsSplitContainer.Panel1.Controls.Add(Me.JobsListBox)
        Me.JobsSplitContainer.Panel1.Controls.Add(Me.RemoveJobButton)
        Me.JobsSplitContainer.Panel1.Controls.Add(Me.Label1)
        Me.JobsSplitContainer.Panel1.Controls.Add(Me.AddJobButton)
        '
        'JobsSplitContainer.Panel2
        '
        Me.JobsSplitContainer.Panel2.Controls.Add(Me.TheJobInfoBox)
        Me.JobsSplitContainer.Panel2.Controls.Add(Me.EditJobButton)
        Me.JobsSplitContainer.Size = New System.Drawing.Size(508, 534)
        Me.JobsSplitContainer.SplitterDistance = 225
        Me.JobsSplitContainer.TabIndex = 0
        '
        'JobsListBox
        '
        Me.JobsListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JobsListBox.FormattingEnabled = True
        Me.JobsListBox.Location = New System.Drawing.Point(12, 30)
        Me.JobsListBox.Name = "JobsListBox"
        Me.JobsListBox.Size = New System.Drawing.Size(197, 433)
        Me.JobsListBox.TabIndex = 1
        '
        'RemoveJobButton
        '
        Me.RemoveJobButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RemoveJobButton.Location = New System.Drawing.Point(64, 498)
        Me.RemoveJobButton.Name = "RemoveJobButton"
        Me.RemoveJobButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveJobButton.TabIndex = 5
        Me.RemoveJobButton.Text = "&Remove Job"
        Me.RemoveJobButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Jobs"
        '
        'AddJobButton
        '
        Me.AddJobButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AddJobButton.Location = New System.Drawing.Point(64, 469)
        Me.AddJobButton.Name = "AddJobButton"
        Me.AddJobButton.Size = New System.Drawing.Size(75, 23)
        Me.AddJobButton.TabIndex = 2
        Me.AddJobButton.Text = "&Add Job"
        Me.AddJobButton.UseVisualStyleBackColor = True
        '
        'JobInfoBox1
        '
        Me.TheJobInfoBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TheJobInfoBox.Job = Nothing
        Me.TheJobInfoBox.Location = New System.Drawing.Point(12, 3)
        Me.TheJobInfoBox.Name = "JobInfoBox1"
        Me.TheJobInfoBox.Size = New System.Drawing.Size(258, 490)
        Me.TheJobInfoBox.TabIndex = 6
        '
        'EditJobButton
        '
        Me.EditJobButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.EditJobButton.Location = New System.Drawing.Point(101, 499)
        Me.EditJobButton.Name = "EditJobButton"
        Me.EditJobButton.Size = New System.Drawing.Size(75, 23)
        Me.EditJobButton.TabIndex = 3
        Me.EditJobButton.Text = "&Edit Job"
        Me.EditJobButton.UseVisualStyleBackColor = True
        '
        'TimeEntriesSplitContainer
        '
        Me.TimeEntriesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeEntriesSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.TimeEntriesSplitContainer.Name = "TimeEntriesSplitContainer"
        '
        'TimeEntriesSplitContainer.Panel1
        '
        Me.TimeEntriesSplitContainer.Panel1.Controls.Add(Me.Label2)
        Me.TimeEntriesSplitContainer.Panel1.Controls.Add(Me.RemoveTimeEntryButton)
        Me.TimeEntriesSplitContainer.Panel1.Controls.Add(Me.TimeEntriesListBox)
        Me.TimeEntriesSplitContainer.Panel1.Controls.Add(Me.AddTimeEntryButton)
        '
        'TimeEntriesSplitContainer.Panel2
        '
        Me.TimeEntriesSplitContainer.Panel2.Controls.Add(Me.EditTimeEntryButton)
        Me.TimeEntriesSplitContainer.Panel2.Controls.Add(Me.TheTimeEntryInfoBox)
        Me.TimeEntriesSplitContainer.Size = New System.Drawing.Size(557, 534)
        Me.TimeEntriesSplitContainer.SplitterDistance = 303
        Me.TimeEntriesSplitContainer.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Time Entries"
        '
        'RemoveTimeEntryButton
        '
        Me.RemoveTimeEntryButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RemoveTimeEntryButton.Location = New System.Drawing.Point(100, 498)
        Me.RemoveTimeEntryButton.Name = "RemoveTimeEntryButton"
        Me.RemoveTimeEntryButton.Size = New System.Drawing.Size(111, 23)
        Me.RemoveTimeEntryButton.TabIndex = 2
        Me.RemoveTimeEntryButton.Text = "&Remove Time Entry"
        Me.RemoveTimeEntryButton.UseVisualStyleBackColor = True
        '
        'TimeEntriesListBox
        '
        Me.TimeEntriesListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeEntriesListBox.FormattingEnabled = True
        Me.TimeEntriesListBox.Location = New System.Drawing.Point(12, 30)
        Me.TimeEntriesListBox.Name = "TimeEntriesListBox"
        Me.TimeEntriesListBox.Size = New System.Drawing.Size(279, 433)
        Me.TimeEntriesListBox.TabIndex = 1
        '
        'AddTimeEntryButton
        '
        Me.AddTimeEntryButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AddTimeEntryButton.Location = New System.Drawing.Point(111, 469)
        Me.AddTimeEntryButton.Name = "AddTimeEntryButton"
        Me.AddTimeEntryButton.Size = New System.Drawing.Size(90, 23)
        Me.AddTimeEntryButton.TabIndex = 1
        Me.AddTimeEntryButton.Text = "&Add Time Entry"
        Me.AddTimeEntryButton.UseVisualStyleBackColor = True
        '
        'EditTimeEntryButton
        '
        Me.EditTimeEntryButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.EditTimeEntryButton.Location = New System.Drawing.Point(77, 499)
        Me.EditTimeEntryButton.Name = "EditTimeEntryButton"
        Me.EditTimeEntryButton.Size = New System.Drawing.Size(103, 23)
        Me.EditTimeEntryButton.TabIndex = 3
        Me.EditTimeEntryButton.Text = "&Edit Time Entry"
        Me.EditTimeEntryButton.UseVisualStyleBackColor = True
        '
        'TimeEntryInfoBox1
        '
        Me.TheTimeEntryInfoBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TheTimeEntryInfoBox.Location = New System.Drawing.Point(12, 3)
        Me.TheTimeEntryInfoBox.Name = "TimeEntryInfoBox1"
        Me.TheTimeEntryInfoBox.Size = New System.Drawing.Size(226, 490)
        Me.TheTimeEntryInfoBox.TabIndex = 0
        Me.TheTimeEntryInfoBox.TimeEntry = Nothing
        '
        'OpenDatabaseDialog
        '
        Me.OpenDatabaseDialog.FileName = "OpenFileDialog1"
        Me.OpenDatabaseDialog.Filter = "Access Database files|*.accdb"
        '
        'SaveDatabaseDialog
        '
        Me.SaveDatabaseDialog.Filter = "Access Database files|*.accdb"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 558)
        Me.Controls.Add(Me.DockedSplitContainer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Freelance Time Tracker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DockedSplitContainer.Panel1.ResumeLayout(False)
        Me.DockedSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.DockedSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockedSplitContainer.ResumeLayout(False)
        Me.JobsSplitContainer.Panel1.ResumeLayout(False)
        Me.JobsSplitContainer.Panel1.PerformLayout()
        Me.JobsSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.JobsSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JobsSplitContainer.ResumeLayout(False)
        Me.TimeEntriesSplitContainer.Panel1.ResumeLayout(False)
        Me.TimeEntriesSplitContainer.Panel1.PerformLayout()
        Me.TimeEntriesSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.TimeEntriesSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimeEntriesSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewTimeEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveTimeEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DockedSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents EditJobButton As System.Windows.Forms.Button
    Friend WithEvents AddJobButton As System.Windows.Forms.Button
    Friend WithEvents RemoveJobButton As System.Windows.Forms.Button
    Friend WithEvents JobsSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents JobsListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TheJobInfoBox As FP_Freelance_Time_Tracker.JobInfoBox
    Friend WithEvents TimeEntriesSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimeEntriesListBox As System.Windows.Forms.ListBox
    Friend WithEvents EditTimeEntryButton As System.Windows.Forms.Button
    Friend WithEvents RemoveTimeEntryButton As System.Windows.Forms.Button
    Friend WithEvents AddTimeEntryButton As System.Windows.Forms.Button
    Friend WithEvents TheTimeEntryInfoBox As FP_Freelance_Time_Tracker.TimeEntryInfoBox
    Friend WithEvents OpenDatabaseDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveDatabaseDialog As System.Windows.Forms.SaveFileDialog

End Class
