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
    'Helpers
    '*****************************************************************

    Private Sub Display(ByVal overideSelected As Account)
        Dim selected As Account = If(overideSelected IsNot Nothing,
                                     overideSelected,
                                     SelectedAccount)
        lstCustomers.Items.Clear()

        Dim instantiatedAccounts As IEnumerable(Of Account) = From p In People Where p IsNot Nothing
        For Each a In instantiatedAccounts
            lstCustomers.Items.Add(a)
        Next
        If selected IsNot Nothing Then lstCustomers.SelectedItem = selected
    End Sub

    Private Sub Display()
        Display(overideSelected:=Nothing)
    End Sub

    Private Sub DisplayTransactions()
        dgvTransactions.Columns.Clear()
        dgvTransactions.AutoGenerateColumns = True
        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        If Not chkShowTransactionsForAllAccounts.Checked Then
            Dim selected As Account = SelectedAccount

            If selected Is Nothing Then
                'A hack to always show columns.
                Static dummy As New Account("Dummy account do not use")
                selected = dummy
            End If

            dgvTransactions.DataSource = (From t In selected.Transactions Select Time = t.Time, Amount = t.Amount.ToString("C"), Kind = t.Kind, Balance = t.Balance.ToString("C")).ToList()
            dgvTransactions.Columns(0).MinimumWidth = 100 'Make sure time column is readable.
        Else
            Dim allPeople As IEnumerable(Of Account) = (From a In People Where a IsNot Nothing)
            Dim allTransactions As IEnumerable(Of Account.Transaction) = (From a In allPeople, t In a.Transactions Select t Order By t.Time Ascending)
            dgvTransactions.DataSource = (From t In allTransactions Select Name = t.Account.Name, Time = t.Time, Amount = t.Amount.ToString("C"), Kind = t.Kind, Balance = t.Balance.ToString("C")).ToList()
            dgvTransactions.Columns(1).MinimumWidth = 100 'Notice it's not the first column.
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

        Debug.Assert(People.Last Is Nothing)
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
        DisplayTransactions()
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
        Else
            txtAmount.Clear()
            txtAmount.Focus()
        End If
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
