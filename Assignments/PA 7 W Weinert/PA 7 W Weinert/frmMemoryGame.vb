'*****************************************************************
'PA 7: Memory Game
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Public Class frmMemoryGame

    Private Delegate_ As New AppDelegate()

    Private Sub frmMemoryGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStats()
    End Sub

    Private Sub mgcMemoryGame_GameFinished() Handles mgcMemoryGame.GameFinished
        btnNewGame.Enabled = True
        btnChangeDeck.Enabled = True
        Delegate_.GameWasFinished()
        DisplayStats()
    End Sub

    Private Sub btnChangeDeck_Click(sender As Object, e As EventArgs) Handles btnChangeDeck.Click
        Delegate_.Deck = frmChangeDeck.ChooseNewDeck(defaultDeck:=Delegate_.Deck)
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Delegate_.GameWasStarted()
        btnNewGame.Enabled = False
        btnChangeDeck.Enabled = False
        mgcMemoryGame.Deck = Delegate_.Deck
        mgcMemoryGame.CreateGameLayout()
        DisplayStats()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DisplayStats()
        Dim ifElseEmpty As Func(Of Boolean, String, String) = Function(cond As Boolean, s As String) If(cond, s, String.Empty)

        Dim avg As Double = Delegate_.AverageMisses
        tsslAverageMisses.Text = ifElseEmpty(avg > -1,
                                             String.Format("Average misses: {0:F2}", avg))

        tsslMissesThisGame.Text = ifElseEmpty(Delegate_.InGame,
                                              String.Format("Misses this game: {0:D}", Delegate_.Misses))

        tsslGames.Text = ifElseEmpty(Delegate_.GameCount > 0 Or Delegate_.InGame,
                                     String.Format("Games: {0:D}", Delegate_.GameCount + Delegate_.InGame.ToBinary))
    End Sub


    Private Sub mgcMemoryGame_PairWasMiss() Handles mgcMemoryGame.PairWasMiss
        Delegate_.CardWasMiss()
        DisplayStats()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim f As New frmAbout()
        f.ShowDialog()
    End Sub

End Class
