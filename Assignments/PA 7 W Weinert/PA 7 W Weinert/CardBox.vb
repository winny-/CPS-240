Option Strict On

Public Class CardBox
    Inherits PictureBox

    Public Property Card As Card

    Public Sub New(card As Card)
        Me.SizeMode = PictureBoxSizeMode.Zoom
        Me.Card = card
        Me.Card.CardBox = Me
        Me.Image = DeckUtility.DefaultBack
        Me.Size = New Drawing.Size With {.Height = 150, .Width = 150}
    End Sub

End Class
