Public Class frmNumberPrompt

    Public Shared Function ShowDialogForInteger(prompt As String, title As String, defaultValue As Integer) As Integer
        Dim f As New frmNumberPrompt
        f.Label1.Text = prompt
        f.Text = title
        f.NumericUpDown1.Value = defaultValue
        f.ShowDialog()
        Return f.NumericUpDown1.Value
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class