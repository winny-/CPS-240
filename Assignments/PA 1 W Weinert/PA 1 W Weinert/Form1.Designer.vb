<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoinProblem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEnterChange = New System.Windows.Forms.Label()
        Me.txtChangeInput = New System.Windows.Forms.TextBox()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.txtQuartersOutput = New System.Windows.Forms.TextBox()
        Me.txtDimesOutput = New System.Windows.Forms.TextBox()
        Me.txtNickelsOutput = New System.Windows.Forms.TextBox()
        Me.txtPenniesOutput = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PA 1 by Winston Weinert"
        '
        'lblEnterChange
        '
        Me.lblEnterChange.AutoSize = True
        Me.lblEnterChange.Location = New System.Drawing.Point(12, 13)
        Me.lblEnterChange.Name = "lblEnterChange"
        Me.lblEnterChange.Size = New System.Drawing.Size(132, 13)
        Me.lblEnterChange.TabIndex = 1
        Me.lblEnterChange.Text = "Enter the change in cents:"
        '
        'txtChangeInput
        '
        Me.txtChangeInput.Location = New System.Drawing.Point(150, 10)
        Me.txtChangeInput.Name = "txtChangeInput"
        Me.txtChangeInput.Size = New System.Drawing.Size(54, 20)
        Me.txtChangeInput.TabIndex = 1
        Me.txtChangeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(40, 46)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(50, 13)
        Me.lblQuarters.TabIndex = 3
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(40, 76)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(39, 13)
        Me.lblDimes.TabIndex = 5
        Me.lblDimes.Text = "Dimes:"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(40, 106)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(45, 13)
        Me.lblNickels.TabIndex = 7
        Me.lblNickels.Text = "Nickels:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(40, 136)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(48, 13)
        Me.lblPennies.TabIndex = 9
        Me.lblPennies.Text = "Pennies:"
        '
        'txtQuartersOutput
        '
        Me.txtQuartersOutput.Location = New System.Drawing.Point(96, 43)
        Me.txtQuartersOutput.Name = "txtQuartersOutput"
        Me.txtQuartersOutput.ReadOnly = True
        Me.txtQuartersOutput.Size = New System.Drawing.Size(30, 20)
        Me.txtQuartersOutput.TabIndex = 4
        Me.txtQuartersOutput.TabStop = False
        Me.txtQuartersOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDimesOutput
        '
        Me.txtDimesOutput.Location = New System.Drawing.Point(96, 73)
        Me.txtDimesOutput.Name = "txtDimesOutput"
        Me.txtDimesOutput.ReadOnly = True
        Me.txtDimesOutput.Size = New System.Drawing.Size(30, 20)
        Me.txtDimesOutput.TabIndex = 5
        Me.txtDimesOutput.TabStop = False
        Me.txtDimesOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNickelsOutput
        '
        Me.txtNickelsOutput.Location = New System.Drawing.Point(96, 103)
        Me.txtNickelsOutput.Name = "txtNickelsOutput"
        Me.txtNickelsOutput.ReadOnly = True
        Me.txtNickelsOutput.Size = New System.Drawing.Size(30, 20)
        Me.txtNickelsOutput.TabIndex = 6
        Me.txtNickelsOutput.TabStop = False
        Me.txtNickelsOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPenniesOutput
        '
        Me.txtPenniesOutput.Location = New System.Drawing.Point(96, 133)
        Me.txtPenniesOutput.Name = "txtPenniesOutput"
        Me.txtPenniesOutput.ReadOnly = True
        Me.txtPenniesOutput.Size = New System.Drawing.Size(30, 20)
        Me.txtPenniesOutput.TabIndex = 7
        Me.txtPenniesOutput.TabStop = False
        Me.txtPenniesOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(157, 56)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 2
        Me.btnChange.Text = "&Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(157, 114)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCoinProblem
        '
        Me.AcceptButton = Me.btnChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(250, 195)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtPenniesOutput)
        Me.Controls.Add(Me.txtNickelsOutput)
        Me.Controls.Add(Me.txtDimesOutput)
        Me.Controls.Add(Me.txtQuartersOutput)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.txtChangeInput)
        Me.Controls.Add(Me.lblEnterChange)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCoinProblem"
        Me.Text = "The Coin Problem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEnterChange As System.Windows.Forms.Label
    Friend WithEvents txtChangeInput As System.Windows.Forms.TextBox
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents txtQuartersOutput As System.Windows.Forms.TextBox
    Friend WithEvents txtDimesOutput As System.Windows.Forms.TextBox
    Friend WithEvents txtNickelsOutput As System.Windows.Forms.TextBox
    Friend WithEvents txtPenniesOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
