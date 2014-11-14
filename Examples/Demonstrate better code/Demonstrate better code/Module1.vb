Option Strict On

'In response to: http://pastebin.com/4dca4DTU

Module Module1

    Private Const input As String = "00|0|10080|400|0|4320|70|0|1440|30|0|2280|10|0|7400|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|0|300|0|15855|90|0|1721"

    Private Function ParseInt(ByVal s As String) As Integer
        Dim n As Integer
        Integer.TryParse(s, n)
        Return n 'On failure, returns 0.
    End Function

    Private Function ParseString(ByVal s As String) As List(Of Integer)
        Return s.Split("|"c).Select(Function(ss As String) ParseInt(ss)).ToList()
    End Function

    Private Function FormatList(Of T)(ByVal L As List(Of T)) As String
        Return "[" & String.Join(", ", L) & "]"
    End Function

    Sub Main()
        Dim parsed As List(Of Integer) = ParseString(input)

        Console.WriteLine("input: " & input)
        Console.WriteLine()
        Console.WriteLine("Parsed integers: " & FormatList(parsed))
        Console.WriteLine("Count: " & parsed.Count.ToString())
        Console.WriteLine("Sum: " & parsed.Sum().ToString())

        Console.ReadKey()
    End Sub

End Module
