<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankAccounts
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
        Me.miNewCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTotalBankBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbMakeATransaction = New System.Windows.Forms.GroupBox()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.bntDeposit = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblCustomersTitle = New System.Windows.Forms.Label()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAccountInfoTitle = New System.Windows.Forms.Label()
        Me.lblAccountInfo = New System.Windows.Forms.Label()
        Me.pbFlowIndicator = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gbMakeATransaction.SuspendLayout()
        CType(Me.pbFlowIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(407, 24)
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
        Me.miExit.Size = New System.Drawing.Size(152, 22)
        Me.miExit.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miNewCustomer, Me.miTotalBankBalance})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'miNewCustomer
        '
        Me.miNewCustomer.Name = "miNewCustomer"
        Me.miNewCustomer.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.miNewCustomer.Size = New System.Drawing.Size(189, 22)
        Me.miNewCustomer.Text = "&New customer"
        '
        'miTotalBankBalance
        '
        Me.miTotalBankBalance.Name = "miTotalBankBalance"
        Me.miTotalBankBalance.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.miTotalBankBalance.Size = New System.Drawing.Size(189, 22)
        Me.miTotalBankBalance.Text = "&Total bank balance"
        '
        'gbMakeATransaction
        '
        Me.gbMakeATransaction.Controls.Add(Me.btnWithdraw)
        Me.gbMakeATransaction.Controls.Add(Me.bntDeposit)
        Me.gbMakeATransaction.Controls.Add(Me.txtAmount)
        Me.gbMakeATransaction.Controls.Add(Me.lblAmount)
        Me.gbMakeATransaction.Enabled = False
        Me.gbMakeATransaction.Location = New System.Drawing.Point(195, 140)
        Me.gbMakeATransaction.Name = "gbMakeATransaction"
        Me.gbMakeATransaction.Size = New System.Drawing.Size(194, 100)
        Me.gbMakeATransaction.TabIndex = 1
        Me.gbMakeATransaction.TabStop = False
        Me.gbMakeATransaction.Text = "Make a transaction"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(113, 50)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(75, 23)
        Me.btnWithdraw.TabIndex = 3
        Me.btnWithdraw.Text = "&Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'bntDeposit
        '
        Me.bntDeposit.Location = New System.Drawing.Point(10, 50)
        Me.bntDeposit.Name = "bntDeposit"
        Me.bntDeposit.Size = New System.Drawing.Size(75, 23)
        Me.bntDeposit.TabIndex = 2
        Me.bntDeposit.Text = "&Deposit"
        Me.bntDeposit.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(87, 17)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 1
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(7, 20)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "&Amount"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(89, 262)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(100, 13)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "PA 5 by Winston W"
        '
        'lblCustomersTitle
        '
        Me.lblCustomersTitle.AutoSize = True
        Me.lblCustomersTitle.Location = New System.Drawing.Point(45, 34)
        Me.lblCustomersTitle.Name = "lblCustomersTitle"
        Me.lblCustomersTitle.Size = New System.Drawing.Size(56, 13)
        Me.lblCustomersTitle.TabIndex = 3
        Me.lblCustomersTitle.Text = "Customers"
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.Location = New System.Drawing.Point(16, 58)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(120, 173)
        Me.lstCustomers.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(195, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAccountInfoTitle
        '
        Me.lblAccountInfoTitle.AutoSize = True
        Me.lblAccountInfoTitle.Location = New System.Drawing.Point(258, 34)
        Me.lblAccountInfoTitle.Name = "lblAccountInfoTitle"
        Me.lblAccountInfoTitle.Size = New System.Drawing.Size(68, 13)
        Me.lblAccountInfoTitle.TabIndex = 6
        Me.lblAccountInfoTitle.Text = "Account Info"
        '
        'lblAccountInfo
        '
        Me.lblAccountInfo.BackColor = System.Drawing.Color.White
        Me.lblAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccountInfo.Location = New System.Drawing.Point(195, 58)
        Me.lblAccountInfo.Name = "lblAccountInfo"
        Me.lblAccountInfo.Size = New System.Drawing.Size(194, 72)
        Me.lblAccountInfo.TabIndex = 7
        '
        'pbFlowIndicator
        '
        Me.pbFlowIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFlowIndicator.Image = Global.PA_5_W_Weinert.My.Resources.Resources.triangle
        Me.pbFlowIndicator.InitialImage = Nothing
        Me.pbFlowIndicator.Location = New System.Drawing.Point(153, 123)
        Me.pbFlowIndicator.Name = "pbFlowIndicator"
        Me.pbFlowIndicator.Size = New System.Drawing.Size(25, 25)
        Me.pbFlowIndicator.TabIndex = 8
        Me.pbFlowIndicator.TabStop = False
        '
        'frmBankAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 293)
        Me.Controls.Add(Me.pbFlowIndicator)
        Me.Controls.Add(Me.lblAccountInfo)
        Me.Controls.Add(Me.lblAccountInfoTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.lblCustomersTitle)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.gbMakeATransaction)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmBankAccounts"
        Me.Text = "Bank Accounts"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbMakeATransaction.ResumeLayout(False)
        Me.gbMakeATransaction.PerformLayout()
        CType(Me.pbFlowIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miNewCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miTotalBankBalance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbMakeATransaction As System.Windows.Forms.GroupBox
    Friend WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents bntDeposit As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblCustomersTitle As System.Windows.Forms.Label
    Friend WithEvents lstCustomers As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAccountInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblAccountInfo As System.Windows.Forms.Label
    Friend WithEvents pbFlowIndicator As System.Windows.Forms.PictureBox

End Class
