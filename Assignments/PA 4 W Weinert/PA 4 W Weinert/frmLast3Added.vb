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
    Private Const CHANGE_MAX_PEOPLE_MENU_TEXT As String = "Change &max people ({0})"

    Private totalPeopleAdded As Integer = 0

    'Don't assign to this, use the property below!
    Private _maxPeople As Integer

    Private Property maxPeople As Integer
        Get
            Return _maxPeople
        End Get
        Set(value As Integer)
            _maxPeople = value
            miChangeMaxPeople.Text = String.Format(CHANGE_MAX_PEOPLE_MENU_TEXT, maxPeople)
            'Remove excess people in lstPeople after max people is changed.
            Do While lstPeople.Items.Count > maxPeople
                lstPeople.Items.RemoveAt(0)
            Loop
        End Set
    End Property

    '*****************************************************************
    'The main business logic
    '*****************************************************************

    Private Sub addPerson(ByVal p As Person)
        Debug.Assert(lstPeople.Items.Count <= maxPeople)

        txtNameInput.Clear()
        txtAgeInput.Clear()
        txtNameInput.Focus()

        'This should satisfy the extra credit requirements.
        If lstPeople.Items.Count = maxPeople Then
            lstPeople.Items.RemoveAt(0)
        End If

        lstPeople.Items.Add(p)
        lstPeople.SelectedItem = p

        totalPeopleAdded += 1
    End Sub

    Private Function nameIsUnique(ByVal name As String) As Boolean
        For Each p As Person In lstPeople.Items
            If p.Name = name Then Return False
        Next
        Return True
    End Function

    Private Function validateAndParseInputs(ByRef p As Person) As Boolean
        Dim name As String = txtNameInput.Text
        Dim age As String = txtAgeInput.Text
        Dim parseable As Boolean = Person.TryParse(name, age, p)
        Dim uniqueName As Boolean = nameIsUnique(name)
        Dim validInput As Boolean = parseable AndAlso uniqueName

        If Not validInput Then
            Dim validName As Boolean = Person.NameIsValid(name)
            Dim validAge As Boolean = Person.AgeIsValid(age)

            Dim errors As New List(Of String)

            Dim focusMe As Control = Nothing

            If Not validName OrElse Not uniqueName Then
                If Not validName Then errors.Add(String.Format("Invalid name ""{0}"".", name))
                If Not uniqueName Then errors.Add(String.Format("A person with name ""{0}"" has already been added. Please choose a unique name.", name))
                focusMe = CType(txtNameInput, Control)
            End If

            If Not validAge Then
                errors.Add(String.Format("Invalid age ""{0}"".", age))
                If focusMe Is Nothing Then focusMe = CType(txtAgeInput, Control)
            End If

            MessageBox.Show(text:=String.Join(" ", errors),
                            caption:="Error: invalid input",
                            buttons:=MessageBoxButtons.OK,
                            icon:=MessageBoxIcon.Error)
            focusMe.Focus()
        End If

        Return validInput
    End Function

    '*****************************************************************
    'Event handlers
    '*****************************************************************

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim p As Person = Nothing

        If Not validateAndParseInputs(p) Then Return

        addPerson(p)
    End Sub

    Private Sub lstPeople_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPeople.SelectedIndexChanged
        Dim selected As Object = lstPeople.SelectedItem
        If selected Is Nothing Then Return
        Dim p = CType(selected, Person) 'Don't hide a conversion error
        txtNameDetail.Text = p.Name
        txtAgeDetail.Text = p.Age.ToString()
    End Sub

    Private Sub miCount_Click(sender As Object, e As EventArgs) Handles miCount.Click
        MessageBox.Show(text:=totalPeopleAdded.ToString & " persons have been added.",
                        caption:="Total Count",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Information)
    End Sub

    Private Sub miChangeMaxPeople_Click(sender As Object, e As EventArgs) Handles miChangeMaxPeople.Click
        maxPeople = frmNumberPrompt.ShowDialogForInteger("Input a number", "Change max people", maxPeople)
    End Sub

    '*****************************************************************

    Private Sub textbox_Focused(sender As Object, e As EventArgs) Handles _
        txtNameInput.GotFocus,
        txtAgeInput.GotFocus,
        txtNameDetail.GotFocus,
        txtAgeDetail.GotFocus

        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub exit_Click(sender As Object, e As EventArgs) Handles _
        btnExit.Click,
        miExit.Click

        Me.Close()
    End Sub

    Private Sub frmLast3Added_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maxPeople = DEFAULT_MAX_PEOPLE
    End Sub

End Class
