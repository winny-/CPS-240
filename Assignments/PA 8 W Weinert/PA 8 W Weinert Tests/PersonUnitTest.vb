Option Strict On

Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PA_8_W_Weinert

<TestClass()>
Public Class PersonUnitTest

    <TestMethod()>
    Public Sub OperatorsTest()
        Dim a As New Person("Test", 1, 20)
        Dim b As New Person("TestA", 1, 20)

        Assert.IsTrue(a = a)
        Assert.AreEqual(0, a.CompareTo(a))

        Assert.IsTrue(a < b)
        Assert.IsTrue(b > a)
        Assert.IsTrue(a <> b)
        Assert.AreEqual(-1, a.CompareTo(b))

        Dim c As New Person("Test", 2, 20)

        Assert.IsTrue(a < c)
        Assert.IsTrue(b < c)
        Assert.IsTrue(a <> c)
        Assert.AreEqual(1, c.CompareTo(a))

        Dim d As New Person("Test", 1, 19)
        Assert.IsTrue(d < a)
        Assert.IsTrue(a > d)
        Assert.AreEqual(-1, d.CompareTo(a))
    End Sub

    <TestMethod()>
    Public Sub AddCashTest()
        Dim a As New Person("Test", 1, 0)
        Assert.AreEqual(0D, a.Cash)
        a.AddCash(25.23D)
        Assert.AreEqual(25.23D, a.Cash)
    End Sub

    <TestMethod()>
    Public Sub ToStringTest()
        Dim a As New Person("Test", 5, 25.11D)
        Assert.AreEqual("P5 Test: $25.11", a.ToString())
    End Sub

    <TestMethod()>
    Public Sub ValidateNameTest()
        Assert.IsTrue(Person.ValidateName("aoeuuuuAAoaeauA"))
        Assert.IsFalse(Person.ValidateName(" aoeu"))
        Assert.IsFalse(Person.ValidateName("billy!"))
    End Sub

    <TestMethod()>
    Public Sub ValidateCashTest()
        Assert.IsTrue(Person.ValidateCash(0))
        Assert.IsTrue(Person.ValidateCash(55.1D))
        Assert.IsTrue(Person.ValidateCash(11.44D))
        Assert.IsFalse(Person.ValidateCash(-1))
        Assert.IsFalse(Person.ValidateCash(5.234D))
    End Sub

    <TestMethod()>
    Public Sub ToRecordTest()
        Dim p As New Person("test", 1, 55.33D)
        Dim expected As String = "P1" & ControlChars.NewLine &
                        "test" & ControlChars.NewLine &
                        "55.33"
        Assert.AreEqual(expected, p.ToRecord())
    End Sub

End Class