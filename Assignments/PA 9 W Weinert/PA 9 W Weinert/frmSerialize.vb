Option Strict On

Public Class frmSerialize

    Private Property _LogicLayer As New LogicLayer()

    Private _WinnerFormat As String
    Private _TotalPlaysFormat As String
    Private _WindowTitleFormat As String
    Private _LastWinner As String = Nothing
    Private _FlashCount As Integer = 1

    Private Const NFlashes As Integer = 3

    Private Sub ValidateControls()
        pnlControlGame.Enabled = _LogicLayer.HaveFile
        miCloseFile.Enabled = _LogicLayer.HaveFile
        If _LogicLayer.HaveFile Then
            btnRemovePlayer.Enabled = dgvPlayers.SelectedRows.Count > 0 AndAlso
                dgvPlayers.SelectedRows(0) IsNot Nothing
            btnPlay.Enabled = _LogicLayer.Game.Players.Count > 0
        End If
    End Sub

    Private Sub DisplayPlayers()
        With dgvPlayers
            .Columns.Clear()
            .AutoGenerateColumns = True
            If _LogicLayer.HaveFile Then
                .DataSource = (From p As Player In _LogicLayer.Game.Players
                               Select
                                   Name = p.Name,
                                   Wins = p.Wins,
                                   Losses = p.Losses,
                                   PlayerObj = p
                                   Order By Name).ToList()
                .Columns(0).Width = 100
                .Columns(3).Visible = False 'Do not show the player object
            End If
        End With
    End Sub

    Private Sub DisplayText()
        lblWinner.Text = String.Format(_WinnerFormat, _LastWinner)
        tsslTotalPlays.Text = String.Format(_TotalPlaysFormat, If(_LogicLayer.Game Is Nothing,
                                                                  0,
                                                                  _LogicLayer.Game.TotalMatches))
        Me.Text = String.Format(_WindowTitleFormat, If(_LogicLayer.HaveFile,
                                                       String.Format(" :: {0}", _LogicLayer.ShortFileName),
                                                       ""))
    End Sub

    Private Sub Display()
        DisplayPlayers()
        ValidateControls() 'Must come after, so btnRemovePlayer is enabled on first open.
        DisplayText()
    End Sub

    Private Sub ShowWinner()
        _FlashCount = 0
        tmrWinnerFlash.Enabled = True
    End Sub

    Private Sub HideWinner()
        lblWinner.Visible = False
        tmrWinnerFlash.Enabled = False
    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles _
        miExit.Click,
        btnExit.Click

        Me.Close()
    End Sub

    Private Sub frmSerialize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _WinnerFormat = lblWinner.Text
        _TotalPlaysFormat = tsslTotalPlays.Text
        _WindowTitleFormat = Me.Text
        Display()
    End Sub

    Private Sub miCloseFile_Click(sender As Object, e As EventArgs) Handles miCloseFile.Click
        _LogicLayer.CloseFile()
        Display()
        HideWinner()
    End Sub

    Private Sub miOpenFile_Click(sender As Object, e As EventArgs) Handles miOpenFile.Click
        If ofdOpenFile.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return
        If Not _LogicLayer.OpenFile(ofdOpenFile.FileName) Then
            MessageBox.Show("Cannot open file")
        End If
        Display()
        HideWinner()
    End Sub

    Private Sub miNewFile_Click(sender As Object, e As EventArgs) Handles miNewFile.Click
        If sfdNewFile.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return
        If Not _LogicLayer.NewFile(sfdNewFile.FileName) Then
            MessageBox.Show("Cannot create new file.")
        End If
        Display()
        HideWinner()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim winner As Player = _LogicLayer.Play().Winner
        _LastWinner = winner.Name
        ShowWinner()
        Display()
    End Sub

    Private Sub tmrWinnerFlash_Tick(sender As Object, e As EventArgs) Handles tmrWinnerFlash.Tick
        lblWinner.Visible = Not lblWinner.Visible
        If Not lblWinner.Visible Then
            _FlashCount += 1
        ElseIf _FlashCount >= NFlashes Then
            Debug.Assert(lblWinner.Visible)
            tmrWinnerFlash.Enabled = False
            _FlashCount = 1
        End If
    End Sub

    Private Sub btnAddPlayer_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click
        Dim name As String = txtName.Text
        Dim ok As Boolean = True
        If Not Player.ValidateName(name) Then
            MessageBox.Show("Bad player name")
            ok = False
        ElseIf Not _LogicLayer.AddPlayer(New Player(name)) Then
            MessageBox.Show("Player name already exists")
            ok = False
        End If
        If ok Then
            txtName.Clear()
        Else
            With txtName
                .SelectAll()
                .Focus()
            End With
        End If
        HideWinner()
        Display()
    End Sub

    Private Sub btnRemovePlayer_Click(sender As Object, e As EventArgs) Handles btnRemovePlayer.Click
        Dim p As Player = TryCast(dgvPlayers.SelectedRows(0).Cells("PlayerObj").Value, Player)
        Debug.Assert(p IsNot Nothing)
        _LogicLayer.RemovePlayer(p)
        HideWinner()
        Display()
    End Sub

End Class
