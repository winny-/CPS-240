Option Strict On

Public Class frmChangeDeck

    Private Decks As List(Of DeckUtility.Deck)
    Private SelectedDeck As DeckUtility.Deck
    Private ChangeDeckWasClicked As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Decks = DeckUtility.AllDecks
    End Sub

    Public Shared Function ChooseNewDeck(Optional ByVal defaultDeck As DeckUtility.Deck = Nothing) As DeckUtility.Deck
        Dim f As New frmChangeDeck
        Dim l As List(Of String) = From d As DeckUtility.Deck In f.Decks Select d.Name Order By Name Ascending.ToList()
        f.cbDeckChoices.Items.Clear()
        l.ForEach(Function(s As String) f.cbDeckChoices.Items.Add(s))
        f.cbDeckChoices.SelectedItem = If(defaultDeck.Cards IsNot Nothing, defaultDeck.Name, f.Decks(0).Name)

        f.ShowDialog()
        Return f.SelectedDeck
    End Function

    Private Sub cbDeckChoices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDeckChoices.SelectedIndexChanged
        SelectedDeck = (From d As DeckUtility.Deck In Decks Where d.Name = cbDeckChoices.SelectedItem.ToString).Single
        MemoryGameControl1.ShowDeckInPresentationMode(SelectedDeck)
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ChangeDeckWasClicked = True
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ChangeDeckWasClicked = False
        Me.Close()
    End Sub

End Class