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
        For Each e As Person In lstPeople.Items
            If e.Name = p.Name Then
                MessageBox.Show(text:=String.Format("Person named ""{0}"" is already on the list. Please choose a different name.", p.Name),
                                caption:="Error: person already added",
                                buttons:=MessageBoxButtons.OK,
                                icon:=MessageBoxIcon.Error)
                Return
            End If
        Next

        'This should satisfy the extra credit requirements.
        If lstPeople.Items.Count = maxPeople Then
            If lstPeople.SelectedIndex = 0 Then
                lstPeople.SelectedIndex = 1
                lstPeople_SelectedIndexChanged(Nothing, Nothing)
            End If
            'This must come second because if the selected index is 0, and index 0 is removed, the selected index become -1.
            lstPeople.Items.RemoveAt(0)
        End If

        lstPeople.Items.Add(p)

        totalPeopleAdded += 1
    End Sub

    Private Function validateAndParseInputs(ByRef p As Person) As Boolean
        Dim validInput As Boolean = Person.TryParse(txtNameInput.Text, txtAgeInput.Text, p)

        If Not validInput Then
            Dim errors As New List(Of String)
            Dim validName As Boolean = Person.NameIsValid(txtNameInput.Text)

            If Not validName Then
                errors.Add(String.Format("Invalid name ""{0}"".", txtNameInput.Text))
                txtNameInput.Focus()
            End If

            If Not Person.AgeIsValid(txtAgeInput.Text) Then
                errors.Add(String.Format("Invalid age ""{0}"".", txtAgeInput.Text))
                If validName Then txtAgeInput.Focus() 'Don't take focus from the first invalid input
            End If

            MessageBox.Show(text:=String.Join(" ", errors),
                            caption:="Error: invalid input",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Error)
        End If

        Return validInput
    End Function

    Private Sub exit_Click(sender As Object, e As EventArgs) Handles _
        btnExit.Click,
        miExit.Click

        Me.Close()
    End Sub

    Private Sub textbox_Focused(sender As Object, e As EventArgs) Handles _
        txtNameInput.GotFocus,
        txtAgeInput.GotFocus,
        txtNameDetail.GotFocus,
        txtAgeDetail.GotFocus

        CType(sender, TextBox).SelectAll()
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

        If Not validateAndParseInputs(p) Then Return

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
        'Remove excess people in lstPeople after max people is changed.
        Do While lstPeople.Items.Count > maxPeople
            lstPeople.Items.RemoveAt(0)
        Loop
    End Sub

End Class
