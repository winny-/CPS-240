Public Class Form1

    Public sightings As New Collection

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim id As String = txtID.Text
        Dim quantityString As String = txtQuantity.Text
        Dim birdType As String = txtBirdType.Text
        Dim quantity As Integer
        If Not Integer.TryParse(quantityString, quantity) Then
            MessageBox.Show("Bad int")
            Return
        End If
        If id = String.Empty OrElse birdType = String.Empty Then
            MessageBox.Show("empty fields")
            Return
        End If
        Dim sighting As New CSighting()
        sighting.setID(id)
        sighting.quantity = quantity
        sighting.birdType = birdType
        sightings.Add(Key:=sighting.getID, Item:=sighting)
        Display()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim msg As String = Nothing
        If Not CData.writeToFile(sightings, msg) Then
            MessageBox.Show(msg)
        End If
        Display()
    End Sub


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim msg As String = Nothing
        If Not CData.readFromfile(sightings, msg) Then
            MessageBox.Show(msg)
        End If
        Display()
    End Sub

    Private Sub Display()
        lstSightings.Items.Clear()
        For Each obj As Object In sightings
            lstSightings.Items.Add(obj)
        Next
    End Sub
End Class
