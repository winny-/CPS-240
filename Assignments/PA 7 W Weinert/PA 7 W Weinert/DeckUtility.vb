Option Strict On

Imports System.Text.RegularExpressions

Public Class DeckUtility

    Public Structure Deck
        Public Name As String
        Public Cards As List(Of Card)
    End Structure

    Public Shared Function ImagesMatchingName(name As String) As Dictionary(Of String, Image)
        Dim runTimeResourceSet As Resources.ResourceSet
        Dim dictEntry As DictionaryEntry
        Dim r As New Regex(".*" & Regex.Escape(name) & ".*")
        Dim d As New Dictionary(Of String, Image)

        runTimeResourceSet = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, False, True)
        For Each dictEntry In runTimeResourceSet
            If dictEntry.Value.GetType() Is GetType(Drawing.Bitmap) AndAlso r.IsMatch(CStr(dictEntry.Key)) Then
                d.Add(CStr(dictEntry.Key), CType(dictEntry.Value, Image))
            End If
        Next
        Return d
    End Function

    Public Shared Function CardsMatchingName(name As String) As List(Of Card)
        Dim L As New List(Of Card)
        For Each e As System.Collections.Generic.KeyValuePair(Of String, Image) In ImagesMatchingName(name)
            L.Add(New Card(e.Value, e.Key))
        Next
        Return L
    End Function

    Public Shared ReadOnly DefaultBack As Image = My.Resources.cardback1

    Public Shared ReadOnly DefaultDeck As Deck = Birds

    Public Shared ReadOnly Property Test As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("green_"), .Name = "Test (small)"}
        End Get
    End Property

    Public Shared ReadOnly Property ChessAll As Deck
        Get
            Return New Deck With {.Cards = ChessWhite.Cards.Extend(ChessBlack.Cards), .Name = "Full chess suite"}
        End Get
    End Property

    Public Shared ReadOnly Property ChessBlack As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("_black"), .Name = "Chess (black)"}
        End Get
    End Property

    Public Shared ReadOnly Property ChessWhite As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("_white"), .Name = "Chess (white)"}
        End Get
    End Property

    Public Shared ReadOnly Property Birds As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("birds"), .Name = "Birds"}
        End Get
    End Property

    Public Shared ReadOnly Property Renders As Deck
        Get
            Return New Deck With {.Cards = CardsMatchingName("_render"), .Name = "Computer Renders"}
        End Get
    End Property

    Public Shared ReadOnly Property AllDecks As List(Of Deck)
        Get
            Dim L As New List(Of Deck)
            L.Add(ChessBlack)
            L.Add(ChessWhite)
            L.Add(Test)
            L.Add(Birds)
            L.Add(Renders)
            L.Add(ChessAll)
            Return L
        End Get
    End Property

End Class
