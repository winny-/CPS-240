<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobCreationBox
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.RateTextBox = New System.Windows.Forms.TextBox()
        Me.ClientErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RateErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ClientErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RateErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Client"
        '
        'ClientTextBox
        '
        Me.ClientTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClientTextBox.Location = New System.Drawing.Point(4, 21)
        Me.ClientTextBox.Name = "ClientTextBox"
        Me.ClientTextBox.Size = New System.Drawing.Size(166, 20)
        Me.ClientTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Start Date"
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartDateTimePicker.Location = New System.Drawing.Point(4, 108)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Size = New System.Drawing.Size(183, 20)
        Me.StartDateTimePicker.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 135)
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
        Me.NotesTextBox.Location = New System.Drawing.Point(4, 151)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(188, 30)
        Me.NotesTextBox.TabIndex = 7
        '
        'RateTextBox
        '
        Me.RateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RateTextBox.Location = New System.Drawing.Point(4, 68)
        Me.RateTextBox.Name = "RateTextBox"
        Me.RateTextBox.Size = New System.Drawing.Size(166, 20)
        Me.RateTextBox.TabIndex = 3
        '
        'ClientErrorProvider
        '
        Me.ClientErrorProvider.ContainerControl = Me
        '
        'RateErrorProvider
        '
        Me.RateErrorProvider.ContainerControl = Me
        '
        'JobCreationBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RateTextBox)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StartDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ClientTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "JobCreationBox"
        Me.Size = New System.Drawing.Size(195, 184)
        CType(Me.ClientErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RateErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StartDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents RateErrorProvider As System.Windows.Forms.ErrorProvider

End Class
