<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinnysVideoRental
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
        Me.miAddVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.miRemoveVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTotalFees = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblRented = New System.Windows.Forms.Label()
        Me.lstAvailable = New System.Windows.Forms.ListBox()
        Me.lstRented = New System.Windows.Forms.ListBox()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslLastAction = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslSpacer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAuthor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(361, 24)
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
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAddVideo, Me.miRemoveVideo, Me.miTotalFees})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'miAddVideo
        '
        Me.miAddVideo.Name = "miAddVideo"
        Me.miAddVideo.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.miAddVideo.Size = New System.Drawing.Size(167, 22)
        Me.miAddVideo.Text = "&Add Video"
        '
        'miRemoveVideo
        '
        Me.miRemoveVideo.Name = "miRemoveVideo"
        Me.miRemoveVideo.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.miRemoveVideo.Size = New System.Drawing.Size(167, 22)
        Me.miRemoveVideo.Text = "&Remove Video"
        '
        'miTotalFees
        '
        Me.miTotalFees.Name = "miTotalFees"
        Me.miTotalFees.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.miTotalFees.Size = New System.Drawing.Size(167, 22)
        Me.miTotalFees.Text = "Total &Fees"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(67, 39)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(50, 13)
        Me.lblAvailable.TabIndex = 1
        Me.lblAvailable.Text = "&Available"
        '
        'lblRented
        '
        Me.lblRented.AutoSize = True
        Me.lblRented.Location = New System.Drawing.Point(248, 39)
        Me.lblRented.Name = "lblRented"
        Me.lblRented.Size = New System.Drawing.Size(42, 13)
        Me.lblRented.TabIndex = 3
        Me.lblRented.Text = "&Rented"
        '
        'lstAvailable
        '
        Me.lstAvailable.FormattingEnabled = True
        Me.lstAvailable.Location = New System.Drawing.Point(12, 68)
        Me.lstAvailable.Name = "lstAvailable"
        Me.lstAvailable.Size = New System.Drawing.Size(160, 95)
        Me.lstAvailable.TabIndex = 2
        '
        'lstRented
        '
        Me.lstRented.FormattingEnabled = True
        Me.lstRented.Location = New System.Drawing.Point(189, 68)
        Me.lstRented.Name = "lstRented"
        Me.lstRented.Size = New System.Drawing.Size(160, 95)
        Me.lstRented.TabIndex = 4
        '
        'btnRent
        '
        Me.btnRent.Location = New System.Drawing.Point(55, 178)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(75, 23)
        Me.btnRent.TabIndex = 5
        Me.btnRent.Text = "R&ent"
        Me.btnRent.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(232, 178)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Ret&urn"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslLastAction, Me.tsslSpacer, Me.tsslAuthor})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 217)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(361, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslLastAction
        '
        Me.tsslLastAction.Name = "tsslLastAction"
        Me.tsslLastAction.Size = New System.Drawing.Size(0, 17)
        '
        'tsslSpacer
        '
        Me.tsslSpacer.Name = "tsslSpacer"
        Me.tsslSpacer.Size = New System.Drawing.Size(247, 17)
        Me.tsslSpacer.Spring = True
        '
        'tsslAuthor
        '
        Me.tsslAuthor.Name = "tsslAuthor"
        Me.tsslAuthor.Size = New System.Drawing.Size(99, 17)
        Me.tsslAuthor.Text = "PA 6 by Winston W"
        '
        'frmWinnysVideoRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 239)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.lstRented)
        Me.Controls.Add(Me.lstAvailable)
        Me.Controls.Add(Me.lblRented)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmWinnysVideoRental"
        Me.Text = "Winny's Video Rental"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miAddVideo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miRemoveVideo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miTotalFees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAvailable As System.Windows.Forms.Label
    Friend WithEvents lblRented As System.Windows.Forms.Label
    Friend WithEvents lstAvailable As System.Windows.Forms.ListBox
    Friend WithEvents lstRented As System.Windows.Forms.ListBox
    Friend WithEvents btnRent As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslLastAction As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslSpacer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslAuthor As System.Windows.Forms.ToolStripStatusLabel

End Class
