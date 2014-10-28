Option Strict On

Public Class MemoryGameControl

    Public Enum RevealedState
        Match
        Miss
        FirstUp
        None
    End Enum

    Public Event PairWasMiss()
    Public Event CardWasRevealed(ByVal c As Card, ByVal s As RevealedState)
    Public Event GameFinished()

    Public Property Deck As DeckUtility.Deck
    Private Property WorkingDeck As List(Of Card)
    Private Property AutomaticallyHidingGuesses As Boolean
        Get
            Return Timer1.Enabled
        End Get
        Set(value As Boolean)
            Timer1.Enabled = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Deck = Nothing
        Me.AutomaticallyHidingGuesses = False
    End Sub

    Public Sub New(ByVal deck As DeckUtility.Deck)
        Me.New()

        Me.Deck = deck
    End Sub

    Public Sub CreateGameLayout(Optional ByVal presentationMode As Boolean = False)
        WorkingDeck = New List(Of Card)(Deck.Cards)
        If Not presentationMode Then
            WorkingDeck = WorkingDeck.SelectMany(Function(c As Card) {c.Clone(), c.Clone()}).ToList()
            WorkingDeck.Shuffle()
        End If

        Board.Controls.Clear()
        For Each c As Card In WorkingDeck
            Dim cb As New CardBox(c)
            If presentationMode Then
                cb.Image = c.Face
                c.CurrentState = Card.State.Matched
            End If
            AddHandler cb.Click, AddressOf CardWasClicked
            Board.Controls.Add(cb)
        Next
    End Sub

    Private Sub CardWasClicked(sender As Object, e As EventArgs)
        Dim clicked As CardBox = CType(sender, CardBox)
        Dim guessCount As Integer = GuessedCards().Count
        Dim isFaceDown As Boolean = clicked.Card.CurrentState = Card.State.FaceDown
        Dim r As RevealedState = RevealedState.None
        Select Case guessCount
            Case Is > 1
                AutomaticallyHidingGuesses = False
                For Each c As Card In GuessedCards()
                    c.CurrentState = Card.State.FaceDown
                    c.CardBox.Image = DeckUtility.DefaultBack
                Next
            Case 1
                If isFaceDown Then
                    Dim other As Card = GuessedCards(WithoutCard:=clicked.Card).Single
                    clicked.Card.CurrentState = Card.State.Guess
                    clicked.Image = clicked.Card.Face
                    r = RevealedState.Miss
                    If other.Name = clicked.Card.Name Then
                        other.CurrentState = Card.State.Matched
                        clicked.Card.CurrentState = Card.State.Matched
                        r = RevealedState.Match
                    End If
                End If
            Case 0
                If isFaceDown Then
                    clicked.Card.CurrentState = Card.State.Guess
                    clicked.Image = clicked.Card.Face
                    r = RevealedState.FirstUp
                End If
        End Select
        If r <> RevealedState.None Then
            RaiseEvent CardWasRevealed(clicked.Card, r)
            If r = RevealedState.Miss Then
                RaiseEvent PairWasMiss()
                AutomaticallyHidingGuesses = True
            End If
            If FaceDownCards().Count = 0 And r = RevealedState.Match Then RaiseEvent GameFinished()
        End If
    End Sub

    Private Function GuessedCards(Optional ByVal WithoutCard As Card = Nothing) As List(Of Card)
        Return (From c In WorkingDeck Where c.CurrentState = Card.State.Guess And c IsNot WithoutCard).ToList()
    End Function

    Private Function FaceDownCards() As List(Of Card)
        Return (From c In WorkingDeck Where c.CurrentState = Card.State.FaceDown).ToList()
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If AutomaticallyHidingGuesses Then
            ClearGuessed()
            AutomaticallyHidingGuesses = False
        End If
    End Sub

    Private Sub ClearGuessed()
        GuessedCards.ForEach(Sub(c As Card)
                                 c.CurrentState = Card.State.FaceDown
                                 c.CardBox.Image = DeckUtility.DefaultBack
                             End Sub)
    End Sub

    Public Sub ShowDeckInPresentationMode(Optional ByVal deck As DeckUtility.Deck = Nothing)
        If deck.Cards IsNot Nothing Then Me.Deck = deck
        CreateGameLayout(presentationMode:=True)
    End Sub

End Class
