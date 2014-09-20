<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoolean
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
        Me.msMainMenu = New System.Windows.Forms.MenuStrip()
        Me.miFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.miChangeForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDefaultColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSelectFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.gbAnswer = New System.Windows.Forms.GroupBox()
        Me.rdHidden = New System.Windows.Forms.RadioButton()
        Me.rdFalse = New System.Windows.Forms.RadioButton()
        Me.rdTrue = New System.Windows.Forms.RadioButton()
        Me.chkShowCount = New System.Windows.Forms.CheckBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAssignmentName = New System.Windows.Forms.Label()
        Me.lblCorrectCount = New System.Windows.Forms.Label()
        Me.lblWrongCount = New System.Windows.Forms.Label()
        Me.cdFormColor = New System.Windows.Forms.ColorDialog()
        Me.ofdWinnyChooser = New System.Windows.Forms.OpenFileDialog()
        Me.picActualAnswer = New System.Windows.Forms.PictureBox()
        Me.gbQuestion = New System.Windows.Forms.GroupBox()
        Me.msMainMenu.SuspendLayout()
        Me.gbAnswer.SuspendLayout()
        CType(Me.picActualAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMainMenu
        '
        Me.msMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.miTools})
        Me.msMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMainMenu.Name = "msMainMenu"
        Me.msMainMenu.Size = New System.Drawing.Size(319, 24)
        Me.msMainMenu.TabIndex = 0
        '
        'miFile
        '
        Me.miFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miExit})
        Me.miFile.Name = "miFile"
        Me.miFile.Size = New System.Drawing.Size(35, 20)
        Me.miFile.Text = "F&ile"
        '
        'miExit
        '
        Me.miExit.Name = "miExit"
        Me.miExit.Size = New System.Drawing.Size(152, 22)
        Me.miExit.Text = "E&xit"
        '
        'miTools
        '
        Me.miTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miChangeForm, Me.miDefaultColor, Me.miSelectFile})
        Me.miTools.Name = "miTools"
        Me.miTools.Size = New System.Drawing.Size(44, 20)
        Me.miTools.Text = "T&ools"
        '
        'miChangeForm
        '
        Me.miChangeForm.Name = "miChangeForm"
        Me.miChangeForm.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.miChangeForm.Size = New System.Drawing.Size(163, 22)
        Me.miChangeForm.Text = "&Change Form"
        '
        'miDefaultColor
        '
        Me.miDefaultColor.Name = "miDefaultColor"
        Me.miDefaultColor.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.miDefaultColor.Size = New System.Drawing.Size(163, 22)
        Me.miDefaultColor.Text = "&Default Color"
        '
        'miSelectFile
        '
        Me.miSelectFile.Name = "miSelectFile"
        Me.miSelectFile.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.miSelectFile.Size = New System.Drawing.Size(163, 22)
        Me.miSelectFile.Text = "&Select File"
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.SystemColors.Control
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(6, 16)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(190, 52)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbAnswer
        '
        Me.gbAnswer.Controls.Add(Me.rdHidden)
        Me.gbAnswer.Controls.Add(Me.rdFalse)
        Me.gbAnswer.Controls.Add(Me.rdTrue)
        Me.gbAnswer.Enabled = False
        Me.gbAnswer.Location = New System.Drawing.Point(111, 124)
        Me.gbAnswer.Name = "gbAnswer"
        Me.gbAnswer.Size = New System.Drawing.Size(79, 70)
        Me.gbAnswer.TabIndex = 2
        Me.gbAnswer.TabStop = False
        Me.gbAnswer.Text = "Answer"
        '
        'rdHidden
        '
        Me.rdHidden.AutoSize = True
        Me.rdHidden.Location = New System.Drawing.Point(6, 65)
        Me.rdHidden.Name = "rdHidden"
        Me.rdHidden.Size = New System.Drawing.Size(59, 17)
        Me.rdHidden.TabIndex = 2
        Me.rdHidden.Text = "Hidden"
        Me.rdHidden.UseVisualStyleBackColor = True
        Me.rdHidden.Visible = False
        '
        'rdFalse
        '
        Me.rdFalse.AutoSize = True
        Me.rdFalse.Location = New System.Drawing.Point(6, 42)
        Me.rdFalse.Name = "rdFalse"
        Me.rdFalse.Size = New System.Drawing.Size(50, 17)
        Me.rdFalse.TabIndex = 1
        Me.rdFalse.TabStop = True
        Me.rdFalse.Text = "&False"
        Me.rdFalse.UseVisualStyleBackColor = True
        '
        'rdTrue
        '
        Me.rdTrue.AutoSize = True
        Me.rdTrue.Location = New System.Drawing.Point(6, 19)
        Me.rdTrue.Name = "rdTrue"
        Me.rdTrue.Size = New System.Drawing.Size(47, 17)
        Me.rdTrue.TabIndex = 0
        Me.rdTrue.TabStop = True
        Me.rdTrue.Text = "&True"
        Me.rdTrue.UseVisualStyleBackColor = True
        '
        'chkShowCount
        '
        Me.chkShowCount.AutoSize = True
        Me.chkShowCount.Location = New System.Drawing.Point(231, 41)
        Me.chkShowCount.Name = "chkShowCount"
        Me.chkShowCount.Size = New System.Drawing.Size(84, 17)
        Me.chkShowCount.TabIndex = 3
        Me.chkShowCount.Text = "&Show Count"
        Me.chkShowCount.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(221, 131)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(221, 160)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAssignmentName
        '
        Me.lblAssignmentName.AutoSize = True
        Me.lblAssignmentName.Location = New System.Drawing.Point(205, 194)
        Me.lblAssignmentName.Name = "lblAssignmentName"
        Me.lblAssignmentName.Size = New System.Drawing.Size(100, 13)
        Me.lblAssignmentName.TabIndex = 6
        Me.lblAssignmentName.Text = "PA 3 by Winston W"
        '
        'lblCorrectCount
        '
        Me.lblCorrectCount.AutoSize = True
        Me.lblCorrectCount.Location = New System.Drawing.Point(250, 70)
        Me.lblCorrectCount.Name = "lblCorrectCount"
        Me.lblCorrectCount.Size = New System.Drawing.Size(49, 13)
        Me.lblCorrectCount.TabIndex = 8
        Me.lblCorrectCount.Text = "0 correct"
        Me.lblCorrectCount.Visible = False
        '
        'lblWrongCount
        '
        Me.lblWrongCount.AutoSize = True
        Me.lblWrongCount.Location = New System.Drawing.Point(250, 89)
        Me.lblWrongCount.Name = "lblWrongCount"
        Me.lblWrongCount.Size = New System.Drawing.Size(45, 13)
        Me.lblWrongCount.TabIndex = 9
        Me.lblWrongCount.Text = "0 wrong"
        Me.lblWrongCount.Visible = False
        '
        'ofdWinnyChooser
        '
        Me.ofdWinnyChooser.FileName = "OpenFileDialog1"
        '
        'picActualAnswer
        '
        Me.picActualAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picActualAnswer.Location = New System.Drawing.Point(15, 124)
        Me.picActualAnswer.Name = "picActualAnswer"
        Me.picActualAnswer.Size = New System.Drawing.Size(77, 76)
        Me.picActualAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picActualAnswer.TabIndex = 7
        Me.picActualAnswer.TabStop = False
        '
        'gbQuestion
        '
        Me.gbQuestion.Controls.Add(Me.lblQuestion)
        Me.gbQuestion.Location = New System.Drawing.Point(14, 33)
        Me.gbQuestion.Name = "gbQuestion"
        Me.gbQuestion.Size = New System.Drawing.Size(202, 79)
        Me.gbQuestion.TabIndex = 1
        Me.gbQuestion.TabStop = False
        Me.gbQuestion.Text = "Question"
        '
        'frmBoolean
        '
        Me.AcceptButton = Me.btnNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 216)
        Me.Controls.Add(Me.gbQuestion)
        Me.Controls.Add(Me.lblWrongCount)
        Me.Controls.Add(Me.lblCorrectCount)
        Me.Controls.Add(Me.picActualAnswer)
        Me.Controls.Add(Me.lblAssignmentName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.chkShowCount)
        Me.Controls.Add(Me.gbAnswer)
        Me.Controls.Add(Me.msMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.msMainMenu
        Me.MaximizeBox = False
        Me.Name = "frmBoolean"
        Me.Text = "Boolean"
        Me.msMainMenu.ResumeLayout(False)
        Me.msMainMenu.PerformLayout()
        Me.gbAnswer.ResumeLayout(False)
        Me.gbAnswer.PerformLayout()
        CType(Me.picActualAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbQuestion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents miFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miChangeForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miDefaultColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miSelectFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents gbAnswer As System.Windows.Forms.GroupBox
    Friend WithEvents rdHidden As System.Windows.Forms.RadioButton
    Friend WithEvents rdFalse As System.Windows.Forms.RadioButton
    Friend WithEvents rdTrue As System.Windows.Forms.RadioButton
    Friend WithEvents chkShowCount As System.Windows.Forms.CheckBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAssignmentName As System.Windows.Forms.Label
    Friend WithEvents picActualAnswer As System.Windows.Forms.PictureBox
    Friend WithEvents lblCorrectCount As System.Windows.Forms.Label
    Friend WithEvents lblWrongCount As System.Windows.Forms.Label
    Friend WithEvents cdFormColor As System.Windows.Forms.ColorDialog
    Friend WithEvents ofdWinnyChooser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbQuestion As System.Windows.Forms.GroupBox

End Class
