Option Strict On

Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Class DataLayer

    Public Property FileName As String
    Public Property Game As Game

    Public Sub New()
        Reset()
    End Sub

    Public Sub Reset()
        FileName = Nothing
        Game = New Game()
    End Sub

    Public Function ReadGame() As Boolean
        Return ReadGameFromFile(FileName, Game)
    End Function

    Public Function WriteGame() As Boolean
        Return WriteGameToFile(FileName, Game)
    End Function

    Public Shared Function WriteGameToFile(fname As String, game As Game) As Boolean
        Dim s As FileStream = Nothing
        Try
            s = New FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None)
            Return WriteObjectToStream(s, game)
        Catch ex As Exception
            Return False
        Finally
            If s IsNot Nothing Then s.Close()
        End Try
        Return True
    End Function

    Public Shared Function ReadGameFromFile(fname As String, ByRef game As Game) As Boolean
        Dim s As FileStream = Nothing
        Try
            s = New FileStream(fname, FileMode.Open, FileAccess.Read, FileShare.None)
            Dim obj As Object = Nothing
            Dim success As Boolean = ReadObjectFromStream(s, obj)
            game = CType(obj, Game)
            Return success
        Catch ex As Exception
            Return False
        Finally
            If s IsNot Nothing Then s.Close()
        End Try
    End Function

    Private Shared Function WriteObjectToStream(outStream As Stream, obj As Object) As Boolean
        Dim formatter As IFormatter = New BinaryFormatter()
        Try
            formatter.Serialize(outStream, obj)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Shared Function ReadObjectFromStream(inStream As Stream, ByRef obj As Object) As Boolean
        Dim formatter As IFormatter = New BinaryFormatter()
        Try
            obj = formatter.Deserialize(inStream)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

End Class
