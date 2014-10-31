Option Strict On

Public Class CardBox
    Inherits PictureBox

    Public Const CardHeight As Integer = 150
    Public Const CardWidth As Integer = 150

    Public Property Card As Card

    Public Sub New(card As Card)
        Me.SizeMode = PictureBoxSizeMode.Zoom
        Me.Card = card
        Me.Card.CardBox = Me
        Me.Image = DeckUtility.DefaultBack
        Me.Size = New Drawing.Size With {.Height = CardHeight,
                                         .Width = CardWidth}
    End Sub

End Class
