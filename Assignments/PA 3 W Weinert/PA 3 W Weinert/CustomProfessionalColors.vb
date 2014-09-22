Option Strict On

Public Class CustomProfessionalColors
    Inherits ProfessionalColorTable

    Private _color As Color

    'Ideally one would use Hue, Saturation, Value to blend the default Value (Relative brightness)
    'with the _color variable. But alas .net doesn't offer that, so just do a simple average blend.
    Public Shared Function blendColorsAverage(ByVal a As Color, ByVal b As Color) As Color
        Dim avg = Function(x As Integer, y As Integer) (x + y) \ 2

        Return Color.FromArgb(red:=avg(a.R, b.R),
                              green:=avg(a.G, b.G),
                              blue:=avg(a.B, b.B))
    End Function

    Public Sub New(ByVal c As Color)
        _color = c
    End Sub

    Public Overrides ReadOnly Property MenuStripGradientBegin As Color
        Get
            Return blendColorsAverage(MyBase.MenuStripGradientBegin, _color)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuStripGradientEnd As Color
        Get
            Return blendColorsAverage(MyBase.MenuStripGradientEnd, _color)
        End Get
    End Property

End Class
