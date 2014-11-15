Option Strict On

Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PA_8_W_Weinert

<TestClass()>
Public Class PersonSetUnitTest

    Private Const nl As String = ControlChars.NewLine

    <TestMethod()>
    Public Sub DefaultAddInvalidTest()
        Dim a As New PersonSet()

        Try
            a.Add(New Person("aoeu", 1, 1))
            Assert.Fail("Should not reach")
        Catch ex As ArgumentException

        End Try
    End Sub

    <TestMethod()>
    Public Sub AddRemoveTest()
        Dim ps As New PersonSet()

        ps.Add("test", 20)

        Try
            ps.Add("test", 0)
            Assert.Fail("Should not reach (test)")
        Catch ex As PersonSet.DuplicateNameException

        End Try

        Try
            ps.Add("TEST", 0)
            Assert.Fail("Should not reach (TEST)")
        Catch ex As PersonSet.DuplicateNameException

        End Try

        ps.Remove(ps(0))

        ps.Add("test", 20)

        Try
            ps.Add("A VERY BAD NAME!", 0)
            Assert.Fail("Should not reach (A VERY BAD NAME!)")
        Catch ex As PersonSet.InvalidNameException

        End Try
    End Sub

    <TestMethod()>
    Public Sub SpecialQueriesTest()
        Dim ps As New PersonSet()

        ps.Add("test", 20)
        ps.Add("testA", 20)

        Assert.AreEqual(ps(0), ps.ByID(1))
        Assert.AreEqual(ps(1), ps.ByID(2))
        Assert.AreEqual(ps(0), ps.ByName("test"))
        Assert.AreEqual(ps(1), ps.ByName("testA"))

        Assert.IsNull(ps.ByID(3))
        Assert.IsNull(ps.ByName("not in ps"))
    End Sub

    <TestMethod()>
    Public Sub ClearTest()
        Dim ps As New PersonSet()

        ps.Add("test", 20)

        ps.Clear()

        Assert.AreEqual(0, ps.Count)

        ps.Add("test", 20)
    End Sub

    <TestMethod()>
    Public Sub SortsTest()
        Dim ps As New PersonSet()
        Dim a, b, c As Person
        a = ps.Add("a", 5)
        c = ps.Add("c", 5)
        b = ps.Add("b", 5)
        Assert.AreEqual(a, ps(0))
        Assert.AreEqual(c, ps(1))
        Assert.AreEqual(b, ps(2))
    End Sub

    <TestMethod()>
    Public Sub GiveRandomPersonCashTest()
        Dim ps As New PersonSet()
        ps.Add("a", 5)
        ps.Add("b", 5)
        ps.Add("c", 5)
        ps.GiveRandomPersonCash(10)
        Assert.IsTrue(ps.Any(Function(p As Person) p.Cash = 15))
    End Sub

    <TestMethod()>
    Public Sub SavetoStringTest()
        Dim ps As New PersonSet()
        ps.Add("billy", 5)
        ps.Add("alex", 6)
        Dim expected As String = "P1" & nl &
            "billy" & nl &
            "5" & nl &
            "P2" & nl &
            "alex" & nl &
            "6"
        Assert.AreEqual(expected, ps.SaveToString())
    End Sub

    <TestMethod()>
    Public Sub LoadPersonsFromStringTest()
        Dim s As String = "P1" & nl &
            "billy" & nl &
            "5" & nl &
            "P2" & nl &
            "alex" & nl &
            "6"
        Dim ps As New PersonSet()
        ps.LoadPersonsFromString(s)
        Assert.IsTrue(ps.ByID(1) = New Person("billy", 1, 5))
        Assert.IsTrue(ps.ByID(2) = New Person("alex", 2, 6))
    End Sub

End Class