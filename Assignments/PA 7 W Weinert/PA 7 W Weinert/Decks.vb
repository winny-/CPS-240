Option Strict On

Public Class Decks

    Public Shared ReadOnly DefaultBack As Image = My.Resources.cardback1

    Public Shared ReadOnly DefaultDeck As List(Of Card) = Birds

    Public Shared ReadOnly Property Test As List(Of Card)
        Get
            Dim L As New List(Of Card)
            L.Add(New Card(My.Resources.green_a, "green_a"))
            L.Add(New Card(My.Resources.green_b, "green_b"))
            Return L
        End Get
    End Property

    Public Shared ReadOnly Property ChessAll As List(Of Card)
        Get
            Dim L As New List(Of Card)
            Dim c As Integer = 0
            For Each i As Image In {My.Resources.pawn_white, My.Resources.pawn_black,
                                    My.Resources.rook_white, My.Resources.rook_black,
                                    My.Resources.bishop_white, My.Resources.bishop_black,
                                    My.Resources.knight_white, My.Resources.knight_black,
                                    My.Resources.queen_white, My.Resources.queen_black,
                                    My.Resources.king_white, My.Resources.king_black}
                L.Add(New Card(i, c.ToString))
                c += 1
            Next
            Return L
        End Get
    End Property

    Public Shared ReadOnly Property ChessBlack As List(Of Card)
        Get
            Dim L As New List(Of Card)
            Dim c As Integer = 0
            For Each i As Image In {My.Resources.pawn_black,
                                    My.Resources.rook_black,
                                    My.Resources.bishop_black,
                                    My.Resources.knight_black,
                                    My.Resources.queen_black,
                                    My.Resources.king_black}
                L.Add(New Card(i, c.ToString))
                c += 1
            Next
            Return L
        End Get
    End Property

    Public Shared ReadOnly Property Birds As List(Of Card)
        Get
            Dim L As New List(Of Card)
            Dim c As Integer = 0
            For Each i As Image In {My.Resources.puffin,
                                    My.Resources.penguin,
                                    My.Resources.flamingo,
                                    My.Resources.toucan,
                                    My.Resources.owl}
                L.Add(New Card(i, c.ToString))
                c += 1
            Next
            Return L
        End Get
    End Property

    Public Shared ReadOnly Property AllDecks As Dictionary(Of String, List(Of Card))
        Get
            Dim d As New Dictionary(Of String, List(Of Card))
            d.Add("Full Chess suite", ChessAll)
            d.Add("Half Chess suite", ChessBlack)
            d.Add("Test (small)", Test)
            d.Add("Birds", Birds)
            Return d
        End Get
    End Property

End Class
