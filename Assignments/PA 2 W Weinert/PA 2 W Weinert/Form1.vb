﻿'*****************************************************************
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

    ''' <summary>
    ''' Integer.TryParse(String, Integer) wrapper
    ''' </summary>
    ''' <param name="s">String to parse an Integer from</param>
    ''' <param name="dest">Destination for the parsed Integer</param>
    ''' <returns>Boolean indicating success of the operation</returns>
    ''' <remarks>
    ''' This Function takes care not to overwrite dest if the operation failed.
    ''' 
    ''' The following Strings are valid:
    ''' 1234
    ''' String.Empty is 0
    ''' 
    ''' All negative numbers are invalid
    ''' </remarks>
    Private Function parseInteger(ByVal s As String, ByRef dest As Integer) As Boolean
        Dim valid As Boolean
        Dim tmp As Integer

        If s = "" Then
            dest = 0
            Return True
        End If

        valid = Integer.TryParse(s, tmp) AndAlso tmp >= 0
        If valid Then dest = tmp
        Return valid
    End Function

    Private Sub frmShippingProblem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeNextID()
    End Sub

    'Since the project requires no Class-level variables, the simplest way to implement
    'a live update in to use one subroutine to fire for both the calculate button and
    'the text changed events.
    Private Sub updateUI(sender As Object, e As EventArgs) Handles txtPounds.TextChanged, txtOunces.TextChanged, btnCanculate.Click
        txtCost.Clear()
        If sender IsNot btnCanculate AndAlso Not chkLiveUpdate.Checked Then Return

        Dim poundsValid, ouncesValid As Boolean
        Dim bothMeasuresAreEmpty As Boolean
        Dim pounds, ounces As Integer

        Static totalWeight As Weight = New Weight()
        Dim inputtedWeight As Weight

        Static totalCost As Decimal
        Dim cost As Decimal

        poundsValid = parseInteger(txtPounds.Text, pounds)
        ouncesValid = parseInteger(txtOunces.Text, ounces)
        bothMeasuresAreEmpty = txtPounds.Text = "" AndAlso txtOunces.Text = ""

        If Not poundsValid OrElse Not ouncesValid OrElse bothMeasuresAreEmpty Then
            Dim errorMessages As List(Of String) = New List(Of String)

            If Not poundsValid Then errorMessages.Add(String.Format("Invalid pounds input ""{0}"".", txtPounds.Text))
            If Not ouncesValid Then errorMessages.Add(String.Format("Invalid ounces input ""{0}"".", txtOunces.Text))
            If bothMeasuresAreEmpty Then errorMessages.Add("Weight input (lb. and/or oz.) is required.")
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

        If sender IsNot btnCanculate Then Return

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
