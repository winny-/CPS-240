Option Strict On

Public Class TimeEntryInfoBox

    Private _TimeEntry As TimeEntry

    Public Property TimeEntry As TimeEntry
        Get
            Return _TimeEntry
        End Get
        Set(value As TimeEntry)
            _TimeEntry = value
            If _TimeEntry Is Nothing Then
                EntryDateTextBox.Clear()
                HoursTextBox.Clear()
                CommentTextBox.Clear()
                Return
            End If
            With _TimeEntry
                EntryDateTextBox.Text = .EntryDate.ToString()
                HoursTextBox.Text = .TimeSpentInHours.ToString()
                CommentTextBox.Text = .Comment
            End With
        End Set
    End Property

    Public Sub Clear()
        TimeEntry = Nothing
    End Sub

End Class
