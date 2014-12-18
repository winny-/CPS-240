<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobInfoBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RateTextBox = New System.Windows.Forms.TextBox()
        Me.StartDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalEarnedTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HoursSpentTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Client"
        '
        'ClientTextBox
        '
        Me.ClientTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClientTextBox.Location = New System.Drawing.Point(3, 20)
        Me.ClientTextBox.Name = "ClientTextBox"
        Me.ClientTextBox.ReadOnly = True
        Me.ClientTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClientTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Rate per hour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Start Date"
        '
        'RateTextBox
        '
        Me.RateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RateTextBox.Location = New System.Drawing.Point(3, 63)
        Me.RateTextBox.Name = "RateTextBox"
        Me.RateTextBox.ReadOnly = True
        Me.RateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RateTextBox.TabIndex = 3
        '
        'StartDateTextBox
        '
        Me.StartDateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartDateTextBox.Location = New System.Drawing.Point(3, 102)
        Me.StartDateTextBox.Name = "StartDateTextBox"
        Me.StartDateTextBox.ReadOnly = True
        Me.StartDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StartDateTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Notes"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotesTextBox.Location = New System.Drawing.Point(3, 141)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.ReadOnly = True
        Me.NotesTextBox.Size = New System.Drawing.Size(100, 51)
        Me.NotesTextBox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Total Earned"
        '
        'TotalEarnedTextBox
        '
        Me.TotalEarnedTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalEarnedTextBox.Location = New System.Drawing.Point(3, 250)
        Me.TotalEarnedTextBox.Name = "TotalEarnedTextBox"
        Me.TotalEarnedTextBox.ReadOnly = True
        Me.TotalEarnedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalEarnedTextBox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "&Hours Spent"
        '
        'HoursSpentTextBox
        '
        Me.HoursSpentTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HoursSpentTextBox.Location = New System.Drawing.Point(3, 211)
        Me.HoursSpentTextBox.Name = "HoursSpentTextBox"
        Me.HoursSpentTextBox.ReadOnly = True
        Me.HoursSpentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HoursSpentTextBox.TabIndex = 11
        '
        'JobInfoBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HoursSpentTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TotalEarnedTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StartDateTextBox)
        Me.Controls.Add(Me.RateTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ClientTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "JobInfoBox"
        Me.Size = New System.Drawing.Size(108, 274)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotalEarnedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents HoursSpentTextBox As System.Windows.Forms.TextBox

End Class
