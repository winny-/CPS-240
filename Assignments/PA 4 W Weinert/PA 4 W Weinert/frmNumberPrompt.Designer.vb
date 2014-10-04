<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumberPrompt
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
        Me.nudNumber = New System.Windows.Forms.NumericUpDown()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.nudNumber.Location = New System.Drawing.Point(12, 26)
        Me.nudNumber.Name = "NumericUpDown1"
        Me.nudNumber.Size = New System.Drawing.Size(120, 20)
        Me.nudNumber.TabIndex = 0
        '
        'Button1
        '
        Me.btnExit.Location = New System.Drawing.Point(31, 52)
        Me.btnExit.Name = "Button1"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "&Okay"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(9, 9)
        Me.lblPrompt.Name = "Label1"
        Me.lblPrompt.Size = New System.Drawing.Size(0, 13)
        Me.lblPrompt.TabIndex = 2
        '
        'frmNumberPrompt
        '
        Me.AcceptButton = Me.btnExit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(143, 87)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.nudNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNumberPrompt"
        Me.Text = "NumberPrompt"
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
End Class
