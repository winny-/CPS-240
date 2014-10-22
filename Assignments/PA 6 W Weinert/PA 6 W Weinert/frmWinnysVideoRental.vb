'*****************************************************************
'PA 6: Video Rental
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Imports PA_6_W_Weinert

Public Class frmWinnysVideoRental

    Private Structure UIMapEntry
        Public button As Button
        Public other As ListBox
    End Structure

    Private Layer As New BusinessAndDataLayer()
    Private UIMap As New Dictionary(Of ListBox, UIMapEntry)

    '*****************************************************************
    'GUI Helpers
    '*****************************************************************

    Private Sub ReDisplayListBox(ByVal box As ListBox, ByVal videos As List(Of Video))
        Dim selected As Video = TryCast(box.SelectedItem, Video)
        box.Items.Clear()
        videos.ForEach(Function(v As Video) box.Items.Add(v))
        'If selected is Nothing, is harmless. (Same as box.SelectedIndex = -1.)
        box.SelectedItem = selected
    End Sub

    Private Sub Display()
        ReDisplayListBox(lstAvailable, Layer.AvailableVideos)
        ReDisplayListBox(lstRented, Layer.RentedVideos)
        InvokeIndexChanged() 'Force an invocation
    End Sub

    Private Function GetSelectedItemAndSelectPrevious(ByVal box As ListBox) As Video
        Dim selected As Video = CType(box.SelectedItem, Video) 'Do not hide a conversion error.
        If box.Items.Count > 1 Then
            Dim selectedIndex As Integer = box.Items.IndexOf(selected)
            'If at head of ListBox, select the next item, otherwise select the previous item.
            box.SelectedIndex = If(selectedIndex = 0,
                                   1,
                                   selectedIndex - 1)
        End If
        Return selected
    End Function

    Private Sub InvokeIndexChanged()
        IndexChanged(lstAvailable, New EventArgs)
        IndexChanged(lstRented, New EventArgs)
    End Sub

    '*****************************************************************
    'Events
    '*****************************************************************

    Private Sub frmWinnysVideoRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UIMap.Add(lstAvailable, New UIMapEntry With {.button = btnRent,
                                                     .other = lstRented})
        UIMap.Add(lstRented, New UIMapEntry With {.button = btnReturn,
                                                  .other = lstAvailable})

        InvokeIndexChanged()
    End Sub

    '*****************************************************************
    'ListBox events
    '*****************************************************************

    Private Sub ListBox_GotFocus(sender As Object, e As EventArgs) Handles _
        lstAvailable.GotFocus,
        lstRented.GotFocus

        Dim thisBox As ListBox = CType(sender, ListBox) 'Do not hide a conversion error.

        'With the following code, only one ListBox has a Selected Item an one given point in time.
        'Additionally, select the first item. This way tabbing into the ListBox always selects something useful.
        If thisBox.SelectedIndex = -1 AndAlso thisBox.Items.Count > 0 Then
            thisBox.SelectedIndex = 0
        End If
        UIMap(thisBox).other.SelectedIndex = -1 'Remove selection from other ListBox.
        AcceptButton = If(thisBox.Items.Count > 0,
                          UIMap(thisBox).button,
                          Nothing)
    End Sub

    Private Sub IndexChanged(sender As Object, e As EventArgs) Handles _
        lstAvailable.SelectedIndexChanged,
        lstRented.SelectedIndexChanged

        Dim box As ListBox = CType(sender, ListBox)
        Dim hasSelectedItem As Boolean = box.SelectedIndex <> -1

        UIMap(box).button.Enabled = hasSelectedItem
    End Sub

    '*****************************************************************
    'Button events
    '*****************************************************************

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        Dim v As Video = GetSelectedItemAndSelectPrevious(lstAvailable)
        Layer.Rent(v)
        tsslLastAction.Text = String.Format("Rented ""{0}""", v)
        Display()
        'Not sure why this is necessary. Some odd behavior of the WinForm event handling.
        If lstAvailable.Items.Count = 0 Then lstRented.Focus()
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
        Dim v As Video = GetSelectedItemAndSelectPrevious(lstAvailable)
        Layer.Remove(v)
        Display()
    End Sub

    Private Sub miTotalFees_Click(sender As Object, e As EventArgs) Handles miTotalFees.Click
        MessageBox.Show(String.Format("Total fees: {0:C}", Layer.TotalFees))
    End Sub


    Private Sub miExit_Click(sender As Object, e As EventArgs) Handles miExit.Click
        Close()
    End Sub

End Class
