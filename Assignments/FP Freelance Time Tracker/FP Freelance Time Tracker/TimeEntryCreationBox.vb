Option Strict On

Imports System.Text.RegularExpressions

Public Class TimeEntryCreationBox

    Public Const HoursRegex As String = "^(\d+|\.\d+|\d+\.\d+)$"
    Public Const MinutesRegex As String = HoursRegex

    Public Property TimeEntry As TimeEntry
        Get
            If Not ValidateChildren() Then Return Nothing
            Dim te As New TimeEntry
            te.EntryDate = EntryDateTimePicker.Value.Date
            te.TimeSpent = Decimal.Parse(HoursTextBox.Text) * 60D + Decimal.Parse(MinutesTextBox.Text)
            te.Comment = CommentTextBox.Text
            Return te
        End Get
        Set(value As TimeEntry)
            HoursTextBox.Clear()
            MinutesTextBox.Clear()
            CommentTextBox.Clear()
            If value Is Nothing Then Return
            EntryDateTimePicker.Value = value.EntryDate
            HoursTextBox.Text = value.TimeSpentInHoursMinutes.Item1.ToString()
            MinutesTextBox.Text = value.TimeSpentInHoursMinutes.Item2.ToString()
            CommentTextBox.Text = value.Comment
        End Set
    End Property

    Private Sub HoursTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles HoursTextBox.Validating
        Dim valid As Boolean = Regex.IsMatch(HoursTextBox.Text, HoursRegex)
        e.Cancel = Not valid
        HoursErrorProvider.SetError(HoursTextBox, If(Not valid,
                                                     "Invalid hours",
                                                     String.Empty))
    End Sub

    Private Sub MinutesTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MinutesTextBox.Validating
        Dim valid As Boolean = Regex.IsMatch(MinutesTextBox.Text, MinutesRegex)
        e.Cancel = Not valid
        MinutesErrorProvider.SetError(MinutesTextBox, If(Not valid,
                                                         "Invalid minutes",
                                                         String.Empty))
    End Sub

End Class
