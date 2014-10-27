Option Strict On

Public Class frmChangeDeck

    Private Decks As Dictionary(Of String, List(Of Card))
    Private SelectedDeck As List(Of Card)
    Private ChangeDeckWasClicked As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Decks = PA_7_W_Weinert.Decks.AllDecks
    End Sub

    Public Shared Function ChooseNewDeck(Optional ByVal defaultDeck As List(Of Card) = Nothing) As List(Of Card)
        Dim f As New frmChangeDeck
        Dim l As List(Of String) = f.Decks.Keys.ToList
        l.Sort()
        f.cbDeckChoices.Items.Clear()
        l.ForEach(Function(s As String) f.cbDeckChoices.Items.Add(s))
        f.cbDeckChoices.SelectedIndex = 0

        f.ShowDialog()
        Return If(f.ChangeDeckWasClicked, f.SelectedDeck, defaultDeck)
    End Function

    Private Sub cbDeckChoices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDeckChoices.SelectedIndexChanged
        SelectedDeck = Decks(cbDeckChoices.SelectedItem.ToString)
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