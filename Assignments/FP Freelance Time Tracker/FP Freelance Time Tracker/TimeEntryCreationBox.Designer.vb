<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeEntryCreationBox
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
        Me.components = New System.ComponentModel.Container()
        Me.EntryDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.MinutesTextBox = New System.Windows.Forms.TextBox()
        Me.HoursErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MinutesErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.HoursErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutesErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EntryDateTimePicker
        '
        Me.EntryDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntryDateTimePicker.Location = New System.Drawing.Point(3, 26)
        Me.EntryDateTimePicker.Name = "EntryDateTimePicker"
        Me.EntryDateTimePicker.Size = New System.Drawing.Size(186, 20)
        Me.EntryDateTimePicker.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entry &Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Time Spent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Hours"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "&Minutes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "&Comment"
        '
        'CommentTextBox
        '
        Me.CommentTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommentTextBox.Location = New System.Drawing.Point(7, 139)
        Me.CommentTextBox.Multiline = True
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(182, 54)
        Me.CommentTextBox.TabIndex = 8
        '
        'HoursTextBox
        '
        Me.HoursTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HoursTextBox.Location = New System.Drawing.Point(91, 70)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(81, 20)
        Me.HoursTextBox.TabIndex = 9
        '
        'MinutesTextBox
        '
        Me.MinutesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinutesTextBox.Location = New System.Drawing.Point(91, 96)
        Me.MinutesTextBox.Name = "MinutesTextBox"
        Me.MinutesTextBox.Size = New System.Drawing.Size(81, 20)
        Me.MinutesTextBox.TabIndex = 10
        '
        'HoursErrorProvider
        '
        Me.HoursErrorProvider.ContainerControl = Me
        '
        'MinutesErrorProvider
        '
        Me.MinutesErrorProvider.ContainerControl = Me
        '
        'TimeEntryCreationBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MinutesTextBox)
        Me.Controls.Add(Me.HoursTextBox)
        Me.Controls.Add(Me.CommentTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EntryDateTimePicker)
        Me.MinimumSize = New System.Drawing.Size(195, 203)
        Me.Name = "TimeEntryCreationBox"
        Me.Size = New System.Drawing.Size(195, 203)
        CType(Me.HoursErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutesErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EntryDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CommentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinutesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents MinutesErrorProvider As System.Windows.Forms.ErrorProvider

End Class
