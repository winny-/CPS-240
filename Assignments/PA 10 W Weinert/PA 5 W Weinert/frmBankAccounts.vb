'*****************************************************************
'PA 10: Banking Revisited
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Imports PA_10_W_Weinert

Public Class frmBankAccounts

    Private InhibitSelectedIndexChanged As Boolean = False
    Private LastSelectedAccount As Account = Nothing

    Public ReadOnly Property SelectedAccount As Account
        Get
            Return TryCast(lstCustomers.SelectedItem, Account)
        End Get
    End Property

    Public Property LogicLayer As New LogicLayer

    Private Sub frmBankAccounts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        LogicLayer.CloseDatabase()
    End Sub

    Private Sub frmBankAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Debug.WriteLine() messages will now appear in the application log.
        'How to find them: http://windows.microsoft.com/en-us/windows/open-event-viewer
        Debug.Listeners.Add(New EventLogTraceListener("Application"))
        Debug.WriteLine("PA 10 W Weinert has been launched.")

        If Not PA_10_W_Weinert.LogicLayer.HasDatabaseSupport() Then
            If MessageBox.Show("This computer does not have the ACE (Microsoft Access OLE provider) installed. Really continue?", "", MessageBoxButtons.YesNo) <> Windows.Forms.DialogResult.Yes Then Close()
        End If

        ofdOpenDatabase.FileName = LogicLayer.LastFileOpened
        If Not LogicLayer.OpenLastFileOrDefault() Then
            MessageBox.Show("Unable to open last opened or default database.")
            ResetControls()
            Return
        End If
        Display()
        If LogicLayer.BankName.Trim() = String.Empty Then LogicLayer.BankName = "Bank of Winston"
    End Sub

    Private Sub Display()
        Dim sel As Account = SelectedAccount
        dgvTransactions.DataSource = If(LogicLayer.DatabaseIsOpen, LogicLayer.Transactions, Nothing)
        lstCustomers.Items.Clear()
        If LogicLayer.DatabaseIsOpen Then
            For Each a As Account In LogicLayer.Accounts
                lstCustomers.Items.Add(a)
            Next
            If sel IsNot Nothing Then
                lstCustomers.SelectedItem = sel
            End If
        End If
        Me.Text = If(LogicLayer.DatabaseIsOpen, String.Format("{0} :: {1}", LogicLayer.BankName, LogicLayer.FileName), "Banking revisited")
        DisplayTransactions()
        ValidateControls()
    End Sub

    Public Sub ValidateControls()
        gbMakeATransaction.Enabled = SelectedAccount IsNot Nothing
        btnWithdraw.Enabled = SelectedAccount IsNot Nothing AndAlso SelectedAccount.Funds > 0D
        miCloseDatabase.Enabled = LogicLayer.DatabaseIsOpen
        dgvTransactions.Enabled = LogicLayer.DatabaseIsOpen
        lstCustomers.Enabled = LogicLayer.DatabaseIsOpen
        chkShowTransactionsForAllAccounts.Enabled = LogicLayer.DatabaseIsOpen
        miTotalBankBalance.Enabled = LogicLayer.DatabaseIsOpen
        miChangeBankName.Enabled = LogicLayer.DatabaseIsOpen
        miNewCustomer.Enabled = LogicLayer.DatabaseIsOpen
        miRemoveAccount.Enabled = SelectedAccount IsNot Nothing
    End Sub

    Public Sub ResetControls()
        lstCustomers.Items.Clear()
        chkShowTransactionsForAllAccounts.Checked = False
        dgvTransactions.DataSource = Nothing
        ClearInfo()
        Display()
    End Sub

    Public Sub ClearInfo()
        For Each t As TextBox In {txtBalance, txtCreated, txtFirstName, txtLastName, txtUUID} : t.Clear() : Next
    End Sub

    Public Sub DisplayTransactions()
        If Not LogicLayer.DatabaseIsOpen Then Return
        If Not chkShowTransactionsForAllAccounts.Checked Then
            dgvTransactions.DataSource = (From t As Account.Transaction In LogicLayer.Transactions()
                                          Where t.Account.Equals(SelectedAccount)
                                          ).ToList()
        Else
            dgvTransactions.DataSource = LogicLayer.Transactions()
        End If
    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles _
        btnExit.Click,
        miExit.Click

        Me.Close()
    End Sub

    Private Sub miTotalBankBalance_Click(sender As Object, e As EventArgs) Handles miTotalBankBalance.Click
        MessageBox.Show(String.Format("Total funds: {0:C}", LogicLayer.TotalFunds))
    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        ClearInfo()
        ValidateControls()
        Dim account As Account = SelectedAccount
        If account Is Nothing Then Return
        txtUUID.Text = account.UUID.ToString()
        txtFirstName.Text = account.FirstName
        txtLastName.Text = account.LastName
        txtCreated.Text = account.Created.ToString()
        txtBalance.Text = account.Funds.ToString("C")
        DisplayTransactions()
    End Sub

    Private Sub WithdrawOrDeposit_Click(sender As Object, e As EventArgs) Handles _
        btnDeposit.Click,
        btnWithdraw.Click

        Dim kind As Account.Transaction.TransactionType = If(sender Is btnDeposit,
                                                             Account.Transaction.TransactionType.Deposit,
                                                             Account.Transaction.TransactionType.Withdrawal)
        Dim amount As Decimal
        If Not (Decimal.TryParse(txtAmount.Text, amount) AndAlso Account.ValidateCurrency(amount)) Then
            MessageBox.Show("Bad amount given")
            txtAmount.SelectAll()
            txtAmount.Focus()
            Return
        End If

        If kind = Account.Transaction.TransactionType.Deposit Then
            If Not SelectedAccount.Deposit(amount) Then
                MessageBox.Show("Unable to make deposit")
            End If
        Else
            If Not SelectedAccount.Withdraw(amount) Then
                MessageBox.Show("Unable to make withdrawal, do you have enough funds?")
            End If
        End If

        Display()
    End Sub

    Private Sub miChangeBankName_Click(sender As Object, e As EventArgs) Handles miChangeBankName.Click
        LogicLayer.BankName = InputBox("Enter new bank name")
        Display()
    End Sub

    Private Sub miNewCustomer_Click(sender As Object, e As EventArgs) Handles miNewCustomer.Click
        Dim res As frmNewAccount.NewAccountDialogResult = frmNewAccount.ShowDialogForName()
        If res.ClickedOkay Then
            LogicLayer.AddAccount(New Account(res.FirstName, res.LastName))
        End If
        Display()
    End Sub

    Private Sub miCloseDatabase_Click(sender As Object, e As EventArgs) Handles miCloseDatabase.Click
        LogicLayer.CloseDatabase()
        ResetControls()
    End Sub

    Private Sub NewDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDatabaseToolStripMenuItem.Click
        Dim res As DialogResult = sfdNewDatabase.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            If LogicLayer.DatabaseIsOpen Then LogicLayer.CloseDatabase()
            ResetControls()
            If Not LogicLayer.NewFile(sfdNewDatabase.FileName) Then MessageBox.Show("Could not create file and open.")
            Display()
            If lstCustomers.Items.Count > 0 Then lstCustomers.SelectedIndex = 0
        End If
    End Sub

    Private Sub miOpenDatabase_Click(sender As Object, e As EventArgs) Handles miOpenDatabase.Click
        Dim res As DialogResult = ofdOpenDatabase.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            If LogicLayer.DatabaseIsOpen Then LogicLayer.CloseDatabase()
            ResetControls()
            If Not LogicLayer.OpenFile(ofdOpenDatabase.FileName) Then MessageBox.Show("Could not open database.")
            Display()
            If lstCustomers.Items.Count > 0 Then lstCustomers.SelectedIndex = 0
        End If
    End Sub

    Private Sub chkShowTransactionsForAllAccounts_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowTransactionsForAllAccounts.CheckedChanged
        Display()
    End Sub

    Private Sub miRemoveAccount_Click(sender As Object, e As EventArgs) Handles miRemoveAccount.Click
        LogicLayer.RemoveAccount(SelectedAccount)
        Display()
        ClearInfo()
    End Sub

End Class
