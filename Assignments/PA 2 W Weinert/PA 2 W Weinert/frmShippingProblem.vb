'*****************************************************************
'PA 2: The Shipping Problem
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Imports PA_2_W_Weinert.USCustomaryWeight

Public Class frmShippingProblem

    Private Const SHIPPING_RATE As Decimal = 0.12D 'Per ounce
    Private Const SHIPPING_ID_FORMAT As String = "AWB{0:D2}"
    Private Const SHIPMENT_SUMMARY_FORMAT As String = "{0} {1} {2:C}"

    Private Enum LogicalEventType
        Calculate
        LiveUpdate
    End Enum

    '********************
    'Helpers
    '********************

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

    '********************
    'UI Helpers
    '********************

    Private Sub updateUI(ByVal type As LogicalEventType)
        Dim weight As USCustomaryWeight
        Dim cost As Decimal

        weight = parseWeight(type)
        If weight Is Nothing Then Return
        cost = CDec(weight.TotalOunces) * SHIPPING_RATE
        txtCost.Text = cost.ToString("C")

        'On TextChanged, Return now, so we don't add the input to the totals and list box.
        If type <> LogicalEventType.Calculate Then Return

        addShipmentToSummary(weight, cost)

        makeNextID()
    End Sub

    Private Sub makeNextID()
        Static ShippingID As Integer

        ShippingID += 1

        txtID.Text = String.Format(SHIPPING_ID_FORMAT, ShippingID)
    End Sub

    Private Function parseWeight(ByVal type As LogicalEventType) As USCustomaryWeight
        Dim poundsValid, ouncesValid As Boolean
        Dim bothMeasuresAreEmptyOrZero As Boolean
        Dim pounds, ounces As Integer

        poundsValid = parseInteger(txtPounds.Text, pounds)
        ouncesValid = parseInteger(txtOunces.Text, ounces)
        bothMeasuresAreEmptyOrZero = (txtPounds.Text = "" OrElse pounds = 0) AndAlso (txtOunces.Text = "" OrElse ounces = 0)

        If type = LogicalEventType.LiveUpdate AndAlso bothMeasuresAreEmptyOrZero Then Return Nothing

        If Not poundsValid OrElse Not ouncesValid OrElse bothMeasuresAreEmptyOrZero Then
            Dim errorMessages As List(Of String) = New List(Of String)

            If Not poundsValid Then errorMessages.Add(String.Format("Invalid pounds input ""{0}"".", txtPounds.Text))
            If Not ouncesValid Then errorMessages.Add(String.Format("Invalid ounces input ""{0}"".", txtOunces.Text))
            If bothMeasuresAreEmptyOrZero Then errorMessages.Add("Weight input (lb. and/or oz.) is required.")
            errorMessages.Add("Please input positive, whole numbers.")

            MessageBox.Show(text:=String.Join(" ", errorMessages),
                caption:="Error: invalid input",
                buttons:=MessageBoxButtons.OK,
                icon:=MessageBoxIcon.Error)
            Return Nothing
        End If

        Return New USCustomaryWeight(pounds, ounces)
    End Function

    Private Sub addShipmentToSummary(ByVal weight As USCustomaryWeight, ByVal cost As Decimal)
        Static totalWeight As USCustomaryWeight = New USCustomaryWeight()
        Static totalCost As Decimal

        lstSummary.Items.Add(String.Format(SHIPMENT_SUMMARY_FORMAT, txtID.Text, weight, cost))

        totalCost += cost
        totalWeight += weight

        txtTotalCost.Text = totalCost.ToString("C")
        txtTotalWeight.Text = totalWeight.ToString
    End Sub

    '********************
    'Event Handlers
    '********************

    Private Sub frmShippingProblem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeNextID()
    End Sub

    Private Sub txtPoundsOrtxtOunces_TextChanged(sender As Object, e As EventArgs) Handles txtPounds.TextChanged, txtOunces.TextChanged
        txtCost.Clear()
        If chkLiveUpdate.Checked Then updateUI(LogicalEventType.LiveUpdate)
    End Sub

    Private Sub btnCanculate_Click(sender As Object, e As EventArgs) Handles btnCanculate.Click
        updateUI(LogicalEventType.Calculate)
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
