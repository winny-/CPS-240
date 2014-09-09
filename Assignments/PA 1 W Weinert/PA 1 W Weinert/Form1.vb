'*****************************************************************
'PA 1: The Coin Problem
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On
Option Explicit On

Public Class frmCoinProblem

    Private Const QUARTER As Integer = 25
    Private Const DIME As Integer = 10
    Private Const NICKEL As Integer = 5
    Private Const PENNY As Integer = 1

    Private Const ERROR_FORMAT As String = "Invalid input ""{0}"". " &
        "Please enter a positive, non-zero integer less than 2,147,483,648."

    Private Structure Change
        Public quarters, dimes, nickels, pennies As Integer
    End Structure

    Private Function makeChange(ByVal tendered As Integer) As Change
        Dim myChange As Change

        With myChange
            .quarters = tendered \ QUARTER
            tendered = tendered Mod QUARTER

            .dimes = tendered \ DIME
            tendered = tendered Mod DIME

            .nickels = tendered \ NICKEL
            tendered = tendered Mod NICKEL

            .pennies = tendered \ PENNY
            tendered = tendered Mod PENNY
        End With

        'tendered should always be equal to zero, if not, our math is inaccurate.
        Debug.Assert(tendered = 0)

        Return myChange
    End Function

    Private Sub updateUI()
        Dim tendered As Integer

        If Not chkLivePreview.Checked Then
            With txtChangeInput
                .Focus()
                .SelectAll()
            End With
        End If

        ' Empty input when using live preview is okay -- just return.
        If chkLivePreview.Checked AndAlso txtChangeInput.Text = "" Then Return

        Try
            tendered = Integer.Parse(txtChangeInput.Text)

            If tendered <= 0 Then Throw New FormatException()
        Catch ex As Exception When TypeOf ex Is FormatException OrElse TypeOf ex Is OverflowException
            'Even Java 6 doesn't offer the above!
            'http://stackoverflow.com/questions/136035/catch-multiple-exceptions-at-once/136114#136114

            'VB.net has named paramters, nice!
            'http://msdn.microsoft.com/en-us/library/51wfzyw0.aspx
            MessageBox.Show(text:=String.Format(ERROR_FORMAT, txtChangeInput.Text),
                            caption:="Error",
                            buttons:=System.Windows.Forms.MessageBoxButtons.OK,
                            icon:=System.Windows.Forms.MessageBoxIcon.Error)
            Return
        End Try

        With makeChange(tendered)
            txtQuartersOutput.Text = .quarters.ToString
            txtDimesOutput.Text = .dimes.ToString
            txtNickelsOutput.Text = .nickels.ToString
            txtPenniesOutput.Text = .pennies.ToString
        End With
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        updateUI()
    End Sub

    Private Sub txtChangeInput_TextChanged(sender As Object, e As EventArgs) Handles txtChangeInput.TextChanged
        txtQuartersOutput.Clear()
        txtDimesOutput.Clear()
        txtNickelsOutput.Clear()
        txtPenniesOutput.Clear()

        If chkLivePreview.Checked Then updateUI()
    End Sub

    Private Sub txtChangeInput_MouseClickAndGotFocus(sender As Object, e As EventArgs) Handles txtChangeInput.MouseClick, txtChangeInput.GotFocus
        txtChangeInput.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
