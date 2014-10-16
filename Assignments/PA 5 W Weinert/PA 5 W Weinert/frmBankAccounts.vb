'*****************************************************************
'PA 5: Bank Accounts
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Imports PA_5_W_Weinert

Public Class frmBankAccounts

    Private People(Account.MAX_ACCOUNTS - 1) As Account

    Private ReadOnly Property SelectedAccount As Account
        Get
            Return TryCast(lstCustomers.SelectedItem, Account)
        End Get
    End Property

    '*****************************************************************
    'LINQ helper properties
    '*****************************************************************

    Private ReadOnly Property InstantiatedAccounts As IEnumerable(Of Account)
        Get
            Return From p In People
                   Where p IsNot Nothing
        End Get
    End Property

    Private ReadOnly Property AllTransactions As IEnumerable(Of Account.Transaction)
        Get
            Return From p In InstantiatedAccounts, t In p.Transactions
                   Select t
                   Order By t.Time Ascending
        End Get
    End Property

    '*****************************************************************
    'Helpers
    '*****************************************************************

    Private Sub Display(ByVal overideSelected As Account)
        Dim selected As Account = If(overideSelected IsNot Nothing,
                                     overideSelected,
                                     SelectedAccount)
        lstCustomers.Items.Clear()

        For Each a In InstantiatedAccounts
            lstCustomers.Items.Add(a)
        Next

        If selected IsNot Nothing Then lstCustomers.SelectedItem = selected
    End Sub

    Private Sub Display()
        Display(overideSelected:=Nothing)
    End Sub

    'This is a bit of a monster. I didn't find a more concise way to populate a DataGridView when one does not have a database of sorts.
    '
    'It looks like a lot, but it only does the following:
    '1. Clear the DataGridView.
    '2. Tell the DataGridView generate column names from their DataSource field names.
    '3. If the user wants to see all transactions, do that
    '   ELSE show tranactions for the selected user.
    '4. Adjust the column width for the Time column so it is not truncated with "..." in the UI.
    '
    Private Sub DisplayTransactions()
        dgvTransactions.Columns.Clear()
        dgvTransactions.AutoGenerateColumns = True 'Does not appear in my Properties window.

        If chkShowTransactionsForAllAccounts.Checked Then
            'Show transactions for ALL accounts.

            'The aliased columns are necessary to give the datasource nice looking column names.
            dgvTransactions.DataSource = (From t In AllTransactions
                                          Select
                                          Name = t.Account.Name,
                                          Time = t.Time,
                                          Amount = t.Amount.ToString("C"),
                                          Kind = t.Kind,
                                          Balance = t.Balance.ToString("C")
                                          ).ToList()

            dgvTransactions.Columns(1).MinimumWidth = 100 'Adjust the time (second) column to avoid truncation.
        Else
            'Show tranactions for only the selected account.
            Dim selected As Account = SelectedAccount

            'Give something to the LINQ query that'll keep the compiler content, even without a selected account.
            Dim selectedTransactions As List(Of Account.Transaction) = If(selected IsNot Nothing,
                                                                          selected.Transactions,
                                                                          New List(Of Account.Transaction))

            'Almost the same as the above query except we omit the Name column because they will never differ
            'for a single account's transactions.
            dgvTransactions.DataSource = (From t In selectedTransactions
                                          Select
                                          Time = t.Time,
                                          Amount = t.Amount.ToString("C"),
                                          Kind = t.Kind,
                                          Balance = t.Balance.ToString("C")
                                          ).ToList()

            dgvTransactions.Columns(0).MinimumWidth = 100 'Make sure time (first) column is readable.
        End If
    End Sub

    Private Function ParseCurrency(ByRef n As Decimal) As Boolean
        Dim valid As Boolean = Account.TryParseCurrency(txtAmount.Text, n)
        If Not valid Then
            MessageBox.Show(text:="Invalid amount.",
                            caption:="Bad input",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Error)
            txtAmount.Focus()
            txtAmount.SelectAll()
        End If
        Return valid
    End Function

    '*****************************************************************
    'GUI handlers
    '*****************************************************************

    Private Sub miNewCustomer_Click(sender As Object, e As EventArgs) Handles miNewCustomer.Click
        If People.Last IsNot Nothing Then
            MessageBox.Show(text:="Sorry, no more accounts may be created.",
                            caption:="Max account limit reached",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Error)
            Return
        End If

        Dim nameResult As Tuple(Of Boolean, String) = frmNewAccount.ShowDialogForName()
        If Not nameResult.Item1 Then Return 'The user clicked Cancel.
        Dim name As String = nameResult.Item2

        Dim newAccount As New Account(name)
        For i As Integer = 0 To People.Length - 1
            If People(i) Is Nothing Then
                People(i) = newAccount
                Exit For
            End If
        Next

        Display(overideSelected:=newAccount)
        txtAmount.Focus()
    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        Dim anAccountIsSelected As Boolean = SelectedAccount IsNot Nothing
        lblAccountInfo.Text = If(anAccountIsSelected,
                                 SelectedAccount.ToDetailsString(),
                                 String.Empty)
        gbMakeATransaction.Enabled = anAccountIsSelected
        'Don't force a DataSource rebuild when tranactions for all users are shown.
        'Without the check, it'll always scroll to the top which is undesirable.
        If Not chkShowTransactionsForAllAccounts.Checked Then DisplayTransactions()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim amount As Decimal
        If Not ParseCurrency(amount) Then Return
        txtAmount.Clear()
        txtAmount.Focus()
        Debug.Assert(SelectedAccount.Deposit(amount)) 'Should always be successful.
        Display()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim amount As Decimal
        If Not ParseCurrency(amount) Then Return
        If Not SelectedAccount.Withdraw(amount) Then
            MessageBox.Show(text:="Not enough funds",
                            caption:="Could not withdraw",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Error)
            txtAmount.SelectAll()
        Else
            txtAmount.Clear()
        End If
        txtAmount.Focus()
        Display()
    End Sub

    Private Sub miTotalBankBalance_Click(sender As Object, e As EventArgs) Handles miTotalBankBalance.Click
        MessageBox.Show(text:="Total balance: " & Account.TotalFunds.ToString("C"),
                        caption:="Total balance",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Information)
    End Sub

    Private Sub exit_Click(sender As Object, e As EventArgs) Handles _
        btnExit.Click,
        miExit.Click

        Close()
    End Sub

    Private Sub chkShowTransactionsForAllAccounts_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowTransactionsForAllAccounts.CheckedChanged
        DisplayTransactions()
    End Sub

    Private Sub frmBankAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTransactions()
    End Sub

End Class
