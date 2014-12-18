Option Strict On

Public Class AddEditJobForm

    Public Shared Function ShowDialogForNewJob() As Tuple(Of Job, Boolean)
        Dim f As New AddEditJobForm
        f.Text = "Add new job"
        f.ContinueButton.Text = "&Add"
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return Tuple.Create(f.TheJobCreationBox.Job, True)
        Else
            Return Tuple.Create(Of Job, Boolean)(Nothing, False)
        End If
    End Function

    Public Shared Function ShowDialogForEditJob(j As Job) As Tuple(Of Job, Boolean)
        Dim f As New AddEditJobForm
        f.Text = "Edit " & j.ToLongString()
        f.ContinueButton.Text = "&Done editing"
        f.TheJobCreationBox.Job = j
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim newJob As Job = f.TheJobCreationBox.Job
            newJob.GUID = j.GUID
            Return Tuple.Create(newJob, True)
        Else
            Return Tuple.Create(j, False)
        End If
    End Function

    Private Sub TheCancelButton_Click(sender As Object, e As EventArgs) Handles TheCancelButton.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        If Not ValidateChildren() Then Return
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

End Class