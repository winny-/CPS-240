Option Strict On

Public Class frmAbout

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wbAbout.DocumentText = My.Resources.about
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub wbAbout_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles wbAbout.Navigating
        Dim urlString As String = e.Url.ToString
        If urlString = "about:blank" Then Return
        e.Cancel = True
        Process.Start(urlString)
    End Sub

End Class