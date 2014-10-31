Option Strict On

Public Class CCookie

    Private Shared count As Integer = 1

    Private strID As String = Nothing

    Public ReadOnly Property ID As String
        Get
            Return strID
        End Get
    End Property

    Public Property name As String

    Public Sub New()
        strID = String.Format("C{0:D2}", newID())
    End Sub

    Public Sub New(ByVal name As String)
        Me.name = name
    End Sub

    Private Shared Function newID() As Integer
        Dim n As Integer = count
        count += 1
        Return n
    End Function

    Public Sub t()
        Dim batch As New Collection

        Dim cookie As New CCookie("Oatmeal")
        batch.Add(Key:=cookie.ID,
                  Item:=cookie)
        batch.Remove("sugarCookie")
    End Sub

End Class
