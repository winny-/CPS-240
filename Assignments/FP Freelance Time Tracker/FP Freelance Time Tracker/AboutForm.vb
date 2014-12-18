Public Class AboutForm

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AboutWebBrowser.DocumentText = My.Resources.about
    End Sub

    Private Sub AboutWebBrowser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles AboutWebBrowser.Navigating
        Dim urlString As String = e.Url.ToString
        If urlString = "about:blank" Then Return
        e.Cancel = True
        Process.Start(urlString)
    End Sub

End Class