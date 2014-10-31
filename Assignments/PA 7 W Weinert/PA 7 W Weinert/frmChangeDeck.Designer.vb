<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeDeck
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
        Me.cbDeckChoices = New System.Windows.Forms.ComboBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblChooseADeck = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.mgcDeckViewer = New PA_7_W_Weinert.MemoryGameControl()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbDeckChoices
        '
        Me.cbDeckChoices.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbDeckChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDeckChoices.FormattingEnabled = True
        Me.cbDeckChoices.Location = New System.Drawing.Point(88, 4)
        Me.cbDeckChoices.Name = "cbDeckChoices"
        Me.cbDeckChoices.Size = New System.Drawing.Size(156, 21)
        Me.cbDeckChoices.TabIndex = 1
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(3, 3)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 0
        Me.btnChange.Text = "&Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(549, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnChange)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(627, 30)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(627, 28)
        Me.Panel1.TabIndex = 0
        '
        'lblChooseADeck
        '
        Me.lblChooseADeck.AutoSize = True
        Me.lblChooseADeck.Location = New System.Drawing.Point(3, 7)
        Me.lblChooseADeck.Name = "lblChooseADeck"
        Me.lblChooseADeck.Size = New System.Drawing.Size(79, 13)
        Me.lblChooseADeck.TabIndex = 0
        Me.lblChooseADeck.Text = "C&hoose a deck"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblChooseADeck)
        Me.Panel3.Controls.Add(Me.cbDeckChoices)
        Me.Panel3.Location = New System.Drawing.Point(190, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(247, 28)
        Me.Panel3.TabIndex = 1
        '
        'mgcDeckViewer
        '
        Me.mgcDeckViewer.AutoScroll = True
        Me.mgcDeckViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mgcDeckViewer.Location = New System.Drawing.Point(0, 28)
        Me.mgcDeckViewer.Name = "mgcDeckViewer"
        Me.mgcDeckViewer.Size = New System.Drawing.Size(627, 417)
        Me.mgcDeckViewer.TabIndex = 2
        '
        'frmChangeDeck
        '
        Me.AcceptButton = Me.btnChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(627, 475)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.mgcDeckViewer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmChangeDeck"
        Me.Text = "Change Deck"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbDeckChoices As System.Windows.Forms.ComboBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mgcDeckViewer As PA_7_W_Weinert.MemoryGameControl
    Friend WithEvents lblChooseADeck As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
