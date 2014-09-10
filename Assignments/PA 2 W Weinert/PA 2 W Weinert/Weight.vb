Option Strict On

''' <summary>
''' Class to deal with US customary weights
''' </summary>
''' <remarks>
''' Please note, this class is immutable and any operators will return a new instance.
''' </remarks>
Public Class Weight
    Private Const TO_STRING_FORMAT As String = "{0} lb. {1} oz."
    Private Const OUNCES_IN_A_POUND As Integer = 16

    Private _ounces As Integer

    Public Sub New()
        _ounces = 0
    End Sub

    Public Sub New(ByVal ounces As Integer)
        _ounces = ounces
    End Sub

    Public Sub New(ByVal pounds As Integer, ByVal ounces As Integer)
        _ounces = pounds * OUNCES_IN_A_POUND + ounces
    End Sub

    Public ReadOnly Property Ounces() As Integer
        Get
            Return _ounces Mod OUNCES_IN_A_POUND
        End Get
    End Property

    Public ReadOnly Property Pounds() As Integer
        Get
            Return _ounces \ OUNCES_IN_A_POUND
        End Get
    End Property

    Public ReadOnly Property TotalOunces() As Integer
        Get
            Return _ounces
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format(TO_STRING_FORMAT, Pounds, Ounces)
    End Function

    Public Shared Operator +(ByVal a As Weight, ByVal b As Weight) As Weight
        Return New Weight(a.TotalOunces + b.TotalOunces)
    End Operator
End Class
