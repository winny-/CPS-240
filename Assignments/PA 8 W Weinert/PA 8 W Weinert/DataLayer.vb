Option Strict On

Imports PA_8_W_Weinert
Imports System.IO

Public NotInheritable Class DataLayer

    Public Class DataLayerIOException
        Inherits Exception
    End Class

    Public Property Filename As String
    Public Property Persons As PersonSet

    Public ReadOnly Property HaveFile As Boolean
        Get
            Return Filename <> String.Empty AndAlso Persons IsNot Nothing
        End Get
    End Property

    Public ReadOnly Property UnwrittenChanges As Boolean
        Get
            If HaveFile Then
                Try
                    Return ReadFile(Filename) <> Persons.SaveToString()
                Catch ex As Exception

                End Try
            End If

            Return False
        End Get
    End Property

    Public Sub New()
        Clear()
    End Sub

    Public Sub Clear()
        Filename = Nothing
        Persons = New PersonSet()
    End Sub

    Public Sub Close()
        Clear()
    End Sub

    Public Sub Open()
        Dim text As String = ReadFile(Filename)
        If text Is Nothing Then Throw New DataLayerIOException()
        Persons.LoadPersonsFromString(text)
    End Sub

    Public Sub Save()
        Dim text As String = Persons.SaveToString()
        Dim w As StreamWriter = Nothing
        Try
            w = New StreamWriter(Filename)
            w.Write(text)
        Catch ex As Exception
            Throw New DataLayerIOException()
        Finally
            If w IsNot Nothing Then w.Close()
        End Try
    End Sub

    Private Shared Function ReadFile(fname As String) As String
        Dim text As String = Nothing
        Dim r As StreamReader = Nothing
        Try
            r = New StreamReader(fname)
            text = r.ReadToEnd()
        Catch ex As Exception

        Finally
            r.Close()
        End Try
        Return text
    End Function

End Class
