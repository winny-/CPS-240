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

    ''' <summary>
    ''' Create a new list by joining two lists.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <param name="other"></param>
    ''' <returns>the new, joined list</returns>
    ''' <remarks>This is basically a Pythonic wrapper around List.AddRange()</remarks>
    <Extension()>
    Public Function Extend(Of T)(ByVal list As List(Of T), ByVal other As IList(Of T)) As List(Of T)
        Dim L As New List(Of T)(list)
        L.AddRange(other)
        Return L
    End Function

    ''' <summary>
    ''' Convert a Boolean to a sane Integral representation
    ''' </summary>
    ''' <param name="b">the Boolean</param>
    ''' <returns>1 for True, 0 for False</returns>
    ''' <remarks>
    ''' In .NET, Convert.ToInt32(True) returns -1, Convert.ToInt32(False) 0.
    ''' This is very undesirable, so I wrote this extension method.
    ''' </remarks>
    <Extension()>
    Public Function ToBinary(ByVal b As Boolean) As Integer
        Return If(b, 1, 0)
    End Function

End Module
