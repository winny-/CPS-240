﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblCustomersTitle = New System.Windows.Forms.Label()
        Me.lstCustomers = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAccountInfoTitle = New System.Windows.Forms.Label()
        Me.lblAccountInfo = New System.Windows.Forms.Label()
        Me.pbFlowIndicator = New System.Windows.Forms.PictureBox()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.chkShowTransactionsForAllAccounts = New System.Windows.Forms.CheckBox()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.gbMakeATransaction.SuspendLayout()
        CType(Me.pbFlowIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(410, 24)
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
        Me.miExit.Size = New System.Drawing.Size(92, 22)
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
        Me.gbMakeATransaction.Controls.Add(Me.btnDeposit)
        Me.gbMakeATransaction.Controls.Add(Me.txtAmount)
        Me.gbMakeATransaction.Controls.Add(Me.lblAmount)
        Me.gbMakeATransaction.Enabled = False
        Me.gbMakeATransaction.Location = New System.Drawing.Point(195, 131)
        Me.gbMakeATransaction.Name = "gbMakeATransaction"
        Me.gbMakeATransaction.Size = New System.Drawing.Size(194, 100)
        Me.gbMakeATransaction.TabIndex = 5
        Me.gbMakeATransaction.TabStop = False
        Me.gbMakeATransaction.Text = "Make a transaction"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(112, 60)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(75, 23)
        Me.btnWithdraw.TabIndex = 3
        Me.btnWithdraw.Text = "&Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(10, 60)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(75, 23)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "&Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(87, 26)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 1
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(23, 29)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "&Amount"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(99, 496)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(100, 13)
        Me.lblAuthor.TabIndex = 6
        Me.lblAuthor.Text = "PA 5 by Winston W"
        '
        'lblCustomersTitle
        '
        Me.lblCustomersTitle.AutoSize = True
        Me.lblCustomersTitle.Location = New System.Drawing.Point(48, 34)
        Me.lblCustomersTitle.Name = "lblCustomersTitle"
        Me.lblCustomersTitle.Size = New System.Drawing.Size(56, 13)
        Me.lblCustomersTitle.TabIndex = 1
        Me.lblCustomersTitle.Text = "&Customers"
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.Location = New System.Drawing.Point(16, 58)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(120, 173)
        Me.lstCustomers.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(205, 491)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAccountInfoTitle
        '
        Me.lblAccountInfoTitle.AutoSize = True
        Me.lblAccountInfoTitle.Location = New System.Drawing.Point(258, 34)
        Me.lblAccountInfoTitle.Name = "lblAccountInfoTitle"
        Me.lblAccountInfoTitle.Size = New System.Drawing.Size(68, 13)
        Me.lblAccountInfoTitle.TabIndex = 3
        Me.lblAccountInfoTitle.Text = "Account Info"
        '
        'lblAccountInfo
        '
        Me.lblAccountInfo.BackColor = System.Drawing.Color.White
        Me.lblAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccountInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountInfo.Location = New System.Drawing.Point(195, 58)
        Me.lblAccountInfo.Name = "lblAccountInfo"
        Me.lblAccountInfo.Size = New System.Drawing.Size(194, 63)
        Me.lblAccountInfo.TabIndex = 4
        Me.lblAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Location = New System.Drawing.Point(171, 243)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(68, 13)
        Me.lblTransactions.TabIndex = 9
        Me.lblTransactions.Text = "&Transactions"
        '
        'chkShowTransactionsForAllAccounts
        '
        Me.chkShowTransactionsForAllAccounts.AutoSize = True
        Me.chkShowTransactionsForAllAccounts.Location = New System.Drawing.Point(102, 459)
        Me.chkShowTransactionsForAllAccounts.Name = "chkShowTransactionsForAllAccounts"
        Me.chkShowTransactionsForAllAccounts.Size = New System.Drawing.Size(188, 17)
        Me.chkShowTransactionsForAllAccounts.TabIndex = 11
        Me.chkShowTransactionsForAllAccounts.Text = "&Show transactions for all accounts"
        Me.chkShowTransactionsForAllAccounts.UseVisualStyleBackColor = True
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        Me.dgvTransactions.AllowUserToResizeColumns = False
        Me.dgvTransactions.AllowUserToResizeRows = False
        Me.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactions.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Location = New System.Drawing.Point(16, 270)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.Size = New System.Drawing.Size(373, 173)
        Me.dgvTransactions.TabIndex = 13
        '
        'frmBankAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 529)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.chkShowTransactionsForAllAccounts)
        Me.Controls.Add(Me.lblTransactions)
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
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblCustomersTitle As System.Windows.Forms.Label
    Friend WithEvents lstCustomers As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAccountInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblAccountInfo As System.Windows.Forms.Label
    Friend WithEvents pbFlowIndicator As System.Windows.Forms.PictureBox
    Friend WithEvents lblTransactions As System.Windows.Forms.Label
    Friend WithEvents chkShowTransactionsForAllAccounts As System.Windows.Forms.CheckBox
    Friend WithEvents dgvTransactions As System.Windows.Forms.DataGridView

End Class
