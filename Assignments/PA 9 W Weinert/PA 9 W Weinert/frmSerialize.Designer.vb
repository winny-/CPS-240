<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerialize
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
        Me.components = New System.ComponentModel.Container()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.tsslTotalPlays = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslSpacer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAuthor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCloseFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPlayers = New System.Windows.Forms.DataGridView()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.btnRemovePlayer = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.pnlControlGame = New System.Windows.Forms.Panel()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdNewFile = New System.Windows.Forms.SaveFileDialog()
        Me.tmrWinnerFlash = New System.Windows.Forms.Timer(Me.components)
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.ssMain.SuspendLayout()
        Me.msMain.SuspendLayout()
        CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControlGame.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssMain
        '
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslTotalPlays, Me.tsslSpacer, Me.tsslAuthor})
        Me.ssMain.Location = New System.Drawing.Point(0, 273)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(447, 22)
        Me.ssMain.SizingGrip = False
        Me.ssMain.TabIndex = 0
        '
        'tsslTotalPlays
        '
        Me.tsslTotalPlays.Name = "tsslTotalPlays"
        Me.tsslTotalPlays.Size = New System.Drawing.Size(82, 17)
        Me.tsslTotalPlays.Text = "Total plays: {0}"
        '
        'tsslSpacer
        '
        Me.tsslSpacer.Name = "tsslSpacer"
        Me.tsslSpacer.Size = New System.Drawing.Size(251, 17)
        Me.tsslSpacer.Spring = True
        '
        'tsslAuthor
        '
        Me.tsslAuthor.Name = "tsslAuthor"
        Me.tsslAuthor.Size = New System.Drawing.Size(99, 17)
        Me.tsslAuthor.Text = "PA 9 by Winston W"
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(447, 24)
        Me.msMain.TabIndex = 1
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
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miOpenFile, Me.miNewFile, Me.miCloseFile})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'miOpenFile
        '
        Me.miOpenFile.Name = "miOpenFile"
        Me.miOpenFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.miOpenFile.Size = New System.Drawing.Size(159, 22)
        Me.miOpenFile.Text = "&Open File"
        '
        'miNewFile
        '
        Me.miNewFile.Name = "miNewFile"
        Me.miNewFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.miNewFile.Size = New System.Drawing.Size(159, 22)
        Me.miNewFile.Text = "&New File"
        '
        'miCloseFile
        '
        Me.miCloseFile.Name = "miCloseFile"
        Me.miCloseFile.Size = New System.Drawing.Size(159, 22)
        Me.miCloseFile.Text = "&Close File"
        '
        'dgvPlayers
        '
        Me.dgvPlayers.AllowUserToAddRows = False
        Me.dgvPlayers.AllowUserToDeleteRows = False
        Me.dgvPlayers.AllowUserToResizeColumns = False
        Me.dgvPlayers.AllowUserToResizeRows = False
        Me.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlayers.BackgroundColor = System.Drawing.Color.White
        Me.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlayers.Location = New System.Drawing.Point(8, 27)
        Me.dgvPlayers.MultiSelect = False
        Me.dgvPlayers.Name = "dgvPlayers"
        Me.dgvPlayers.ReadOnly = True
        Me.dgvPlayers.RowHeadersVisible = False
        Me.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlayers.ShowEditingIcon = False
        Me.dgvPlayers.Size = New System.Drawing.Size(223, 241)
        Me.dgvPlayers.TabIndex = 2
        '
        'lblWinner
        '
        Me.lblWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(5, 0)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(190, 97)
        Me.lblWinner.TabIndex = 3
        Me.lblWinner.Text = "Winner is" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{0}"
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWinner.Visible = False
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(59, 100)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "&Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(128, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.Location = New System.Drawing.Point(11, 174)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(87, 23)
        Me.btnAddPlayer.TabIndex = 6
        Me.btnAddPlayer.Text = "&Add Player"
        Me.btnAddPlayer.UseVisualStyleBackColor = True
        '
        'btnRemovePlayer
        '
        Me.btnRemovePlayer.Location = New System.Drawing.Point(104, 174)
        Me.btnRemovePlayer.Name = "btnRemovePlayer"
        Me.btnRemovePlayer.Size = New System.Drawing.Size(87, 23)
        Me.btnRemovePlayer.TabIndex = 7
        Me.btnRemovePlayer.Text = "&Remove Player"
        Me.btnRemovePlayer.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(8, 151)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "&Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(79, 148)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(112, 20)
        Me.txtName.TabIndex = 9
        '
        'pnlControlGame
        '
        Me.pnlControlGame.Controls.Add(Me.lblName)
        Me.pnlControlGame.Controls.Add(Me.txtName)
        Me.pnlControlGame.Controls.Add(Me.lblWinner)
        Me.pnlControlGame.Controls.Add(Me.btnPlay)
        Me.pnlControlGame.Controls.Add(Me.btnAddPlayer)
        Me.pnlControlGame.Controls.Add(Me.btnRemovePlayer)
        Me.pnlControlGame.Location = New System.Drawing.Point(3, 3)
        Me.pnlControlGame.Name = "pnlControlGame"
        Me.pnlControlGame.Size = New System.Drawing.Size(200, 206)
        Me.pnlControlGame.TabIndex = 10
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.DefaultExt = "bin"
        Me.ofdOpenFile.Filter = "Bin Files (*.bin)|*.bin"
        Me.ofdOpenFile.Title = "Open roster file"
        '
        'sfdNewFile
        '
        Me.sfdNewFile.DefaultExt = "bin"
        Me.sfdNewFile.Filter = "Bin Files (*.bin)|*.bin"
        Me.sfdNewFile.Title = "Create a new roster"
        '
        'tmrWinnerFlash
        '
        Me.tmrWinnerFlash.Interval = 500
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.btnExit)
        Me.pnlRight.Controls.Add(Me.pnlControlGame)
        Me.pnlRight.Location = New System.Drawing.Point(237, 27)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(206, 241)
        Me.pnlRight.TabIndex = 11
        '
        'frmSerialize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 295)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.dgvPlayers)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.msMain
        Me.MaximizeBox = False
        Me.Name = "frmSerialize"
        Me.Text = "PA 9 Serialize{0}"
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControlGame.ResumeLayout(False)
        Me.pnlControlGame.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ssMain As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslTotalPlays As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslSpacer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslAuthor As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miNewFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCloseFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvPlayers As System.Windows.Forms.DataGridView
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAddPlayer As System.Windows.Forms.Button
    Friend WithEvents btnRemovePlayer As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents pnlControlGame As System.Windows.Forms.Panel
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdNewFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tmrWinnerFlash As System.Windows.Forms.Timer
    Friend WithEvents pnlRight As System.Windows.Forms.Panel

End Class
