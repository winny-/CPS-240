Option Strict On

Imports System.Runtime.CompilerServices

Module ClassExtensions

    ''' <summary>
    ''' Chunk an IEnumerable
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="source"></param>
    ''' <param name="chunkSize">size of chunks</param>
    ''' <returns></returns>
    ''' <remarks>https://stackoverflow.com/questions/419019/split-list-into-sublists-with-linq</remarks>
    <Extension()>
    Public Iterator Function Chunk(Of T)(ByVal source As IEnumerable(Of T), ByVal chunkSize As Integer) As IEnumerable(Of IEnumerable(Of T))
        While source.Any
            Yield source.Take(chunkSize)
            source = source.Skip(chunkSize)
        End While
    End Function

    <Extension()>
    Public Function HasNDecimalPlacesOrLess(ByVal number As Decimal, ByVal places As Integer) As Boolean
        If places < 0 Then Throw New ArgumentException()
        If places = 0 Then
            Return Math.Truncate(number) = number
        Else
            Dim multiplier As Double = Math.Pow(10, places)
            Return Math.Truncate(number * multiplier) / multiplier = number
        End If
    End Function

End Module
