'*****************************************************************
'PA 5: Bank Accounts
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Imports PA_5_W_Weinert

Public Class frmBankAccounts

    Private people(Account.MAX_ACCOUNTS - 1) As Account

    '*****************************************************************
    'Helpers
    '*****************************************************************

    Private Sub display()
        Dim selected As Account = TryCast(lstCustomers.SelectedItem, Account)
        lstCustomers.Items.Clear()
        For i As Integer = 0 To people.Length - 1
            If people(i) Is Nothing Then Exit For
            lstCustomers.Items.Add(people(i))
        Next
        If selected IsNot Nothing Then
            lstCustomers.SelectedItem = selected
            lblAccountInfo.Text = selected.details()
        End If
    End Sub

    Private Function parseCurrency(ByRef n As Decimal) As Boolean
        Dim valid As Boolean = Account.TryParseCurrency(txtAmount.Text, n)
        If Not valid Then
            MessageBox.Show("Invalid amount.")
        End If
        Return valid
    End Function

    '*****************************************************************
    'GUI handlers
    '*****************************************************************

    Private Sub miNewCustomer_Click(sender As Object, e As EventArgs) Handles miNewCustomer.Click
        Dim name As String = InputBox("Enter a name: ")
        If Not Account.NameIsValid(name) Then
            MessageBox.Show("Bad name")
            Return
        End If
        Debug.Assert(people.Last Is Nothing)
        For i As Integer = 0 To people.Length - 1
            If people(i) IsNot Nothing Then Continue For
            people(i) = New Account(name)
            If i = people.Length - 1 Then miNewCustomer.Enabled = False
            Exit For
        Next
        display()
    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        Dim a As Account = TryCast(lstCustomers.SelectedItem, Account)
        lblAccountInfo.Text = If(a Is Nothing, String.Empty, a.details())
        gbMakeATransaction.Enabled = a IsNot Nothing
    End Sub

    Private Sub bntDeposit_Click(sender As Object, e As EventArgs) Handles bntDeposit.Click
        Debug.Assert(lstCustomers.SelectedIndex <> -1)
        Dim amount As Decimal
        If Not parseCurrency(amount) Then Return
        CType(lstCustomers.SelectedItem, Account).deposit(amount)
        display()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Debug.Assert(lstCustomers.SelectedIndex <> -1)
        Dim amount As Decimal
        If Not parseCurrency(amount) Then Return
        If Not CType(lstCustomers.SelectedItem, Account).withdraw(amount) Then MessageBox.Show("Not enough funds")
        display()
    End Sub

    Private Sub miTotalBankBalance_Click(sender As Object, e As EventArgs) Handles miTotalBankBalance.Click
        MessageBox.Show(text:="Total balance: " & Account.totalFunds.ToString("C"))
    End Sub

    Private Sub exit_Click(sender As Object, e As EventArgs) Handles _
        btnExit.Click,
        miExit.Click

        Close()
    End Sub

End Class
