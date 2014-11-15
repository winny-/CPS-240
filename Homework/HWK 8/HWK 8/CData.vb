Option Strict On
Imports System.IO

Public Class CData

    Private Shared filename As String = "data.txt"

    Public Sub New()
    End Sub

    Public Shared Function writeToFile(ByVal c As Collection,
                               ByRef msg As String) As Boolean
        'complete this method. The collection c contains a collection of CSighting objects. 
        'If the writeToFile does not succeed return the error in msg.

        Dim buf As New System.Text.StringBuilder()

        For Each obj In c
            Dim sighting As CSighting = TryCast(obj, CSighting)
            If sighting Is Nothing Then
                msg = "Non-CSighting instance in c"
                Return False
            End If
            buf.AppendLine(String.Join(":", {sighting.getID(),
                                             sighting.quantity.ToString(),
                                             sighting.birdType}))
        Next

        Dim sw As StreamWriter = Nothing
        Try
            sw = New StreamWriter(filename)
            sw.Write(buf)
            Return True
        Catch ex As Exception
            msg = String.Format("{0} was thrown.", ex)
            Return False
        Finally
            If sw IsNot Nothing Then sw.Close()
        End Try
    End Function

    Public Shared Function readFromfile(ByRef c As Collection,
                                 ByRef msg As String) As Boolean

        'complete this method. All CSighting objects are read from the file and added to the collection.  
        'If the readFromFile does not succeed return the error in msg.

        Dim sr As StreamReader = Nothing
        Dim text As String

        Try
            sr = New StreamReader(filename)
            text = sr.ReadToEnd()
        Catch ex As Exception
            msg = String.Format("{0} was thrown.", ex)
            Return False
        Finally
            If sr IsNot Nothing Then sr.Close()
        End Try

        c = New Collection()
        Dim nl() As Char = ControlChars.NewLine.ToCharArray()
        For Each record As IEnumerable(Of String) In (From s As String In text.Split(nl)
                                                      Where s <> String.Empty
                                                      Select s.Split(":"c))
            If record.Any(Function(s As String) s = String.Empty) Then
                msg = "Empty field"
                Return False
            End If
            Dim quantity As Integer
            If Not Integer.TryParse(record(1), quantity) Then
                msg = String.Format("Bad integer ""{0}""", record(1))
                Return False
            End If
            Dim sighting As New CSighting()
            sighting.setID(record(0))
            sighting.quantity = quantity
            sighting.birdType = record(2)
            c.Add(Key:=sighting.getID, Item:=sighting)
        Next
        Return True
    End Function

End Class
