<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemoryGame
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslMissesThisGame = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslGames = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslAverageMisses = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnChangeDeck = New System.Windows.Forms.Button()
        Me.mgcMemoryGame = New PA_7_W_Weinert.MemoryGameControl()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.Location = New System.Drawing.Point(349, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(12, 10)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGame.TabIndex = 0
        Me.btnNewGame.Text = "&New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslMissesThisGame, Me.tsslGames, Me.tsslAverageMisses})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 364)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(625, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslMissesThisGame
        '
        Me.tsslMissesThisGame.Name = "tsslMissesThisGame"
        Me.tsslMissesThisGame.Size = New System.Drawing.Size(0, 17)
        '
        'tsslGames
        '
        Me.tsslGames.Name = "tsslGames"
        Me.tsslGames.Size = New System.Drawing.Size(593, 17)
        Me.tsslGames.Spring = True
        '
        'tsslAverageMisses
        '
        Me.tsslAverageMisses.Name = "tsslAverageMisses"
        Me.tsslAverageMisses.Size = New System.Drawing.Size(0, 17)
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(513, 15)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(100, 13)
        Me.lblAuthor.TabIndex = 4
        Me.lblAuthor.Text = "PA 7 by Winston W"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAbout)
        Me.Panel1.Controls.Add(Me.btnChangeDeck)
        Me.Panel1.Controls.Add(Me.btnNewGame)
        Me.Panel1.Controls.Add(Me.lblAuthor)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 41)
        Me.Panel1.TabIndex = 1
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAbout.Location = New System.Drawing.Point(268, 10)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "&About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnChangeDeck
        '
        Me.btnChangeDeck.Location = New System.Drawing.Point(93, 10)
        Me.btnChangeDeck.Name = "btnChangeDeck"
        Me.btnChangeDeck.Size = New System.Drawing.Size(88, 23)
        Me.btnChangeDeck.TabIndex = 1
        Me.btnChangeDeck.Text = "&Change Deck"
        Me.btnChangeDeck.UseVisualStyleBackColor = True
        '
        'mgcMemoryGame
        '
        Me.mgcMemoryGame.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mgcMemoryGame.Location = New System.Drawing.Point(0, 0)
        Me.mgcMemoryGame.Name = "mgcMemoryGame"
        Me.mgcMemoryGame.Size = New System.Drawing.Size(625, 317)
        Me.mgcMemoryGame.TabIndex = 0
        '
        'frmMemoryGame
        '
        Me.AcceptButton = Me.btnNewGame
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 386)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mgcMemoryGame)
        Me.MinimumSize = New System.Drawing.Size(633, 413)
        Me.Name = "frmMemoryGame"
        Me.Text = "Memory Game"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mgcMemoryGame As PA_7_W_Weinert.MemoryGameControl
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslMissesThisGame As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslGames As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslAverageMisses As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnChangeDeck As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button

End Class
