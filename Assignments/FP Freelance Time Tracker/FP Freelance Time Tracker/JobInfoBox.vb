Option Strict On

Public Class JobInfoBox

    Private _Job As Job

    Public Property Job As Job
        Get
            Return _Job
        End Get
        Set(value As Job)
            _Job = value
            If _Job Is Nothing Then
                ClientTextBox.Clear()
                RateTextBox.Clear()
                StartDateTextBox.Clear()
                NotesTextBox.Clear()
                HoursSpentTextBox.Clear()
                TotalEarnedTextBox.Clear()
                Return
            End If
            With _Job
                ClientTextBox.Text = .Client.Name
                RateTextBox.Text = .Rate.ToString("C")
                StartDateTextBox.Text = .StartDate.ToString()
                NotesTextBox.Text = .Notes
                HoursSpentTextBox.Text = .HoursSpent.ToString()
                TotalEarnedTextBox.Text = .TotalEarned.ToString("C")
            End With
        End Set
    End Property

    Public Sub Clear()
        Job = Nothing
    End Sub

End Class
