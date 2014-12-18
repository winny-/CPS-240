Option Strict On

Public Class AddEditTimeEntryForm

    Public Shared Function ShowDialogForNewTimeEntry() As Tuple(Of TimeEntry, Boolean)
        Dim f As New AddEditTimeEntryForm
        f.Text = "Add new time entry"
        f.ContinueButton.Text = "&Add"
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return Tuple.Create(f.TheTimeEntryCreationBox.TimeEntry, True)
        Else
            Return Tuple.Create(Of TimeEntry, Boolean)(Nothing, False)
        End If
    End Function

    Public Shared Function ShowDialogForEditTimeEntry(te As TimeEntry) As Tuple(Of TimeEntry, Boolean)
        Dim f As New AddEditTimeEntryForm
        f.Text = "Edit " & te.ToLongString()
        f.ContinueButton.Text = "&Done editing"
        f.TheTimeEntryCreationBox.TimeEntry = te
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim newTE As TimeEntry = f.TheTimeEntryCreationBox.TimeEntry
            newTE.GUID = te.GUID
            newTE.Job = te.Job
            Return Tuple.Create(newTE, True)
        Else
            Return Tuple.Create(te, False)
        End If
    End Function

    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        If Not TheTimeEntryCreationBox.ValidateChildren() Then Return
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles TheCancelButton.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

End Class