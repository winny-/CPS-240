Option Strict On

Public Class frmMax

    'Using generics, we can create a Max() and then a Max3() function that will
    'work with any comparable type, meaning Double, Integer, Decimal and so on.
    Private Function Max(Of numeric As IComparable)(ByVal a As numeric,
                                                    ByVal b As numeric) As numeric
        Return If(a.CompareTo(b) > 0, a, b)
    End Function

    Private Function Max3(Of numeric As IComparable)(ByVal a As numeric,
                                                     ByVal b As numeric,
                                                     ByVal c As numeric) As numeric
        Return Max(Max(a, b), c)
    End Function

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Dim a, b, c As Integer
        If Not (Integer.TryParse(txtA.Text, a) AndAlso Integer.TryParse(txtB.Text, b) AndAlso Integer.TryParse(txtC.Text, c)) Then
            MessageBox.Show("Invalid input.")
            Return
        End If
        txtGreatestNumber.Text = Max3(a, b, c).ToString()
    End Sub

    Private Sub focusedATextBox(sender As Object, e As EventArgs) Handles txtA.Click, txtA.GotFocus, txtB.Click, txtB.GotFocus, txtC.Click, txtC.GotFocus, txtGreatestNumber.Click, txtGreatestNumber.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

End Class
