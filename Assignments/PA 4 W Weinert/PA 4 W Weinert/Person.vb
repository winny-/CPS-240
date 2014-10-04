Option Strict On

Imports System.Text.RegularExpressions

Public Class Person

    '*****************************************************************
    'Private fields
    '*****************************************************************

    Private _name As String
    Private _age As Integer

    '*****************************************************************
    'Properties
    '*****************************************************************

    '.NET style setter and getters. I use these throughout the code, but worry not,
    'I included the Java style as per assignment requirements.
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

    '*****************************************************************
    'Java style properties to fulfill assignment requirements
    '*****************************************************************

    Public Function getName() As String
        Return _name
    End Function

    Public Sub setName(ByVal name As String)
        _name = name
    End Sub

    Public Function getAge() As Integer
        Return _age
    End Function

    Public Sub setAge(ByVal age As Integer)
        _age = age
    End Sub

    '*****************************************************************
    'Constructors
    '*****************************************************************

    Public Sub New()
        'Intentionally left blank.
    End Sub

    Public Sub New(ByVal name As String, ByVal age As Integer)
        Me.Name = name
        Me.Age = age
    End Sub

    '*****************************************************************

    Public Overrides Function ToString() As String
        Return Name
    End Function

    '*****************************************************************
    'String validation and parsing
    '*****************************************************************

    Public Shared Function NameIsValid(ByVal name As String) As Boolean
        'Basically anything that starts with a letter and ends with a letter is okay.
        'Hyphens, spaces, and apostraphe are all okay in the middle.
        Return Regex.IsMatch(name, "^(?![-' ])[a-zA-Z-' ]*[a-zA-Z]$")
    End Function

    Public Shared Function AgeIsValid(ByVal age As Integer) As Boolean
        Return age > 0 And age < 150
    End Function

    Public Shared Function AgeIsValid(ByVal age As String) As Boolean
        Return parseAge(age, Nothing)
    End Function

    Public Shared Function TryParse(ByVal name As String, ByVal age As String, ByRef p As Person) As Boolean
        p = Nothing
        Dim ageN As Integer
        Dim valid As Boolean = NameIsValid(name) AndAlso parseAge(age, ageN)

        If valid Then
            p = New Person(name, ageN)
        End If

        Return valid
    End Function

    '*****************************************************************
    'Private methods
    '*****************************************************************

    Private Shared Function parseAge(ByVal s As String, ByRef age As Integer) As Boolean
        Dim n As Integer
        Dim valid As Boolean = Integer.TryParse(s, n) AndAlso AgeIsValid(n)

        If valid Then age = n

        Return valid
    End Function

End Class
