Option Strict On

Imports PA_5_W_Weinert

Public Class frmNewAccount

    Private OkayWasClicked As Boolean

    Public Shared Function ShowDialogForName() As Tuple(Of Boolean, String)
        With New frmNewAccount
            .ShowDialog()
            Return Tuple.Create(.OkayWasClicked, .txtName.Text)
        End With
    End Function


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        OkayWasClicked = False
        Close()
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Dim name As String = txtName.Text
        If Not Account.ValidateName(name) Then
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
