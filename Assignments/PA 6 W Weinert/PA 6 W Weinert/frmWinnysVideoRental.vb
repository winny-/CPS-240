'*****************************************************************
'PA 6: Video Rental
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Imports PA_6_W_Weinert

Public Class frmWinnysVideoRental

    Private Layer As New BusinessAndDataLayer()

    '*****************************************************************
    'GUI Helpers
    '*****************************************************************

    Private Sub ReDisplayListBox(ByVal box As ListBox, ByVal videos As List(Of Video))
        Dim selected As Video = TryCast(box.SelectedItem, Video)
        box.Items.Clear()
        For Each v As Video In videos
            box.Items.Add(v)
        Next
        box.SelectedItem = selected
    End Sub

    Private Sub Display()
        ReDisplayListBox(lstAvailable, Layer.AvailableVideos)
        ReDisplayListBox(lstRented, Layer.RentedVideos)
        IndexesChanged() 'Force an invocation
    End Sub

    Private Function RemoveSelectedItem(ByVal box As ListBox) As Video
        Dim selected As Video = CType(box.SelectedItem, Video)
        box.SelectedIndex = If(box.Items.Count > 1,
                               Math.Max(box.Items.Count, 0),
                               -1)
        Return selected
    End Function

    '*****************************************************************
    'Events
    '*****************************************************************

    Private Sub frmWinnysVideoRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IndexesChanged()
    End Sub

    '*****************************************************************
    'ListBox events
    '*****************************************************************

    Private Sub lstAvailable_Click(sender As Object, e As EventArgs) Handles lstAvailable.Click
        If lstAvailable.SelectedIndex <> -1 Then lstRented.SelectedIndex = -1
    End Sub

    Private Sub lstRented_Click(sender As Object, e As EventArgs) Handles lstRented.Click
        If lstRented.SelectedIndex <> -1 Then lstAvailable.SelectedIndex = -1
    End Sub

    Private Sub lstAvailable_GotFocus(sender As Object, e As EventArgs) Handles lstAvailable.GotFocus
        If lstAvailable.SelectedIndex = -1 AndAlso lstAvailable.Items.Count > 0 Then lstAvailable.SelectedIndex = 0
    End Sub

    Private Sub lstRented_GotFocus(sender As Object, e As EventArgs) Handles lstRented.GotFocus
        If lstRented.SelectedIndex = -1 AndAlso lstRented.Items.Count > 0 Then lstRented.SelectedIndex = 0
    End Sub

    Private Sub IndexesChanged() Handles _
        lstAvailable.SelectedIndexChanged,
        lstRented.SelectedIndexChanged

        Dim availableSelected As Boolean = lstAvailable.SelectedIndex <> -1
        Dim rentedSelected As Boolean = lstRented.SelectedIndex <> -1

        btnRent.Enabled = availableSelected
        btnReturn.Enabled = rentedSelected

        If availableSelected Then
            AcceptButton = btnRent
        ElseIf rentedSelected Then
            AcceptButton = btnReturn
        Else
            AcceptButton = Nothing
        End If
    End Sub

    '*****************************************************************
    'Button events
    '*****************************************************************

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        Dim v As Video = RemoveSelectedItem(lstAvailable)
        Layer.Rent(v)
        tsslLastAction.Text = String.Format("Rented ""{0}""", v)
        Display()
    End Sub


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim v As Video = RemoveSelectedItem(lstRented)
        Dim cost As Decimal = Layer.Return_(v)
        tsslLastAction.Text = String.Format("Returned ""{0}"" with {1:C} fee", v, cost)
        Display()
    End Sub

    '*****************************************************************
    'Menustrip events
    '*****************************************************************

    Private Sub miAddVideo_Click(sender As Object, e As EventArgs) Handles miAddVideo.Click
        Dim title As String = InputBox("Input a title: ")
        If Not Layer.TitleIsUnique(title) Then
            MessageBox.Show("Title is already in use.")
            Return
        End If
        If title = String.Empty Then Return
        Layer.Add(New Video(title))
        Display()
    End Sub

    Private Sub miRemoveVideo_Click(sender As Object, e As EventArgs) Handles miRemoveVideo.Click
        If lstRented.SelectedIndex <> -1 Then
            MessageBox.Show("Please return the video before removing it.")
            Return
        End If
        If lstAvailable.SelectedIndex = -1 Then
            MessageBox.Show("No video selected to remove.")
            Return
        End If
        RemoveSelectedItem(lstAvailable)
        Display()
    End Sub

    Private Sub miTotalFees_Click(sender As Object, e As EventArgs) Handles miTotalFees.Click
        MessageBox.Show(String.Format("Total fees: {0:C}", Layer.TotalFees))
    End Sub


    Private Sub miExit_Click(sender As Object, e As EventArgs) Handles miExit.Click
        Close()
    End Sub

End Class
