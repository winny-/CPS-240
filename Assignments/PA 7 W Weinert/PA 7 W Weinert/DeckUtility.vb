Option Strict On

Imports System.Collections.Generic
Imports System.Globalization

Public Class DeckUtility

    Public Structure Deck
        Public Name As String
        Public Cards As List(Of Card)
    End Structure

    Public Shared Function ImagesMatchingName(name As String) As Dictionary(Of String, Image)
        Dim runTimeResourceSet As Resources.ResourceSet
        Dim dictEntry As DictionaryEntry
        Dim pattern As String = "*" & name & "*"
        Dim d As New Dictionary(Of String, Image)

        runTimeResourceSet = My.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, False, True)
        For Each dictEntry In runTimeResourceSet
            Dim keyString As String = CStr(dictEntry.Key)
            If dictEntry.Value.GetType() Is GetType(Drawing.Bitmap) AndAlso keyString Like pattern Then
                d.Add(keyString, CType(dictEntry.Value, Image))
            End If
        Next
        Return d
    End Function

    Public Shared Function CardsMatchingName(name As String) As List(Of Card)
        Dim L As New List(Of Card)
        For Each e As KeyValuePair(Of String, Image) In ImagesMatchingName(name)
            L.Add(New Card(e.Value, e.Key))
        Next
        Return L
    End Function

    Public Shared Function CloneCards(cards As List(Of Card)) As List(Of Card)
        Return cards.Select(Function(c As Card) c.Clone()).ToList()
    End Function

    Public Shared ReadOnly DefaultBack As Image = My.Resources.line_segments_no__1_by_dazzling_rust_d4ajcpm

    Public Shared ReadOnly DefaultDeck As Deck = Renders

    Public Shared ReadOnly Property Flowers As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("_flower"),
                                  .Name = "Flowers (small)"}
        End Get
    End Property

    Public Shared ReadOnly Property ChessAll As Deck
        Get
            Return New Deck With {.Cards = ChessWhite.Cards.Extend(ChessBlack.Cards),
                                  .Name = "Full chess suite"}
        End Get
    End Property

    Public Shared ReadOnly Property ChessBlack As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("_black"),
                                  .Name = "Chess (black)"}
        End Get
    End Property

    Public Shared ReadOnly Property ChessWhite As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("_white"),
                                  .Name = "Chess (white)"}
        End Get
    End Property

    Public Shared ReadOnly Property Birds As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("birds"),
                                  .Name = "Birds"}
        End Get
    End Property

    Public Shared ReadOnly Property Renders As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("_render"),
                                  .Name = "Computer Renders"}
        End Get
    End Property

    Public Shared ReadOnly Property AllDecks As List(Of Deck)
        Get
            Return New List(Of Deck)({ChessBlack,
                                      ChessWhite,
                                      Flowers,
                                      Birds,
                                      Renders,
                                      ChessAll})
        End Get
    End Property

End Class
