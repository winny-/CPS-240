'*****************************************************************
'PA 2: The Shipping Problem
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Imports PA_2_W_Weinert.Weight

Public Class frmShippingProblem

    Private Const SHIPPING_RATE As Decimal = 0.12D 'Per ounce
    Private Const SHIPPING_ID_FORMAT As String = "AWB{0:D2}"
    Private Const SHIPMENT_SUMMARY_FORMAT As String = "{0} {1} {2:C}"

    Private Sub makeNextID()
        Static ShippingID As Integer

        ShippingID += 1

        txtID.Text = String.Format(SHIPPING_ID_FORMAT, ShippingID)
    End Sub

    Private Sub frmShippingProblem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeNextID()
    End Sub

    Private Sub txtPoundsAndtxtOunces_TextChanged(sender As Object, e As EventArgs) Handles txtPounds.TextChanged, txtPounds.TextChanged
        txtCost.Clear()
    End Sub

    Private Sub btnCanculate_Click(sender As Object, e As EventArgs) Handles btnCanculate.Click
        Dim poundsValid, ouncesValid As Boolean
        Dim pounds, ounces As Integer

        Static totalWeight As Weight = New Weight()
        Dim inputtedWeight As Weight

        Static totalCost As Decimal
        Dim cost As Decimal

        poundsValid = Integer.TryParse(txtPounds.Text, pounds) AndAlso pounds >= 0
        ouncesValid = Integer.TryParse(txtOunces.Text, ounces) AndAlso ounces >= 0

        If Not poundsValid OrElse Not ouncesValid Then
            Dim errorMessages As List(Of String) = New List(Of String)

            If Not poundsValid Then errorMessages.Add(String.Format("Invalid pounds input ""{0}"".", txtPounds.Text))
            If Not ouncesValid Then errorMessages.Add(String.Format("Invalid ounces input ""{0}"".", txtOunces.Text))
            errorMessages.Add("Please input positive, non-zero whole numbers.")

            MessageBox.Show(text:=String.Join(" ", errorMessages),
                            caption:="Error: invalid input",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Error)
            Return
        End If

        inputtedWeight = New Weight(pounds, ounces)
        cost = CDec(inputtedWeight.TotalOunces) * SHIPPING_RATE
        txtCost.Text = cost.ToString("C")
        lstSummary.Items.Add(String.Format(SHIPMENT_SUMMARY_FORMAT, txtID.Text, inputtedWeight, cost))

        totalCost += cost
        totalWeight += inputtedWeight
        txtTotalCost.Text = totalCost.ToString("C")
        txtTotalWeight.Text = totalWeight.ToString

        makeNextID()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPounds.Clear()
        txtOunces.Clear()
        txtCost.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
