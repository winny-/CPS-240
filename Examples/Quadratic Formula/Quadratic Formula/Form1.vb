Option Strict On

Public Class frmQuadraticFormula

    Private Enum solutions
        None
        One
        Two
    End Enum

    Private Structure quadraticFormulaComputation
        Public a, b, c As Double
        Public discriminant As Double
        Public x1, x2 As Double
        Public solutions As solutions
    End Structure

    Private Function computeQuadraticFormula(ByVal computation As quadraticFormulaComputation) As quadraticFormulaComputation
        With computation
            .discriminant = .b ^ 2 - 4 * .a * .c
            If .discriminant < 0 Then
                .solutions = solutions.None
                .x1 = Nothing
                .x2 = Nothing
            ElseIf .discriminant = 0 Then
                .solutions = solutions.One
                .x1 = (-.b + Math.Sqrt(.b ^ 2 - 4 * .a * .c)) / (2 * .a)
                .x2 = Nothing
            ElseIf .discriminant > 0 Then
                .solutions = solutions.Two
                .x1 = (-.b + Math.Sqrt(.b ^ 2 - 4 * .a * .c)) / (2 * .a)
                .x2 = (-.b - Math.Sqrt(.b ^ 2 - 4 * .a * .c)) / (2 * .a)
            End If
        End With
        Return computation
    End Function

    Private Sub doQuadraticFormula()
        Dim computation As quadraticFormulaComputation

        clearOutputs()

        If Not (Double.TryParse(txtA.Text, computation.a) AndAlso
            Double.TryParse(txtB.Text, computation.b) AndAlso
            Double.TryParse(txtC.Text, computation.c)) Then

            MessageBox.Show(text:="Invalid input!")
            Return
        End If

        computation = computeQuadraticFormula(computation)

        txtDiscriminant.Text = computation.discriminant.ToString

        If computation.solutions = solutions.None Then
            txtSolutions.Text = "No real solutions"
        Else
            txtX1.Text = computation.x1.ToString
            If computation.solutions = solutions.One Then
                txtSolutions.Text = "One real solution"
            ElseIf computation.solutions = solutions.Two Then
                txtSolutions.Text = "Two real solutions"
                txtX2.Text = computation.x2.ToString
            Else
                Debug.Fail("Bad computation.solutions value")
            End If
        End If


    End Sub

    Private Sub clearOutputs()
        txtSolutions.Clear()
        txtDiscriminant.Clear()
        txtX1.Clear()
        txtX2.Clear()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        doQuadraticFormula()
    End Sub

    Private Sub inputs_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged, txtB.TextChanged, txtC.TextChanged
        clearOutputs()
    End Sub
End Class
