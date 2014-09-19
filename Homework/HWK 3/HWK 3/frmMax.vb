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

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Dim a, b, c As Integer
        Dim validInput As Boolean =
            Integer.TryParse(txtA.Text, a) AndAlso
            Integer.TryParse(txtB.Text, b) AndAlso
            Integer.TryParse(txtC.Text, c)

        If Not validInput Then
            MessageBox.Show("Invalid input.")
            Return
        End If

        txtGreatestNumber.Text = Max(a, b, c).ToString()
    End Sub

    Private Sub focusedATextBox(sender As Object, e As EventArgs) Handles _
        txtA.Click, txtA.GotFocus,
        txtB.Click, txtB.GotFocus,
        txtC.Click, txtC.GotFocus,
        txtGreatestNumber.Click, txtGreatestNumber.GotFocus

        CType(sender, TextBox).SelectAll()
    End Sub

End Class
