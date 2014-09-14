Option Strict On

''' <summary>
''' Class to deal with US customary weights
''' </summary>
''' <remarks>
''' Please note, this class is immutable and any operators will return a new instance.
''' </remarks>
Public Class USCustomaryWeight
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

    Public Shared Function TryParse(ByVal s As String, ByRef weight As USCustomaryWeight) As Boolean
        Dim parts As String() = s.Trim.Split(" "c)
        If parts.Count() <> 4 Then Return False

        Dim oz, lb As Integer
        If Integer.TryParse(parts(0), lb) AndAlso Integer.TryParse(parts(2), oz) Then
            Try
                weight = New USCustomaryWeight(lb, oz)
                Return True
            Catch ex As Exception

            End Try
        End If

        Return False
    End Function

    Public Overrides Function ToString() As String
        Return String.Format(TO_STRING_FORMAT, Pounds, Ounces)
    End Function

    Public Shared Operator +(ByVal a As USCustomaryWeight, ByVal b As USCustomaryWeight) As USCustomaryWeight
        Return New USCustomaryWeight(a.TotalOunces + b.TotalOunces)
    End Operator

    Public Shared Operator -(ByVal a As USCustomaryWeight) As USCustomaryWeight
        Return New USCustomaryWeight(-a.TotalOunces)
    End Operator
End Class
