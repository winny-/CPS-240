Option Strict On

Public Class Form1

    Private lastButton As Button = Nothing
    Private buttonClickCount As Integer = 0

    Private Sub Button_click(sender As Object, e As EventArgs) Handles _
        btnAlpha.Click,
        btnBeta.Click

        buttonClickCount += 1

        lastButton = CType(sender, Button)
        Dim nextButton As Button = If(lastButton Is btnAlpha, btnBeta, btnAlpha)

        If chkAccepButton.Checked Then AcceptButton = nextButton
        If chkSelect.Checked Then nextButton.Select()

        updateLabels()
    End Sub

    Private Sub updateLabels()
        lblAcceptButton.Text = If(AcceptButton Is Nothing, "(none)", CType(AcceptButton, Button).Text)
        lblLastClicked.Text = If(lastButton Is Nothing, "(none)", lastButton.Text)
        Dim current As Control = ActiveControl
        Dim name As String
        If current IsNot Nothing Then
            name = If(current IsNot TextBox1, current.Text, "Dummy textbox").Replace("&", "")
        Else
            name = "(none)"
        End If
        lblCurrentlySelected.Text = If(name.Length > 6, TruncateString(name, 6) & "...", name)
        lblClickCount.Text = buttonClickCount.ToString
    End Sub

    Private Sub Form1_GotFocus(sender As Object, e As EventArgs) Handles _
        btnAlpha.GotFocus,
        btnBeta.GotFocus,
        TextBox1.GotFocus,
        chkAccepButton.GotFocus,
        chkSelect.GotFocus

        updateLabels()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateLabels()
    End Sub

    Private Shared Function TruncateString(s As String, l As Integer) As String
        Return If(s.Length <= l, s, s.Substring(0, l))
    End Function

End Class
