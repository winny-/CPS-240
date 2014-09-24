Option Strict On

''' <summary>
''' Work with Colors in terms of Hue, Saturation, and Value
''' </summary>
Public Class HSVColor

    ''' <summary>
    ''' The color itself
    ''' </summary>
    ''' <remarks>Ranges from 0 to 360 degrees.</remarks>
    Public Hue As Double

    ''' <summary>
    ''' Intesity of the Hue
    ''' </summary>
    ''' <remarks>
    ''' Ranges from 0 to 1. 0 will result in no color, e.g. white, and
    ''' everything greater will have more color strength.
    ''' </remarks>
    Public Saturation As Double

    ''' <summary>
    ''' Relative brightness of the color
    ''' </summary>
    ''' <remarks>Ranges from 0 to 1. 0 is complete darkness and 1 is full color brightness.</remarks>
    Public Value As Double

    Public Sub New()
        'Intentionally left blank.
    End Sub

    Public Sub New(ByVal c As Color)
        colorToHSV(c, Hue, Saturation, Value)
    End Sub

    Public Sub New(ByVal hue As Double, ByVal saturation As Double, ByVal value As Double)
        Me.Hue = hue
        Me.Saturation = saturation
        Me.Value = value
    End Sub

    Public ReadOnly Property RGB As Color
        Get
            Return colorFromHSV_blackbox(Hue, Saturation, Value)
        End Get
    End Property

    '*************************
    'Color to/from HSV helpers
    '*************************

    'Derived from https://stackoverflow.com/questions/359612/how-to-change-rgb-color-to-hsv
    Public Shared Sub colorToHSV(ByVal c As Color, ByRef hue As Double, ByRef saturation As Double, ByRef value As Double)
        Dim max As Integer = Math.Max(c.R, Math.Max(c.G, c.B))
        Dim min As Integer = Math.Min(c.R, Math.Min(c.G, c.B))

        'Yeah, we're cheating.
        hue = c.GetHue()
        'If there is no color, e.g. #000, saturation is said to be 0, which makes for an achromatic, gray color.
        'Otherwise make an flipped ratio of the strongest color over the weakest color.
        saturation = If(max = 0, 0, 1.0# - (CDbl(min) / max))
        'Value, the relative lightness/darkness of a color is the strongest color over 255 to make a ratio.
        value = max / 255.0#
    End Sub

    'Derived from the same StackOverflow link.
    Public Shared Function colorFromHSV_blackbox(ByVal hue As Double, ByVal saturation As Double, ByVal value As Double) As Color
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

    'Written from scratch with some help from the math formulas: https://en.wikipedia.org/wiki/HSL_and_HSV#From_HSV
    Public Shared Function colorFromHSV(ByVal hue As Double, ByVal saturation As Double, ByVal value As Double) As Color
        Dim chroma As Double = value * saturation
        Dim hPrime As Double = hue / 60
        Dim x As Double = chroma * (1 - Math.Abs(hPrime Mod 2 - 1))
        Dim r_, g_, b_ As Double

        If Not Double.IsNaN(hue) Then
            Select hPrime
                Case Is < 0
                    Debug.Fail("Bad color")
                Case Is < 1
                    r_ = chroma
                    g_ = x
                    b_ = 0.0#
                Case Is < 2
                    r_ = x
                    g_ = chroma
                    b_ = 0.0#
                Case Is < 3
                    r_ = 0.0#
                    g_ = chroma
                    b_ = x
                Case Is < 4
                    r_ = 0.0#
                    g_ = x
                    b_ = chroma
                Case Is < 5
                    r_ = x
                    g_ = 0.0#
                    b_ = chroma
                Case Is < 6
                    r_ = chroma
                    g_ = 0.0#
                    b_ = x
                Case Else
                    Debug.Fail("Bad color")
            End Select
        End If

        Dim m As Double = value - chroma
        Dim r As Integer = CInt((r_ + m) * 255)
        Dim g As Integer = CInt((g_ + m) * 255)
        Dim b As Integer = CInt((b_ + m) * 255)

        Return Color.FromArgb(255, r, g, b)
    End Function

End Class
