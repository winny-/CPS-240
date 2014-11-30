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
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miOpenDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCloseDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miNewCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTotalBankBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.miChangeBankName = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.chkShowTransactionsForAllAccounts = New System.Windows.Forms.CheckBox()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblUUID = New System.Windows.Forms.Label()
        Me.txtUUID = New System.Windows.Forms.TextBox()
        Me.lblCreated = New System.Windows.Forms.Label()
        Me.txtCreated = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.pbFlowIndicator = New System.Windows.Forms.PictureBox()
        Me.ofdOpenDatabase = New System.Windows.Forms.OpenFileDialog()
        Me.sfdNewDatabase = New System.Windows.Forms.SaveFileDialog()
        Me.msMain.SuspendLayout()
        Me.gbMakeATransaction.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlowIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(933, 24)
        Me.msMain.TabIndex = 0
        Me.msMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miOpenDatabase, Me.NewDatabaseToolStripMenuItem, Me.miCloseDatabase, Me.ToolStripSeparator1, Me.miExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'miOpenDatabase
        '
        Me.miOpenDatabase.Name = "miOpenDatabase"
        Me.miOpenDatabase.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.miOpenDatabase.Size = New System.Drawing.Size(193, 22)
        Me.miOpenDatabase.Text = "&Open Database"
        '
        'NewDatabaseToolStripMenuItem
        '
        Me.NewDatabaseToolStripMenuItem.Name = "NewDatabaseToolStripMenuItem"
        Me.NewDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewDatabaseToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.NewDatabaseToolStripMenuItem.Text = "&New Database"
        '
        'miCloseDatabase
        '
        Me.miCloseDatabase.Name = "miCloseDatabase"
        Me.miCloseDatabase.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.miCloseDatabase.Size = New System.Drawing.Size(193, 22)
        Me.miCloseDatabase.Text = "&Close Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'miExit
        '
        Me.miExit.Name = "miExit"
        Me.miExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.miExit.Size = New System.Drawing.Size(193, 22)
        Me.miExit.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miNewCustomer, Me.miTotalBankBalance, Me.miChangeBankName})
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
        'miChangeBankName
        '
        Me.miChangeBankName.Name = "miChangeBankName"
        Me.miChangeBankName.Size = New System.Drawing.Size(189, 22)
        Me.miChangeBankName.Text = "&Change bank name"
        '
        'gbMakeATransaction
        '
        Me.gbMakeATransaction.Controls.Add(Me.btnWithdraw)
        Me.gbMakeATransaction.Controls.Add(Me.btnDeposit)
        Me.gbMakeATransaction.Controls.Add(Me.txtAmount)
        Me.gbMakeATransaction.Controls.Add(Me.lblAmount)
        Me.gbMakeATransaction.Enabled = False
        Me.gbMakeATransaction.Location = New System.Drawing.Point(195, 287)
        Me.gbMakeATransaction.Name = "gbMakeATransaction"
        Me.gbMakeATransaction.Size = New System.Drawing.Size(194, 100)
        Me.gbMakeATransaction.TabIndex = 14
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
        Me.lblAuthor.Location = New System.Drawing.Point(690, 357)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(106, 13)
        Me.lblAuthor.TabIndex = 18
        Me.lblAuthor.Text = "PA 10 by Winston W"
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
        Me.lstCustomers.Size = New System.Drawing.Size(120, 329)
        Me.lstCustomers.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(820, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
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
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Location = New System.Drawing.Point(599, 34)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(68, 13)
        Me.lblTransactions.TabIndex = 15
        Me.lblTransactions.Text = "&Transactions"
        '
        'chkShowTransactionsForAllAccounts
        '
        Me.chkShowTransactionsForAllAccounts.AutoSize = True
        Me.chkShowTransactionsForAllAccounts.Location = New System.Drawing.Point(448, 356)
        Me.chkShowTransactionsForAllAccounts.Name = "chkShowTransactionsForAllAccounts"
        Me.chkShowTransactionsForAllAccounts.Size = New System.Drawing.Size(188, 17)
        Me.chkShowTransactionsForAllAccounts.TabIndex = 17
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
        Me.dgvTransactions.Location = New System.Drawing.Point(423, 58)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.Size = New System.Drawing.Size(486, 271)
        Me.dgvTransactions.TabIndex = 16
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(192, 109)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "&First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(192, 157)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "&Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(261, 106)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(128, 20)
        Me.txtFirstName.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(261, 154)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(128, 20)
        Me.txtLastName.TabIndex = 9
        '
        'lblUUID
        '
        Me.lblUUID.AutoSize = True
        Me.lblUUID.Location = New System.Drawing.Point(192, 61)
        Me.lblUUID.Name = "lblUUID"
        Me.lblUUID.Size = New System.Drawing.Size(34, 13)
        Me.lblUUID.TabIndex = 4
        Me.lblUUID.Text = "&UUID"
        '
        'txtUUID
        '
        Me.txtUUID.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUUID.Location = New System.Drawing.Point(261, 59)
        Me.txtUUID.Name = "txtUUID"
        Me.txtUUID.ReadOnly = True
        Me.txtUUID.Size = New System.Drawing.Size(128, 20)
        Me.txtUUID.TabIndex = 5
        '
        'lblCreated
        '
        Me.lblCreated.AutoSize = True
        Me.lblCreated.Location = New System.Drawing.Point(192, 205)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(44, 13)
        Me.lblCreated.TabIndex = 10
        Me.lblCreated.Text = "&Created"
        '
        'txtCreated
        '
        Me.txtCreated.Location = New System.Drawing.Point(261, 202)
        Me.txtCreated.Name = "txtCreated"
        Me.txtCreated.ReadOnly = True
        Me.txtCreated.Size = New System.Drawing.Size(128, 20)
        Me.txtCreated.TabIndex = 11
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(192, 257)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(46, 13)
        Me.lblBalance.TabIndex = 12
        Me.lblBalance.Text = "&Balance"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(261, 250)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(128, 20)
        Me.txtBalance.TabIndex = 13
        '
        'pbFlowIndicator
        '
        Me.pbFlowIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFlowIndicator.Image = Global.PA_10_W_Weinert.My.Resources.Resources.triangle
        Me.pbFlowIndicator.InitialImage = Nothing
        Me.pbFlowIndicator.Location = New System.Drawing.Point(154, 206)
        Me.pbFlowIndicator.Name = "pbFlowIndicator"
        Me.pbFlowIndicator.Size = New System.Drawing.Size(25, 25)
        Me.pbFlowIndicator.TabIndex = 8
        Me.pbFlowIndicator.TabStop = False
        '
        'ofdOpenDatabase
        '
        Me.ofdOpenDatabase.Filter = "Access Database files|*.accdb"
        '
        'sfdNewDatabase
        '
        Me.sfdNewDatabase.Filter = "Access Database files|*.accdb"
        '
        'frmBankAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 399)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.txtCreated)
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(Me.txtUUID)
        Me.Controls.Add(Me.lblUUID)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.chkShowTransactionsForAllAccounts)
        Me.Controls.Add(Me.lblTransactions)
        Me.Controls.Add(Me.pbFlowIndicator)
        Me.Controls.Add(Me.lblAccountInfoTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstCustomers)
        Me.Controls.Add(Me.lblCustomersTitle)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.gbMakeATransaction)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.msMain
        Me.MaximizeBox = False
        Me.Name = "frmBankAccounts"
        Me.Text = "placeholder"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.gbMakeATransaction.ResumeLayout(False)
        Me.gbMakeATransaction.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlowIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
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
    Friend WithEvents pbFlowIndicator As System.Windows.Forms.PictureBox
    Friend WithEvents lblTransactions As System.Windows.Forms.Label
    Friend WithEvents chkShowTransactionsForAllAccounts As System.Windows.Forms.CheckBox
    Friend WithEvents dgvTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents miOpenDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCloseDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miChangeBankName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblUUID As System.Windows.Forms.Label
    Friend WithEvents txtUUID As System.Windows.Forms.TextBox
    Friend WithEvents lblCreated As System.Windows.Forms.Label
    Friend WithEvents txtCreated As System.Windows.Forms.TextBox
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents NewDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdOpenDatabase As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdNewDatabase As System.Windows.Forms.SaveFileDialog

End Class
