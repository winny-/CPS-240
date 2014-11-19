Option Strict On

Imports System.Runtime.CompilerServices

Module ClassExtensions

    ''' <summary>
    ''' Fisher-Yates shuffle
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <remarks>https://stackoverflow.com/questions/273313/randomize-a-listt-in-c-sharp</remarks>
    <Extension()>
    Public Sub Shuffle(Of T)(ByVal list As IList(Of T))
        Dim r As New Random
        Dim n As Integer = list.Count
        While n > 1
            n -= 1
            Dim k As Integer = r.Next(n + 1)
            Dim value As T = list(k)
            list(k) = list(n)
            list(n) = value
        End While
    End Sub

End Module
