Public Class Form1

    Private Const DISCOUNT As Decimal = 0.039D

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decCost As Decimal = 9.99D
        txtOutput.Text = String.Format(
            "I will send you {0:C}{1}for the software",
            decCost,
            ControlChars.CrLf
        )
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim n As Decimal

        txtOutputPercentage.Clear()

        Try
            n = Decimal.Parse(txtInputDecimal.Text)
        Catch ex As Exception When _
            TypeOf ex Is FormatException OrElse TypeOf ex Is OverflowException

            MessageBox.Show(text:="Enter a number please",
                            caption:="Error")
            Return
        End Try

        n += 0.05D

        txtOutputPercentage.Text = n.ToString("P")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        lblOutput.Text = String.Empty
        txtInput.Focus()
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        With lstResults.Items
            .Clear()
            .Add(DISCOUNT.ToString("P"))
        End With
    End Sub
End Class
