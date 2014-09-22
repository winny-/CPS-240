Option Strict On

Public Class CustomProfessionalColors
    Inherits ProfessionalColorTable

    Private _color As Color

    Public Sub New(ByVal c As Color)
        _color = c
    End Sub

    Public Overrides ReadOnly Property ToolStripContentPanelGradientBegin As Color
        Get
            Return _color
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientMiddle As Color
        Get
            Return MyBase.ToolStripGradientMiddle
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientEnd As Color
        Get
            Return MyBase.ToolStripGradientEnd
        End Get
    End Property

    Public Overrides ReadOnly Property MenuStripGradientBegin As Color
        Get
            Return _color
        End Get
    End Property

    Public Overrides ReadOnly Property MenuStripGradientEnd As Color
        Get
            Return MyBase.MenuStripGradientEnd
        End Get
    End Property

End Class
