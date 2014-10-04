Public Class frmNumberPrompt

    Public Shared Function ShowDialogForInteger(prompt As String, title As String, defaultValue As Integer) As Integer
        Dim f As New frmNumberPrompt
        f.lblPrompt.Text = prompt
        f.Text = title
        f.nudNumber.Value = defaultValue
        f.ShowDialog()
        Return f.nudNumber.Value
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class