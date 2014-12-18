<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditJobForm
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
        Me.TheCancelButton = New System.Windows.Forms.Button()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.TheJobCreationBox = New FP_Freelance_Time_Tracker.JobCreationBox()
        Me.SuspendLayout()
        '
        'TheCancelButton
        '
        Me.TheCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TheCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.TheCancelButton.Location = New System.Drawing.Point(12, 293)
        Me.TheCancelButton.Name = "TheCancelButton"
        Me.TheCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.TheCancelButton.TabIndex = 0
        Me.TheCancelButton.Text = "&Cancel"
        Me.TheCancelButton.UseVisualStyleBackColor = True
        '
        'ContinueButton
        '
        Me.ContinueButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContinueButton.Location = New System.Drawing.Point(277, 293)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(75, 23)
        Me.ContinueButton.TabIndex = 1
        Me.ContinueButton.Text = "Button2"
        Me.ContinueButton.UseVisualStyleBackColor = True
        '
        'JobCreationBox1
        '
        Me.TheJobCreationBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TheJobCreationBox.Job = Nothing
        Me.TheJobCreationBox.Location = New System.Drawing.Point(12, 12)
        Me.TheJobCreationBox.Name = "JobCreationBox1"
        Me.TheJobCreationBox.Size = New System.Drawing.Size(340, 275)
        Me.TheJobCreationBox.TabIndex = 2
        '
        'AddEditJobForm
        '
        Me.AcceptButton = Me.ContinueButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.TheCancelButton
        Me.ClientSize = New System.Drawing.Size(364, 328)
        Me.Controls.Add(Me.TheJobCreationBox)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.TheCancelButton)
        Me.MaximizeBox = False
        Me.Name = "AddEditJobForm"
        Me.Text = "AddEditJobForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TheCancelButton As System.Windows.Forms.Button
    Friend WithEvents ContinueButton As System.Windows.Forms.Button
    Friend WithEvents TheJobCreationBox As FP_Freelance_Time_Tracker.JobCreationBox
End Class
