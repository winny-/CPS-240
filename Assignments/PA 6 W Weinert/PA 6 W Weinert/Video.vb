﻿Option Strict On

Imports PA_6_W_Weinert

Public Class Video

    Private Const ID_FORMAT As String = "V{0:D2}"

    Public Enum State
        Available
        Rented
    End Enum

    Private Shared _IdCount As Integer = 1

    Private _Title As String
    Private _CurrentState As State
    Private _Id As String
    Private _StartTime As DateTime = Nothing

    Public ReadOnly Property Title As String
        Get
            Return _Title
        End Get
    End Property

    Public ReadOnly Property CurrentState As State
        Get
            Return _CurrentState
        End Get
    End Property

    Public ReadOnly Property Id As String
        Get
            Return _Id
        End Get
    End Property

    Public Sub New(ByVal title As String)
        _Title = title
        _Id = newID()
    End Sub

    Public Sub Rent()
        _StartTime = DateTime.Now
        _CurrentState = State.Rented
    End Sub

    Public Function Return_() As TimeSpan
        Dim duration As TimeSpan = DateTime.Now.Subtract(_StartTime)
        _StartTime = Nothing
        _CurrentState = State.Available
        Return duration
    End Function

    Public Overrides Function ToString() As String
        Return Title
    End Function

    Private Shared Function newID() As String
        Dim n As Integer = _IdCount
        _IdCount += 1
        Return String.Format(ID_FORMAT, n)
    End Function

End Class
