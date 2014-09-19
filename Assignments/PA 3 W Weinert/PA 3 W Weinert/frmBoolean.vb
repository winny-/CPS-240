'*****************************************************************
'PA 3: Boolean
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Public Class frmBoolean

    Private solution As Boolean
    Private correctCount, wrongCount As Integer

    Private Enum Operation
        Or_
        And_
    End Enum

    '********************
    'Random Helpers
    '********************

    Private Function randomBoolean() As Boolean
        Static rand As Random = New Random
        Return rand.Next(2) <> 0
    End Function

    Private Function randomOperation() As Operation
        Return If(randomBoolean(), Operation.Or_, Operation.And_)
    End Function

    '********************
    'UI Helpers
    '********************

    Private Sub newGame()
        Dim first, second As Boolean
        Dim op As Operation

        first = randomBoolean()
        second = randomBoolean()
        op = randomOperation()

        If op = Operation.And_ Then
            solution = first AndAlso second
        ElseIf op = Operation.Or_ Then
            solution = first OrElse second
        Else
            Debug.Fail("Unknown operation type.")
        End If

        lblQuestion.Text = String.Format("{0} {1} {2} =",
                                    first,
                                    If(op = Operation.And_, "AND", "OR"),
                                    second)

        rdHidden.Checked = True
        btnNext.Enabled = False
        gbAnswer.Enabled = True
        picActualAnswer.Image = Nothing
    End Sub

    Private Sub solveGame(ByVal answer As Boolean)
        If answer = solution Then
            picActualAnswer.Image = My.Resources.smiley
            correctCount += 1
        Else
            picActualAnswer.Image = My.Resources.frowny
            wrongCount += 1
        End If

        lblCorrectCount.Text = String.Format("{0} correct", correctCount)
        lblWrongCount.Text = String.Format("{0} wrong", wrongCount)

        btnNext.Enabled = True
        gbAnswer.Enabled = False
    End Sub

    '********************
    'Events
    '********************

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        newGame()
    End Sub

    Private Sub rdTrueOrrdFalse_CheckedChanged(sender As Object, e As EventArgs) Handles rdTrue.CheckedChanged, rdFalse.CheckedChanged
        Dim radio As RadioButton = CType(sender, RadioButton)

        If Not radio.Checked Then Return

        solveGame(radio Is rdTrue)
    End Sub

    Private Sub miChangeForm_Click(sender As Object, e As EventArgs) Handles miChangeForm.Click
        If cdFormColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            BackColor = cdFormColor.Color
        End If
    End Sub

    Private Sub miDefaultColor_Click(sender As Object, e As EventArgs) Handles miDefaultColor.Click
        BackColor = DefaultBackColor
    End Sub

    Private Sub miSelectFile_Click(sender As Object, e As EventArgs) Handles miSelectFile.Click
        ofdWinnyChooser.Filter = "Winny Files (*.winny)|*.winny"
        ofdWinnyChooser.FileName = Nothing
        ofdWinnyChooser.ShowDialog()
    End Sub

    Private Sub chkShowCount_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowCount.CheckedChanged
        lblCorrectCount.Visible = chkShowCount.Checked
        lblWrongCount.Visible = chkShowCount.Checked
    End Sub

    Private Sub btnExitOrmiExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, miExit.Click
        Me.Close()
    End Sub

End Class
