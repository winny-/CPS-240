Option Strict On

Public Class frmMemoryGame

    Public Delegate_ As New AppDelegate(MemoryGameControl1)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStats()
    End Sub

    Private Sub MemoryGameControl1_GameFinished() Handles MemoryGameControl1.GameFinished
        btnNewGame.Enabled = True
        btnChangeDeck.Enabled = True
        Delegate_.GameWasFinished()
        DisplayStats()
    End Sub

    Private Sub btnChangeDeck_Click(sender As Object, e As EventArgs) Handles btnChangeDeck.Click
        Dim newDeck As List(Of Card) = frmChangeDeck.ChooseNewDeck()
        If newDeck IsNot Nothing Then Delegate_.Deck = newDeck
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Delegate_.GameWasStarted()
        btnNewGame.Enabled = False
        btnChangeDeck.Enabled = False
        MemoryGameControl1.Deck = Delegate_.Deck
        MemoryGameControl1.CreateGameLayout()
        DisplayStats()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DisplayStats()
        Dim avg As Double = Delegate_.AverageMisses
        tsslAverageMisses.Text = If(avg < 0, "", "Average misses: " & avg.ToString())
        tsslMissesThisGame.Text = If(Delegate_.InGame, "Misses this game: " & Delegate_.Misses, "")
        tsslGames.Text = If(Delegate_.InGame Or Delegate_.GameCount > 0, "Games: " & If(Delegate_.InGame, Delegate_.GameCount + 1, Delegate_.GameCount).ToString, "")
    End Sub

    Private Sub MemoryGameControl1_PairWasMiss() Handles MemoryGameControl1.PairWasMiss
        Delegate_.CardWasMiss()
        DisplayStats()
    End Sub
End Class
