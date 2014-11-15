Option Strict On

Imports PA_8_W_Weinert

''' <summary>
''' Make ClassExtensions accessible from unit tests
''' </summary>
''' <remarks>This is utterly tasteless, thanks Microsoft.</remarks>
Public NotInheritable Class TestSupport

    Public Shared Iterator Function Chunk(Of T)(ByVal source As IEnumerable(Of T), ByVal chunkSize As Integer) As IEnumerable(Of IEnumerable(Of T))
        For Each i As IEnumerable(Of T) In source.Chunk(chunkSize)
            Yield i
        Next
    End Function

    Public Shared Function HasNPlacesOrLess(ByVal number As Decimal, ByVal places As Integer) As Boolean
        Return number.HasNDecimalPlacesOrLess(places)
    End Function

End Class
