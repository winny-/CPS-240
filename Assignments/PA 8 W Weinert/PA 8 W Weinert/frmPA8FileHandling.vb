'*****************************************************************
'PA 8: File Handling
'Name: Winston Weinert
'Help recieved: None
'Self-assessment: it works and I expect to recieve full credit
'*****************************************************************

Option Strict On

Public Class frmPA8FileHandling

    Public Property LogicLayer As New LogicLayer()

    Public ReadOnly Property Selected As Person
        Get
            Return TryCast(lstPeople.SelectedItem, Person)
        End Get
    End Property

    Private _GiveFormat As String
    Private _FilenameFormat As String

    Public Sub Display()
        btnGiveMoneyToRandomPerson.Text = String.Format(_GiveFormat, LogicLayer.CashGiftAmount)
        lblFileName.Text = String.Format(_FilenameFormat, LogicLayer.FilenameOnly, If(LogicLayer.CanCloseWithoutSaving,
                                                                                      "",
                                                                                      " *unsaved*"))

        Dim selected As Person = Me.Selected
        lstPeople.Items.Clear()
        For Each p As Person In LogicLayer.Persons
            lstPeople.Items.Add(p)
        Next
        lstPeople.SelectedItem = selected

        lstPeople.Enabled = LogicLayer.HaveFile
        gbMutateData.Enabled = LogicLayer.HaveFile
        btnSave.Enabled = LogicLayer.HaveFile
        miCloseFile.Enabled = LogicLayer.HaveFile
        btnRemovePerson.Enabled = Me.Selected IsNot Nothing
    End Sub

    Private Sub lstPeople_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPeople.SelectedIndexChanged
        btnRemovePerson.Enabled = Selected IsNot Nothing
    End Sub

    Private Sub frmPA8FileHandling_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not CloseDocument() Then e.Cancel = True
    End Sub

    Private Sub frmPA8FileHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _GiveFormat = btnGiveMoneyToRandomPerson.Text
        _FilenameFormat = lblFileName.Text
        Display()
    End Sub

    Private Sub miNewFile_Click(sender As Object, e As EventArgs) Handles miNewFile.Click
        If Not CloseDocument() Then Return
        Dim res As DialogResult = sfdChooseNewFilename.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            LogicLayer.CloseFile()
            LogicLayer.NewFile(sfdChooseNewFilename.FileName)
        End If
        Display()
    End Sub

    Private Function CloseDocument() As Boolean
        Dim continueOperation As Boolean = True
        If Not LogicLayer.CanCloseWithoutSaving Then
            Dim res As DialogResult = MessageBox.Show(text:=String.Format("Save file ""{0}"" before closing?", LogicLayer.FilenameOnly),
                                          caption:="Unwritten changes",
                                          buttons:=MessageBoxButtons.YesNoCancel,
                                          icon:=MessageBoxIcon.Question)
            Select Case res
                Case Windows.Forms.DialogResult.Yes
                    continueOperation = LogicLayer.SaveFile()
                    If Not continueOperation Then
                        MessageBox.Show(text:="Could not save file.", caption:="Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                    End If
                Case Windows.Forms.DialogResult.No
                    continueOperation = True
                Case Windows.Forms.DialogResult.Cancel, Windows.Forms.DialogResult.None
                    continueOperation = False
                Case Else
                    Debug.Fail("Should not have reached this line.")
            End Select
        End If
        If continueOperation Then LogicLayer.CloseFile()
        Display()
        Return continueOperation
    End Function

    Private Sub miOpenFile_Click(sender As Object, e As EventArgs) Handles miOpenFile.Click
        If Not CloseDocument() Then Return
        Dim res As DialogResult = ofdOpenFile.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            LogicLayer.CloseFile()
            If Not LogicLayer.OpenFile(ofdOpenFile.FileName) Then
                MessageBox.Show("File appears to be damaged, will overwrite on save.")
            End If
        End If
        Display()
    End Sub

    Private Sub miCloseFile_Click(sender As Object, e As EventArgs) Handles miCloseFile.Click
        CloseDocument()
        Display()
    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles _
        miExit.Click,
        btnExit.Click

        Me.Close()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles _
        btnSave.Click,
        miSaveFile.Click

        LogicLayer.SaveFile()
        Display()
    End Sub

    Private Sub btnAddPerson_Click(sender As Object, e As EventArgs) Handles btnAddPerson.Click
        Dim name As String = txtName.Text
        If Not Person.ValidateName(name) Then
            MessageBox.Show("Please enter a valid name, only letters, no spaces, symbols, or numbers.")
            txtName.SelectAll()
            txtName.Focus()
        Else
            If Not LogicLayer.AddPeson(txtName.Text) Then
                MessageBox.Show("Name already exists, please choose another name.")
                txtName.SelectAll()
                txtName.Focus()
            End If
        End If
        Display()
    End Sub

    Private Sub btnRemovePerson_Click(sender As Object, e As EventArgs) Handles btnRemovePerson.Click
        Dim p As Person = Selected
        If p IsNot Nothing Then LogicLayer.RemovePerson(p)
        Display()
    End Sub

    Private Sub btnGiveMoneyToRandomPerson_Click(sender As Object, e As EventArgs) Handles btnGiveMoneyToRandomPerson.Click
        LogicLayer.GiveRandomPersonRandomGift()
        Display()
    End Sub

    Private Sub miChangeRandomGiftAmount_Click(sender As Object, e As EventArgs) Handles miChangeRandomGiftAmount.Click
        Dim a As Decimal
        If Decimal.TryParse(InputBox("Input the amount to give as a random gift."), a) AndAlso Person.ValidateCash(a) AndAlso a > 0 Then
            LogicLayer.CashGiftAmount = a
        Else
            MessageBox.Show("Bad number. Must be greater than zero and have up to two decimal places.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Display()
    End Sub

End Class
