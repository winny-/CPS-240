Option Strict On

Imports PA_3_W_Weinert.HSVColor

Public Class CustomProfessionalColors
    Inherits ProfessionalColorTable

    Private _color As Color

    Public Shared Function blendColorValues(ByVal base As Color, ByVal other As Color) As Color
        Dim c As HSVColor = New HSVColor(base)
        c.Value = (c.Value + (New HSVColor(other)).Value) / 2
        Return c.ARGB
    End Function

    Public Sub New(ByVal c As Color)
        _color = c
    End Sub

    Public Overrides ReadOnly Property MenuStripGradientBegin As Color
        Get
            Return blendColorValues(_color, Color.Gray)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuStripGradientEnd As Color
        Get
            Return blendColorValues(_color, Color.White)
        End Get
    End Property

End Class
