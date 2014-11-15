Option Strict On

Imports PA_8_W_Weinert
Imports System.Text.RegularExpressions

Public Class PersonSet
    Inherits SortedSet(Of Person)

    Public Class InvalidNameException
        Inherits Exception
    End Class

    Public Class DuplicateNameException
        Inherits Exception
    End Class

    Public Class DuplicateIDException
        Inherits Exception
    End Class

    Private _UsedIDs As HashSet(Of Integer)
    Private _UsedNames As HashSet(Of String)

    Public ReadOnly Property UsedIDs As HashSet(Of Integer)
        Get
            Return New HashSet(Of Integer)(_UsedIDs)
        End Get
    End Property

    Public ReadOnly Property UsedNames As HashSet(Of String)
        Get
            Return New HashSet(Of String)(_UsedNames)
        End Get
    End Property

    Public Sub New()
        InitializeSets()
    End Sub

    Public Overrides Sub Clear()
        MyBase.Clear()
        InitializeSets()
    End Sub

    Private Sub InitializeSets()
        _UsedIDs = New HashSet(Of Integer)
        _UsedNames = New HashSet(Of String)
    End Sub

    Private ReadOnly Property NextAvailableID As Integer
        Get
            Return (From i As Integer In Enumerable.Range(1, 1000)
                    Where Not _UsedIDs.Contains(i)
                    ).First
        End Get
    End Property

    Private Function NameIsUnique(name As String) As Boolean
        Return _UsedNames.All(Function(s As String) s.ToLower() <> name.ToLower())
    End Function

    Public Shadows Function Remove(p As Person) As Boolean
        Dim success As Boolean = MyBase.Remove(p)
        If success Then
            _UsedIDs.Remove(p.ID)
            _UsedNames.Remove(p.Name)
        End If
        Return success
    End Function

    Public Shadows Sub Add(p As Person)
        Throw New ArgumentException("Do not call PersonSet.Add(Person), see PersonSet.Add(String, Decimal)")
    End Sub

    Public Shadows Function Add(name As String, cash As Decimal) As Person
        Return Add(name, cash, NextAvailableID)
    End Function

    Private Shadows Function Add(name As String, cash As Decimal, id As Integer) As Person
        If Not Person.ValidateName(name) Then Throw New InvalidNameException()
        If Not NameIsUnique(name) Then Throw New PersonSet.DuplicateNameException()
        If _UsedIDs.Contains(id) Then Throw New DuplicateIDException()
        Dim p As New Person(name, id, cash)
        MyBase.Add(p)
        _UsedIDs.Add(id)
        _UsedNames.Add(name)
        Return p
    End Function

    Public Function ByID(id As Integer) As Person
        Return (From p As Person In Me
                Where p.ID = id
                ).DefaultIfEmpty(Nothing).Single
    End Function

    Public Function ByName(name As String) As Person
        Return (From p As Person In Me
                Where p.Name = name
                ).DefaultIfEmpty(Nothing).Single
    End Function

    Public Function GiveRandomPersonCash(amount As Decimal) As Person
        Static r As New Random
        If Count = 0 Then Return Nothing
        Dim p As Person = Me(r.Next(0, Count))
        p.AddCash(amount)
        Return p
    End Function

    Public Sub LoadPersonsFromString(s As String)
        Clear()
        Dim elements As List(Of String) = s.Split(ControlChars.NewLine.ToCharArray()) _
                                          .Where(Function(ss) ss <> String.Empty) _
                                          .ToList()
        If elements.Count Mod 3 <> 0 Then Throw New ArgumentException()
        For Each elem As IEnumerable(Of String) In elements.Chunk(3)
            Dim idString As String = Regex.Replace(elem(0), "[^0-9]*", "")
            Dim name As String = elem(1)
            Dim cashString As String = elem(2)

            Dim id As Integer
            Dim cash As Decimal

            If Integer.TryParse(idString, id) AndAlso Decimal.TryParse(cashString, cash) Then
                Try
                    Add(name, cash, id)
                Catch ex As DuplicateIDException
                    Add(name, cash, NextAvailableID)
                End Try
            Else
                Throw New ArgumentException()
            End If
        Next
    End Sub

    Public Function SaveToString() As String
        Return String.Join(ControlChars.NewLine,
                           Me.Select(Function(p As Person) p.ToRecord()))
    End Function

End Class
