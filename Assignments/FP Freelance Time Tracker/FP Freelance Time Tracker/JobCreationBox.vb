Option Strict On

Imports System.Text.RegularExpressions

Public Class JobCreationBox

    Public Const RateRegex As String = "^\$?(\d+|\.\d+|\d+\.\d+)$"

    Public Property Job As Job
        Get
            If Not ValidateChildren() Then Return Nothing
            Dim j As New Job
            With j
                .Client = New Client With {.Name = ClientTextBox.Text}
                .Rate = Decimal.Parse(Regex.Match(RateTextBox.Text, RateRegex).Groups(1).Value)
                .StartDate = StartDateTimePicker.Value.Date
                .Notes = NotesTextBox.Text
            End With
            Return j
        End Get
        Set(value As Job)
            ClientTextBox.Clear()
            RateTextBox.Clear()
            NotesTextBox.Clear()
            If value Is Nothing Then Return
            ClientTextBox.Text = value.Client.Name
            RateTextBox.Text = value.Rate.ToString("C")
            StartDateTimePicker.Value = value.StartDate
            NotesTextBox.Text = value.Notes
        End Set
    End Property

    Private Sub ClientTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ClientTextBox.Validating
        Dim valid As Boolean = ClientTextBox.Text <> String.Empty
        e.Cancel = Not valid
        ClientErrorProvider.SetError(ClientTextBox, If(valid, String.Empty, "Client must be at least one character."))
    End Sub

    Private Sub RateTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RateTextBox.Validating
        Dim valid As Boolean = Regex.IsMatch(RateTextBox.Text, RateRegex)
        e.Cancel = Not valid
        RateErrorProvider.SetError(RateTextBox, If(valid, String.Empty, "Rate must be valid US currency."))
    End Sub

End Class
