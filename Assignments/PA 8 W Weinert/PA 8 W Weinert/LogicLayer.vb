Option Strict On

Imports PA_8_W_Weinert

Public NotInheritable Class LogicLayer

    Public Structure DecimalRange
        Public Min, Max As Decimal
    End Structure
    Public Property CashGiftAmount As Decimal = 20
    Public Property RandomStartingCashRange As DecimalRange = New DecimalRange With {.Min = 10,
                                                                                     .Max = 20}
    Private Property DataLayer As New DataLayer()
    Public ReadOnly Property Persons As PersonSet
        Get
            Return DataLayer.Persons
        End Get
    End Property
    Public ReadOnly Property CanCloseWithoutSaving As Boolean
        Get
            Return Not DataLayer.UnwrittenChanges
        End Get
    End Property
    Public ReadOnly Property HaveFile As Boolean
        Get
            Return DataLayer.HaveFile
        End Get
    End Property
    Public ReadOnly Property Filename As String
        Get
            Return DataLayer.Filename
        End Get
    End Property
    Public ReadOnly Property FilenameOnly As String
        Get
            Return System.IO.Path.GetFileNameWithoutExtension(Filename)
        End Get
    End Property

    Public Sub New()

    End Sub

    Public Function AddPeson(name As String) As Boolean
        Dim p As Person
        Try
            p = Persons.Add(name, RandomCashInRange(RandomStartingCashRange))
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function RemovePerson(p As Person) As Boolean
        Return Persons.Remove(p)
    End Function

    Public Function GiveRandomPersonRandomGift() As Boolean
        Persons.GiveRandomPersonCash(CashGiftAmount)
        Return True
    End Function

    Public Function OpenFile(fname As String) As Boolean
        DataLayer.Filename = fname
        Try
            DataLayer.Open()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function SaveFile() As Boolean
        Try
            DataLayer.Save()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function NewFile(fname As String) As Boolean
        DataLayer.Clear()
        DataLayer.Filename = fname
        Return True
    End Function

    Public Function CloseFile() As Boolean
        NewFile(Nothing)
        Return True
    End Function

    Public Shared Function RandomCashInRange(range As DecimalRange) As Decimal
        Static r As New Random()
        Dim max As Integer = CInt(Math.Round(range.Max * 100))
        Dim min As Integer = CInt(Math.Round(range.Min * 100))
        Return CDec(r.Next(min, max)) / 100
    End Function

End Class
