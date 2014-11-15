'Please don't copy this file as the terms of use are.... disputed.

Option Strict On

'a Bird watcher wants to keep track of all the sightings of birds

Public Class CSighting
    Private Shared count As Integer
    Private strID As String

    Public Property birdType As String
    Public Property quantity As Integer

    Public Sub New()
    End Sub

    Public Sub setID()
        count += 1
        strID = "S" & count.ToString("D2")
    End Sub

    Public Sub setID(ByVal id As String)
        Dim temp As Integer
        strID = id
        temp = Convert.ToInt32(id.Substring(1))
        If temp > count Then
            count = temp
        End If
    End Sub

    Public Function getID() As String
        Return strID
    End Function

    Public Sub recordSighting(ByVal bird As String,
                              ByVal q As Integer)
        Me.birdType = bird
        Me.quantity = q
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String
        s = Me.getID & ": " & Me.quantity & " " & Me.birdType
        Return s
    End Function

End Class
