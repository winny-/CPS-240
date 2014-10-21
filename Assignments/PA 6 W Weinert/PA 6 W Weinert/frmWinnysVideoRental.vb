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
        videos.ForEach(Function(v As Video) box.Items.Add(v))
        box.SelectedItem = selected
    End Sub

    Private Sub Display()
        ReDisplayListBox(lstAvailable, Layer.AvailableVideos)
        ReDisplayListBox(lstRented, Layer.RentedVideos)
        IndexesChanged() 'Force an invocation
    End Sub

    Private Function GetSelectedItemAndSelectPrevious(ByVal box As ListBox) As Video
        Dim selected As Video = CType(box.SelectedItem, Video)
        If box.Items.Count > 1 Then
            Dim selectedIndex As Integer = box.Items.IndexOf(selected)
            box.SelectedIndex = If(selectedIndex = 0,
                                   1,
                                   selectedIndex - 1)
        End If
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

    Private Sub ListBox_GotFocus(sender As Object, e As EventArgs) Handles _
        lstAvailable.GotFocus,
        lstRented.GotFocus

        Dim thisBox As ListBox = CType(sender, ListBox)
        Dim otherBox As ListBox = If(thisBox Is lstAvailable,
                                     lstRented,
                                     lstAvailable)

        If thisBox.SelectedIndex = -1 AndAlso thisBox.Items.Count > 0 Then
            thisBox.SelectedIndex = 0
        End If
        otherBox.SelectedIndex = -1 'Remove selection from other ListBox.
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
        Dim v As Video = GetSelectedItemAndSelectPrevious(lstAvailable)
        Layer.Rent(v)
        tsslLastAction.Text = String.Format("Rented ""{0}""", v)
        Display()
    End Sub


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim v As Video = GetSelectedItemAndSelectPrevious(lstRented)
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
        Dim v As Video = New Video(title)
        Layer.Add(v)
        Display()
        lstAvailable.SelectedItem = v
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
        GetSelectedItemAndSelectPrevious(lstAvailable)
        Display()
    End Sub

    Private Sub miTotalFees_Click(sender As Object, e As EventArgs) Handles miTotalFees.Click
        MessageBox.Show(String.Format("Total fees: {0:C}", Layer.TotalFees))
    End Sub


    Private Sub miExit_Click(sender As Object, e As EventArgs) Handles miExit.Click
        Close()
    End Sub

End Class
