Option Strict On

Imports PA_6_W_Weinert

Public Class frmWinnysVideoRental

    Private theLayer As New BusinessAndDataLayer()


    Private Sub Display()
        Dim availableSelected As Video = TryCast(lstAvailable.SelectedItem, Video)
        Dim rentedSelected As Video = TryCast(lstRented.SelectedItem, Video)
        lstAvailable.Items.Clear()
        lstRented.Items.Clear()
        For Each v As Video In theLayer.AvailableVideos
            lstAvailable.Items.Add(v)
        Next
        For Each v As Video In theLayer.RentedVideos
            lstRented.Items.Add(v)
        Next
        lstAvailable.SelectedItem = availableSelected
        lstRented.SelectedItem = rentedSelected
        IndexesChanged() 'Force an invocation
    End Sub

    Private Sub lstAvailable_Click(sender As Object, e As EventArgs) Handles lstAvailable.Click
        If lstAvailable.SelectedIndex <> -1 Then lstRented.SelectedIndex = -1
    End Sub

    Private Sub lstRented_Click(sender As Object, e As EventArgs) Handles lstRented.Click
        If lstRented.SelectedIndex <> -1 Then lstAvailable.SelectedIndex = -1
    End Sub

    Private Sub IndexesChanged() Handles _
        lstAvailable.SelectedIndexChanged,
        lstRented.SelectedIndexChanged

        btnRent.Enabled = lstAvailable.SelectedIndex <> -1
        btnReturn.Enabled = lstRented.SelectedIndex <> -1
    End Sub

    Private Sub miTotalFees_Click(sender As Object, e As EventArgs) Handles miTotalFees.Click
        MessageBox.Show(String.Format("Total fees: {0:C}", theLayer.TotalFees))
    End Sub


    Private Sub miExit_Click(sender As Object, e As EventArgs) Handles miExit.Click
        Close()
    End Sub

    Private Sub miAddMovie_Click(sender As Object, e As EventArgs) Handles miAddMovie.Click
        Dim title As String = InputBox("Input a title: ")
        If Not theLayer.TitleIsUnique(title) Then
            MessageBox.Show("Title is already in use.")
            Return
        End If
        If title = String.Empty Then Return
        theLayer.Add(New Video(title))
        Display()
    End Sub

    Private Sub frmWinnysVideoRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IndexesChanged()
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        Dim selected As Video = CType(lstAvailable.SelectedItem, Video)
        lstAvailable.SelectedIndex = If(lstAvailable.Items.Count > 1,
                                        Math.Max(lstAvailable.SelectedIndex - 1, 0),
                                        -1)
        theLayer.Rent(selected)
        tsslLastAction.Text = String.Format("Rented ""{0}""", selected)
        Display()
    End Sub


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim selected As Video = CType(lstRented.SelectedItem, Video)
        lstRented.SelectedIndex = If(lstRented.Items.Count > 1,
                                     Math.Max(lstRented.SelectedIndex - 1, 0),
                                     -1)
        lstRented.SelectedIndex = Math.Max(lstRented.SelectedIndex - 1, 0)
        Dim cost As Decimal = theLayer.Return_(selected)
        tsslLastAction.Text = String.Format("Returned ""{0}"" with {1:C} fee", selected, cost)
        Display()
    End Sub

    Private Sub miRemoveMovie_Click(sender As Object, e As EventArgs) Handles miRemoveMovie.Click
        If lstRented.SelectedIndex <> -1 Then
            MessageBox.Show("Please return the video before removing it.")
            Return
        End If
        If lstAvailable.SelectedIndex = -1 Then
            MessageBox.Show("No video selected to remove.")
            Return
        End If
        theLayer.Remove(CType(lstAvailable.SelectedItem, Video))
        Display()
    End Sub
End Class
