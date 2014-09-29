<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnAlpha = New System.Windows.Forms.Button()
        Me.btnBeta = New System.Windows.Forms.Button()
        Me.chkSelect = New System.Windows.Forms.CheckBox()
        Me.chkAccepButton = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAcceptButton = New System.Windows.Forms.Label()
        Me.lblCurrentlySelected = New System.Windows.Forms.Label()
        Me.lblLastClicked = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblClickCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAlpha
        '
        Me.btnAlpha.Location = New System.Drawing.Point(37, 12)
        Me.btnAlpha.Name = "btnAlpha"
        Me.btnAlpha.Size = New System.Drawing.Size(75, 23)
        Me.btnAlpha.TabIndex = 0
        Me.btnAlpha.Text = "&Alpha"
        Me.btnAlpha.UseVisualStyleBackColor = True
        '
        'btnBeta
        '
        Me.btnBeta.Location = New System.Drawing.Point(133, 12)
        Me.btnBeta.Name = "btnBeta"
        Me.btnBeta.Size = New System.Drawing.Size(75, 23)
        Me.btnBeta.TabIndex = 1
        Me.btnBeta.Text = "&Beta"
        Me.btnBeta.UseVisualStyleBackColor = True
        '
        'chkSelect
        '
        Me.chkSelect.AutoSize = True
        Me.chkSelect.Location = New System.Drawing.Point(27, 75)
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.Size = New System.Drawing.Size(136, 17)
        Me.chkSelect.TabIndex = 2
        Me.chkSelect.Text = "&Select() the next button"
        Me.chkSelect.UseVisualStyleBackColor = True
        '
        'chkAccepButton
        '
        Me.chkAccepButton.AutoSize = True
        Me.chkAccepButton.Location = New System.Drawing.Point(27, 98)
        Me.chkAccepButton.Name = "chkAccepButton"
        Me.chkAccepButton.Size = New System.Drawing.Size(199, 17)
        Me.chkAccepButton.TabIndex = 3
        Me.chkAccepButton.Text = "Change &AcceptButton to next button"
        Me.chkAccepButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dummy input"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "AcceptButton is:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Currently Selected control:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Last clicked button:"
        '
        'lblAcceptButton
        '
        Me.lblAcceptButton.AutoSize = True
        Me.lblAcceptButton.Location = New System.Drawing.Point(169, 135)
        Me.lblAcceptButton.Name = "lblAcceptButton"
        Me.lblAcceptButton.Size = New System.Drawing.Size(39, 13)
        Me.lblAcceptButton.TabIndex = 9
        Me.lblAcceptButton.Text = "Label5"
        '
        'lblCurrentlySelected
        '
        Me.lblCurrentlySelected.AutoSize = True
        Me.lblCurrentlySelected.Location = New System.Drawing.Point(169, 163)
        Me.lblCurrentlySelected.Name = "lblCurrentlySelected"
        Me.lblCurrentlySelected.Size = New System.Drawing.Size(39, 13)
        Me.lblCurrentlySelected.TabIndex = 10
        Me.lblCurrentlySelected.Text = "Label6"
        '
        'lblLastClicked
        '
        Me.lblLastClicked.AutoSize = True
        Me.lblLastClicked.Location = New System.Drawing.Point(169, 188)
        Me.lblLastClicked.Name = "lblLastClicked"
        Me.lblLastClicked.Size = New System.Drawing.Size(39, 13)
        Me.lblLastClicked.TabIndex = 11
        Me.lblLastClicked.Text = "Label7"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Button click count:"
        '
        'lblClickCount
        '
        Me.lblClickCount.AutoSize = True
        Me.lblClickCount.Location = New System.Drawing.Point(169, 212)
        Me.lblClickCount.Name = "lblClickCount"
        Me.lblClickCount.Size = New System.Drawing.Size(39, 13)
        Me.lblClickCount.TabIndex = 13
        Me.lblClickCount.Text = "Label6"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnAlpha
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 243)
        Me.Controls.Add(Me.lblClickCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblLastClicked)
        Me.Controls.Add(Me.lblCurrentlySelected)
        Me.Controls.Add(Me.lblAcceptButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAccepButton)
        Me.Controls.Add(Me.chkSelect)
        Me.Controls.Add(Me.btnBeta)
        Me.Controls.Add(Me.btnAlpha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "AcceptButton vs Select"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAlpha As System.Windows.Forms.Button
    Friend WithEvents btnBeta As System.Windows.Forms.Button
    Friend WithEvents chkSelect As System.Windows.Forms.CheckBox
    Friend WithEvents chkAccepButton As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAcceptButton As System.Windows.Forms.Label
    Friend WithEvents lblCurrentlySelected As System.Windows.Forms.Label
    Friend WithEvents lblLastClicked As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblClickCount As System.Windows.Forms.Label

End Class
