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
        Dim L As List(Of String) = (From d As DeckUtility.Deck In f.Decks
                                    Select d.Name
                                    Order By Name Ascending).ToList()

        f.cbDeckChoices.Items.Clear()
        L.ForEach(Sub(s As String) f.cbDeckChoices.Items.Add(s))
        f.cbDeckChoices.SelectedItem = If(defaultDeck.Cards IsNot Nothing,
                                          defaultDeck.Name,
                                          f.Decks(0).Name)

        f.ShowDialog()

        Return If(f.ChangeDeckWasClicked,
                  f.SelectedDeck,
                  defaultDeck)
    End Function

    Private Sub cbDeckChoices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDeckChoices.SelectedIndexChanged
        SelectedDeck = (From d As DeckUtility.Deck In Decks
                        Where d.Name = cbDeckChoices.SelectedItem.ToString).Single
        mgcDeckViewer.ShowDeckInPresentationMode(SelectedDeck)
    End Sub

    Private Sub ButtonWasClicked(sender As Object, e As EventArgs) Handles _
        btnChange.Click,
        btnCancel.Click

        Me.ChangeDeckWasClicked = sender Is btnChange
        Me.Close()
    End Sub

End Class