<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditTimeEntryForm
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
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.TheCancelButton = New System.Windows.Forms.Button()
        Me.TheTimeEntryCreationBox = New FP_Freelance_Time_Tracker.TimeEntryCreationBox()
        Me.SuspendLayout()
        '
        'ContinueButton
        '
        Me.ContinueButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContinueButton.Location = New System.Drawing.Point(321, 342)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(75, 23)
        Me.ContinueButton.TabIndex = 1
        Me.ContinueButton.Text = "Button1"
        Me.ContinueButton.UseVisualStyleBackColor = True
        '
        'TheCancelButton
        '
        Me.TheCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TheCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.TheCancelButton.Location = New System.Drawing.Point(12, 342)
        Me.TheCancelButton.Name = "TheCancelButton"
        Me.TheCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.TheCancelButton.TabIndex = 2
        Me.TheCancelButton.Text = "&Cancel"
        Me.TheCancelButton.UseVisualStyleBackColor = True
        '
        'TimeEntryCreationBox1
        '
        Me.TheTimeEntryCreationBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TheTimeEntryCreationBox.Location = New System.Drawing.Point(12, 12)
        Me.TheTimeEntryCreationBox.MinimumSize = New System.Drawing.Size(195, 203)
        Me.TheTimeEntryCreationBox.Name = "TimeEntryCreationBox1"
        Me.TheTimeEntryCreationBox.Size = New System.Drawing.Size(384, 324)
        Me.TheTimeEntryCreationBox.TabIndex = 3
        Me.TheTimeEntryCreationBox.TimeEntry = Nothing
        '
        'AddEditTimeEntryForm
        '
        Me.AcceptButton = Me.ContinueButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.TheCancelButton
        Me.ClientSize = New System.Drawing.Size(408, 367)
        Me.Controls.Add(Me.TheTimeEntryCreationBox)
        Me.Controls.Add(Me.TheCancelButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.MaximizeBox = False
        Me.Name = "AddEditTimeEntryForm"
        Me.Text = "Add a time entry"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContinueButton As System.Windows.Forms.Button
    Friend WithEvents TheCancelButton As System.Windows.Forms.Button
    Friend WithEvents TheTimeEntryCreationBox As FP_Freelance_Time_Tracker.TimeEntryCreationBox
End Class
