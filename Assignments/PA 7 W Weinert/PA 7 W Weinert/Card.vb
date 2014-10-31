Option Strict On

Public Class Card

    Public Property CardBox As CardBox

    Public Enum State
        FaceDown
        Guess
        Matched
    End Enum

    Private _Face As Image
    Private _Name As String

    Public ReadOnly Property Face As Image
        Get
            Return _Face
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return _Name
        End Get
    End Property

    Public Property CurrentState As State = State.FaceDown

    Public Sub New(ByVal face As Image, ByVal name As String)
        _Face = face
        _Name = name
    End Sub

    Public Function Clone() As Card
        Return New Card(Face, Name)
    End Function

End Class
