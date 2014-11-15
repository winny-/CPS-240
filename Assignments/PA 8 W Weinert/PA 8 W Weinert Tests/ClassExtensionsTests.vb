Option Strict On

Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PA_8_W_Weinert.TestSupport

<TestClass()> Public Class ClassExtensionsTests

    Private Const chunkWidth As Integer = 3
    Private chunkList As New List(Of Integer) From {1, 2, 3, 4, 5, 6}
    Private chunkListExpected As New List(Of List(Of Integer)) From {New List(Of Integer) From {1, 2, 3},
                                                                     New List(Of Integer) From {4, 5, 6}}
    <TestMethod()>
    Public Sub ChunkTest()
        Dim c As Integer = 0
        Dim cc As Integer
        For Each e As IEnumerable(Of Integer) In Chunk(chunkList, chunkWidth)
            cc = 0
            Assert.IsTrue(e.Count = chunkWidth)
            For Each p As Integer In e
                Assert.AreEqual(chunkListExpected(c)(cc), p)
                cc += 1
            Next
            c += 1
        Next
    End Sub

    <TestMethod()>
    Public Sub HasNPlacesOrLessTest()
        Dim none As Decimal = 250
        Dim one As Decimal = 125.5D
        Dim two As Decimal = 131.12D
        Dim three As Decimal = 555.55D

        Assert.IsTrue(HasNPlacesOrLess(none, 3))
        Assert.IsTrue(HasNPlacesOrLess(none, 0))

        Assert.IsFalse(HasNPlacesOrLess(one, 0))
        Assert.IsTrue(HasNPlacesOrLess(one, 1))
        Assert.IsTrue(HasNPlacesOrLess(one, 2))

        Assert.IsFalse(HasNPlacesOrLess(two, 0))
        Assert.IsFalse(HasNPlacesOrLess(two, 1))
        Assert.IsTrue(HasNPlacesOrLess(two, 2))

        Assert.IsFalse(HasNPlacesOrLess(three, 0))
        Assert.IsFalse(HasNPlacesOrLess(three, 1))
        Assert.IsFalse(HasNPlacesOrLess(three, 2))
        Assert.IsTrue(HasNPlacesOrLess(three, 3))
        Assert.IsTrue(HasNPlacesOrLess(three, 4))
    End Sub

End Class