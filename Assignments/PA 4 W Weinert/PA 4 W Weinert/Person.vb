Option Strict On

Public Class Person

    Private _name As String
    Private _age As Integer

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Sub New(ByVal name As String, ByVal age As Integer)
        Me.Name = name
        Me.Age = age
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function

    Public Shared Function NameIsValid(ByVal name As String) As Boolean
        Return name <> String.Empty
    End Function

    Public Shared Function AgeIsValid(ByVal age As Integer) As Boolean
        Return age > 0 And age < 150
    End Function

    Public Shared Function AgeIsValid(ByVal age As String) As Boolean
        Dim ageN As Integer
        Return Integer.TryParse(age, ageN) AndAlso AgeIsValid(ageN)
    End Function

    Public Shared Function TryParse(ByVal name As String, ByVal age As String, ByRef p As Person) As Boolean
        p = Nothing
        Dim ageN As Integer
        Dim valid As Boolean = NameIsValid(name) AndAlso Integer.TryParse(age, ageN) AndAlso AgeIsValid(ageN)

        If valid Then
            p = New Person(name, ageN)
        End If

        Return valid
    End Function

End Class
