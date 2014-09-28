Option Strict On

Public Class frmMax

    'Using generics, we can create a Max(a, b) and then a Max(a, b, c) function
    'that will work with any comparable type, meaning Double, Integer, Decimal
    'and so on.

    Private Function Max(Of numeric As IComparable)(ByVal a As numeric,
                                                    ByVal b As numeric) As numeric
        Return If(a.CompareTo(b) > 0, a, b)
    End Function

    Private Function Max(Of numeric As IComparable)(ByVal a As numeric,
                                                    ByVal b As numeric,
                                                    ByVal c As numeric) As numeric
        Return Max(Max(a, b), c)
    End Function

    Private Function Max3Carl(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer) As Integer
        Dim max As Integer
        max = num1
        If num2 > max Then
            max = num2
        ElseIf num3 > max Then
            max = num3
        End If
        Return max
    End Function

    Private Function Max3FixedCarl(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer) As Integer
        Dim max As Integer
        If num2 > max Then
            max = num2
        End If
        If num3 > max Then
            max = num3
        End If
        Return max
    End Function

    Private Sub button_Click(sender As Object, e As EventArgs) Handles _
        btnWinnyMax.Click,
        btnWrongCarlMax.Click,
        btnFixedCarlMax.Click

        Dim a, b, c As Integer
        Dim validInput As Boolean =
            Integer.TryParse(txtA.Text, a) AndAlso
            Integer.TryParse(txtB.Text, b) AndAlso
            Integer.TryParse(txtC.Text, c)

        If Not validInput Then
            MessageBox.Show(text:="Invalid input. Enter whole numbers.",
                            caption:="Error",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Error)
            Return
        End If

        Dim m As Integer
        If sender Is btnWinnyMax Then
            m = Max(a, b, c)
        ElseIf sender Is btnWrongCarlMax Then
            m = Max3Carl(a, b, c)
        Else
            m = Max3FixedCarl(a, b, c)
        End If

        txtGreatestNumber.Text = m.ToString
    End Sub

    Private Sub focusedATextBox(sender As Object, e As EventArgs) Handles _
        txtA.Click, txtA.GotFocus,
        txtB.Click, txtB.GotFocus,
        txtC.Click, txtC.GotFocus,
        txtGreatestNumber.Click, txtGreatestNumber.GotFocus

        CType(sender, TextBox).SelectAll()
    End Sub

End Class
