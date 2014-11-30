Option Strict On

Imports PA_10_W_Weinert

Public Class frmNewAccount

    Public Structure NewAccountDialogResult
        Public FirstName, LastName As String
        Public ClickedOkay As Boolean
    End Structure

    Private OkayWasClicked As Boolean

    Public Shared Function ShowDialogForName() As NewAccountDialogResult
        Dim f As New frmNewAccount()
        f.ShowDialog()
        Return New NewAccountDialogResult With {.ClickedOkay = f.OkayWasClicked,
                                                .FirstName = f.txtFirstName.Text,
                                                .LastName = f.txtLastName.Text}
    End Function


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        OkayWasClicked = False
        Close()
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Dim first As String = txtFirstName.Text
        Dim last As String = txtLastName.Text
        If Not (Account.ValidateName(first) AndAlso Account.ValidateName(last)) Then
            MessageBox.Show(text:="Invalid name. Please choose an unique name using letters only.",
                            caption:="Bad name",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Error)
        Else
            OkayWasClicked = True
            Close()
        End If
    End Sub

End Class
