<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPA8FileHandling
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
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCloseFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miChangeRandomGiftAmount = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lstPeople = New System.Windows.Forms.ListBox()
        Me.btnGiveMoneyToRandomPerson = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAddPerson = New System.Windows.Forms.Button()
        Me.btnRemovePerson = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbMutateData = New System.Windows.Forms.GroupBox()
        Me.sfdChooseNewFilename = New System.Windows.Forms.SaveFileDialog()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.gbMutateData.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(378, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'miExit
        '
        Me.miExit.Name = "miExit"
        Me.miExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.miExit.Size = New System.Drawing.Size(132, 22)
        Me.miExit.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miNewFile, Me.miOpenFile, Me.miCloseFile, Me.miSaveFile, Me.miChangeRandomGiftAmount})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'miNewFile
        '
        Me.miNewFile.Name = "miNewFile"
        Me.miNewFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.miNewFile.Size = New System.Drawing.Size(213, 22)
        Me.miNewFile.Text = "&New File"
        '
        'miOpenFile
        '
        Me.miOpenFile.Name = "miOpenFile"
        Me.miOpenFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.miOpenFile.Size = New System.Drawing.Size(213, 22)
        Me.miOpenFile.Text = "&Open File"
        '
        'miCloseFile
        '
        Me.miCloseFile.Name = "miCloseFile"
        Me.miCloseFile.Size = New System.Drawing.Size(213, 22)
        Me.miCloseFile.Text = "&Close File"
        '
        'miSaveFile
        '
        Me.miSaveFile.Name = "miSaveFile"
        Me.miSaveFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.miSaveFile.Size = New System.Drawing.Size(213, 22)
        Me.miSaveFile.Text = "&Save File"
        '
        'miChangeRandomGiftAmount
        '
        Me.miChangeRandomGiftAmount.Name = "miChangeRandomGiftAmount"
        Me.miChangeRandomGiftAmount.Size = New System.Drawing.Size(213, 22)
        Me.miChangeRandomGiftAmount.Text = "&Change Random Gift Amount"
        '
        'lblFileName
        '
        Me.lblFileName.BackColor = System.Drawing.Color.White
        Me.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFileName.Location = New System.Drawing.Point(13, 28)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(183, 23)
        Me.lblFileName.TabIndex = 1
        Me.lblFileName.Text = " File: {0}{1}"
        Me.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstPeople
        '
        Me.lstPeople.Enabled = False
        Me.lstPeople.FormattingEnabled = True
        Me.lstPeople.Location = New System.Drawing.Point(12, 56)
        Me.lstPeople.Name = "lstPeople"
        Me.lstPeople.Size = New System.Drawing.Size(184, 186)
        Me.lstPeople.TabIndex = 2
        '
        'btnGiveMoneyToRandomPerson
        '
        Me.btnGiveMoneyToRandomPerson.Location = New System.Drawing.Point(6, 100)
        Me.btnGiveMoneyToRandomPerson.Name = "btnGiveMoneyToRandomPerson"
        Me.btnGiveMoneyToRandomPerson.Size = New System.Drawing.Size(150, 35)
        Me.btnGiveMoneyToRandomPerson.TabIndex = 3
        Me.btnGiveMoneyToRandomPerson.Text = "&Give {0:C} to random person"
        Me.btnGiveMoneyToRandomPerson.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(50, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 5
        '
        'btnAddPerson
        '
        Me.btnAddPerson.Location = New System.Drawing.Point(50, 42)
        Me.btnAddPerson.Name = "btnAddPerson"
        Me.btnAddPerson.Size = New System.Drawing.Size(103, 23)
        Me.btnAddPerson.TabIndex = 6
        Me.btnAddPerson.Text = "&Add Person"
        Me.btnAddPerson.UseVisualStyleBackColor = True
        '
        'btnRemovePerson
        '
        Me.btnRemovePerson.Location = New System.Drawing.Point(50, 71)
        Me.btnRemovePerson.Name = "btnRemovePerson"
        Me.btnRemovePerson.Size = New System.Drawing.Size(103, 23)
        Me.btnRemovePerson.TabIndex = 7
        Me.btnRemovePerson.Text = "&Remove Person"
        Me.btnRemovePerson.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(211, 192)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(293, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PA 8 by Winston W"
        '
        'gbMutateData
        '
        Me.gbMutateData.Controls.Add(Me.Label2)
        Me.gbMutateData.Controls.Add(Me.txtName)
        Me.gbMutateData.Controls.Add(Me.btnAddPerson)
        Me.gbMutateData.Controls.Add(Me.btnRemovePerson)
        Me.gbMutateData.Controls.Add(Me.btnGiveMoneyToRandomPerson)
        Me.gbMutateData.Enabled = False
        Me.gbMutateData.Location = New System.Drawing.Point(202, 27)
        Me.gbMutateData.Name = "gbMutateData"
        Me.gbMutateData.Size = New System.Drawing.Size(166, 149)
        Me.gbMutateData.TabIndex = 11
        Me.gbMutateData.TabStop = False
        '
        'sfdChooseNewFilename
        '
        Me.sfdChooseNewFilename.DefaultExt = "txt"
        Me.sfdChooseNewFilename.Title = "Choose new filename"
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.DefaultExt = "txt"
        Me.ofdOpenFile.Title = "Open file"
        '
        'frmPA8FileHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 251)
        Me.Controls.Add(Me.gbMutateData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstPeople)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmPA8FileHandling"
        Me.Text = "PA 8 File Handling"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbMutateData.ResumeLayout(False)
        Me.gbMutateData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miNewFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCloseFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents lstPeople As System.Windows.Forms.ListBox
    Friend WithEvents btnGiveMoneyToRandomPerson As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddPerson As System.Windows.Forms.Button
    Friend WithEvents btnRemovePerson As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbMutateData As System.Windows.Forms.GroupBox
    Friend WithEvents sfdChooseNewFilename As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents miSaveFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miChangeRandomGiftAmount As System.Windows.Forms.ToolStripMenuItem

End Class
