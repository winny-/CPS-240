Option Strict On

''' <summary>
''' Work with Colors in terms of Hue, Saturation, and Value
''' </summary>
Public Class HSVColor

    ''' <summary>
    ''' The color itself
    ''' </summary>
    Public Hue As Double
    ''' <summary>
    ''' Intesity of the Hue
    ''' </summary>
    Public Saturation As Double
    ''' <summary>
    ''' Relative brightness of the color
    ''' </summary>
    Public Value As Double

    Public Sub New()
        'Intentionally left blank.
    End Sub

    Public Sub New(ByVal c As Color)
        colorToHSV(c, Hue, Saturation, Value)
    End Sub

    Public ReadOnly Property ARGB As Color
        Get
            Return colorFromHSV(Hue, Saturation, Value)
        End Get
    End Property

    '*************************
    'Color to/from HSV helpers
    '*************************

    'Derived from https://stackoverflow.com/questions/359612/how-to-change-rgb-color-to-hsv
    Public Shared Sub colorToHSV(ByVal c As Color, ByRef hue As Double, ByRef saturation As Double, ByRef value As Double)
        Dim max As Integer = Math.Max(c.R, Math.Max(c.G, c.B))
        Dim min As Integer = Math.Min(c.R, Math.Min(c.G, c.B))

        hue = c.GetHue()
        saturation = If(max = 0, 0, 1D - (1D * min / max))
        value = max / 255D
    End Sub

    Public Shared Function colorFromHSV(ByVal hue As Double, ByVal saturation As Double, ByVal value As Double) As Color
        Dim hi As Integer = CInt(Math.Floor(hue / 60)) Mod 6
        Dim f As Double = hue / 60 - Math.Floor(hue / 60)

        value = value * 255
        Dim v As Integer = CInt(value)
        Dim p As Integer = CInt(value * (1 - saturation))
        Dim q As Integer = CInt(value * (1 - f * saturation))
        Dim t As Integer = CInt(value * (1 - (1 - f) * saturation))

        Select Case hi
            Case 0
                Return Color.FromArgb(255, v, t, p)
            Case 1
                Return Color.FromArgb(255, q, v, p)
            Case 2
                Return Color.FromArgb(255, p, v, t)
            Case 3
                Return Color.FromArgb(255, p, q, v)
            Case 4
                Return Color.FromArgb(255, t, p, v)
            Case Else
                Return Color.FromArgb(255, v, p, q)
        End Select
    End Function

End Class
