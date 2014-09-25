Option Strict On

Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PA_3_W_Weinert

Public Class ColorPair

    Public Color As Drawing.Color
    Public Hue, Saturation, Value As Double
    Public Precsion As Integer = 3

    Public Sub New(ByVal color As Drawing.Color, ByVal hue As Double, ByVal saturation As Double, ByVal value As Double)
        Me.Color = color
        Me.Hue = hue
        Me.Saturation = saturation
        Me.Value = value
    End Sub

    Public Sub New(ByVal color As Drawing.Color, ByVal hue As Double, ByVal saturation As Double, ByVal value As Double, ByVal precision As Integer)
        Me.New(color, hue, saturation, value)
        Me.Precsion = precision
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("RGB={0} {1}", ColorToString(Color), New HSVColor(Hue, Saturation, Value).ToString)
    End Function

    Public Shared Function ColorToString(ByVal c As Drawing.Color) As String
        Return String.Format("#{0:x2}{1:x2}{2:x2})", c.R, c.G, c.B)
    End Function

End Class

<TestClass()> Public Class HSVColorTest

    Private colors As List(Of ColorPair)

    Sub New()
        MyBase.New()

        colors = New List(Of ColorPair)

        colors.Add(New ColorPair(Drawing.Color.Black, 0, 0, 0))
        colors.Add(New ColorPair(Drawing.Color.White, 0, 0, 1))
        colors.Add(New ColorPair(Drawing.Color.Red, 0, 1, 1))
        colors.Add(New ColorPair(Drawing.Color.FromArgb(0, 255, 0), 120, 1, 1)) 'Saturated Green
        colors.Add(New ColorPair(Drawing.Color.FromArgb(0, 0, 255), 240, 1, 1)) 'Saturated Blue
        colors.Add(New ColorPair(Drawing.Color.Gray, 0, 0, 0.5, 1))
        colors.Add(New ColorPair(Drawing.Color.FromArgb(191, 191, 0), 60, 1, 0.75, 2)) 'Leaf Green
        colors.Add(New ColorPair(Drawing.Color.FromArgb(128, 128, 255), 240, 0.5, 1, 1)) 'Violet
    End Sub

    'This is necessary because Drawing.Color.Black <> Drawing.Color.fromARGB(255, 0, 0, 0).
    'That's right, the built in colors do not have an alpha channel though both return 255 and is readonly.
    Public Shared Function equalRGB(ByVal a As Drawing.Color, ByVal b As Drawing.Color) As Boolean
        Return a.R = b.R AndAlso a.G = b.G AndAlso a.B = b.B
    End Function

    <TestMethod()> Public Sub TestColorToHSV()
        For Each c In colors
            Dim h, s, v As Double
            HSVColor.colorToHSV(c.color, h, s, v)
            Assert.AreEqual(Math.Round(h, c.Precsion), c.Hue, c.ToString)
            Assert.AreEqual(Math.Round(s, c.Precsion), c.Saturation, c.ToString)
            Assert.AreEqual(Math.Round(v, c.Precsion), c.Value, c.ToString)
        Next
    End Sub

    <TestMethod()> Public Sub TestColorFromHSV()
        For Each c In colors
            Dim rgb As Drawing.Color = HSVColor.colorFromHSV(c.Hue, c.Saturation, c.Value)
            Assert.IsTrue(equalRGB(rgb, c.Color), c.ToString & " <> " & rgb.ToString)
        Next
    End Sub

    <TestMethod()> Public Sub TestColorFromHSV_blackbox()
        For Each c In colors
            Dim rgb As Drawing.Color = HSVColor.colorFromHSV_blackbox(c.Hue, c.Saturation, c.Value)
            Assert.IsTrue(equalRGB(rgb, c.Color), c.ToString & " <> " & rgb.ToString)
        Next
    End Sub

    <TestMethod()> Public Sub TestNew()
        Dim c As HSVColor = New HSVColor()

        Assert.AreEqual(c.Hue, 0.0#)
        Assert.AreEqual(c.Saturation, 0.0#)
        Assert.AreEqual(c.Value, 0.0#)
        Assert.IsTrue(equalRGB(c.RGB, Drawing.Color.Black), c.ToString & " <> " & Drawing.Color.Black.ToString)
    End Sub

    <TestMethod()> Public Sub TestNewFromColor()
        For Each c In colors
            Dim hsv As HSVColor = New HSVColor(c.Color)
            Assert.AreEqual(Math.Round(hsv.Hue, c.Precsion), c.Hue, c.ToString)
            Assert.AreEqual(Math.Round(hsv.Saturation, c.Precsion), c.Saturation, c.ToString)
            Assert.AreEqual(Math.Round(hsv.Value, c.Precsion), c.Value, c.ToString)
            Assert.IsTrue(equalRGB(c.Color, hsv.RGB), c.ToString & " <> " & hsv.RGB.ToString)
        Next
    End Sub

    <TestMethod()> Public Sub TestNewFromHSV()
        For Each c In colors
            Dim hsv As HSVColor = New HSVColor(c.Hue, c.Saturation, c.Value)
            Assert.AreEqual(c.Hue, hsv.Hue)
            Assert.AreEqual(c.Saturation, hsv.Saturation)
            Assert.AreEqual(c.Value, hsv.Value)
            Assert.IsTrue(equalRGB(hsv.RGB, c.Color), c.ToString & " <> " & hsv.RGB.ToString)
        Next
    End Sub

End Class