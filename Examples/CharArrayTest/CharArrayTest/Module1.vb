Option Strict On

Module Module1

    Sub Main()
        Dim nameAsStrings As New List(Of String)({"Smith,M.", "Matthews,D."})
        Dim nameAsCharArrays()() As Char = (From n As String In nameAsStrings Select n.ToCharArray).ToArray
        Dim names()() As Char = {({"S"c, "m"c, "i"c, "t"c, "h"c, ","c, "M"c, "."c}), ({"M"c, "a"c, "t"c, "t"c, "h"c, "e"c, "w"c, "s"c, ","c, "D"c, "."c})}

        Console.WriteLine("Using LINQ and string arrays to char arrays")
        For Each n() As Char In nameAsCharArrays
            PrintCharArray(n)
        Next

        Console.WriteLine()

        Console.WriteLine("Using a Jagged array")
        For Each n() As Char In names
            PrintCharArray(n)
        Next

        Console.ReadKey()
    End Sub

    Private Sub PrintCharArray(ByVal ary() As Char)
        Dim res As String = ""
        For Each c As Char In ary
            res += c.ToString
        Next
        Console.WriteLine(res)
    End Sub

End Module
