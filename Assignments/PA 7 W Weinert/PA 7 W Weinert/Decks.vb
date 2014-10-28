Option Strict On

Imports System.Text.RegularExpressions

Public Class Decks

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

    Public Shared ReadOnly DefaultDeck As List(Of Card) = Birds

    Public Shared ReadOnly Property Test As List(Of Card)
        Get
            Return CardsMatchingName("green_")
        End Get
    End Property

    Public Shared ReadOnly Property ChessAll As List(Of Card)
        Get
            Return CardsMatchingName("_black").Extend(CardsMatchingName("_white"))
        End Get
    End Property

    Public Shared ReadOnly Property ChessBlack As List(Of Card)
        Get
            Return CardsMatchingName("_black")
        End Get
    End Property

    Public Shared ReadOnly Property ChessWhite As List(Of Card)
        Get
            Return CardsMatchingName("_white")
        End Get
    End Property

    Public Shared ReadOnly Property Birds As List(Of Card)
        Get
            Return CardsMatchingName("birds")
        End Get
    End Property

    Public Shared ReadOnly Property Renders As List(Of Card)
        Get
            Return CardsMatchingName("_render")
        End Get
    End Property

    Public Shared ReadOnly Property AllDecks As Dictionary(Of String, List(Of Card))
        Get
            Dim d As New Dictionary(Of String, List(Of Card))
            d.Add("Half Chess suite", ChessBlack)
            d.Add("Test (small)", Test)
            d.Add("Birds", Birds)
            d.Add("Renders", Renders)
            d.Add("Everything", d.Values.SelectMany(Function(L As List(Of Card)) L).ToList())
            d.Add("Full Chess suite", ChessAll)
            Return d
        End Get
    End Property

End Class
