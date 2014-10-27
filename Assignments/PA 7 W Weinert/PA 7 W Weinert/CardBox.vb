Option Strict On

Public Class CardBox
    Inherits PictureBox

    Public Property Card As Card

    Public Sub New(card As Card)
        Me.SizeMode = PictureBoxSizeMode.Zoom
        Me.Card = card
        Me.Card.CardBox = Me
        Me.Image = Decks.DefaultBack
    End Sub

End Class
