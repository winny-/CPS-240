'*****************************************************************
'PA 4: Last 3 Added
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Imports PA_4_W_Weinert

Public Class frmLast3Added

    Private Const DEFAULT_MAX_PEOPLE As Integer = 3

    Private totalPeopleAdded As Integer = 0
    Private maxPeople As Integer = DEFAULT_MAX_PEOPLE

    Private Sub addPerson(ByVal p As Person)
        Dim index As Integer = lstPeople.Items.Count
        If lstPeople.Items.Count = maxPeople Then
            index = totalPeopleAdded Mod maxPeople
            lstPeople.Items.RemoveAt(index)
        End If

        lstPeople.Items.Insert(index, p)

        totalPeopleAdded += 1
    End Sub

    Private Sub exit_Click(sender As Object, e As EventArgs) Handles _
        btnExit.Click,
        miExit.Click

        Me.Close()
    End Sub

    Private Sub lstPeople_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPeople.SelectedIndexChanged
        Dim selected As Object = lstPeople.SelectedItem
        If selected Is Nothing Then Return
        Dim p = CType(selected, Person) 'Don't hide a conversion error
        txtNameDetail.Text = p.Name
        txtAgeDetail.Text = p.Age.ToString()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim p As Person = Nothing
        If Not Person.TryParse(txtNameInput.Text, txtAgeInput.Text, p) Then
            MessageBox.Show("Invalid input")
            Return
        End If

        addPerson(p)
    End Sub

    Private Sub miCount_Click(sender As Object, e As EventArgs) Handles miCount.Click
        MessageBox.Show(text:=totalPeopleAdded.ToString & " persons have been added.",
                        caption:="Total Count",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Information)
    End Sub

    Private Sub ChangemaxPeopleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangemaxPeopleToolStripMenuItem.Click
        maxPeople = frmNumberPrompt.ShowDialogForInteger("Input a number", "Change the max people", maxPeople)
        Do While lstPeople.Items.Count > maxPeople
            lstPeople.Items.RemoveAt(lstPeople.Items.Count - 1)
        Loop
    End Sub

End Class
