<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMax
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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtGreatestNumber = New System.Windows.Forms.TextBox()
        Me.btnWinnyMax = New System.Windows.Forms.Button()
        Me.btnWrongCarlMax = New System.Windows.Forms.Button()
        Me.btnFixedCarlMax = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(12, 12)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(12, 38)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 1
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(12, 64)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 20)
        Me.txtC.TabIndex = 2
        '
        'txtGreatestNumber
        '
        Me.txtGreatestNumber.Location = New System.Drawing.Point(12, 90)
        Me.txtGreatestNumber.Name = "txtGreatestNumber"
        Me.txtGreatestNumber.ReadOnly = True
        Me.txtGreatestNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtGreatestNumber.TabIndex = 3
        '
        'btnWinnyMax
        '
        Me.btnWinnyMax.Location = New System.Drawing.Point(12, 116)
        Me.btnWinnyMax.Name = "btnWinnyMax"
        Me.btnWinnyMax.Size = New System.Drawing.Size(99, 23)
        Me.btnWinnyMax.TabIndex = 4
        Me.btnWinnyMax.Text = "Winny &Max"
        Me.btnWinnyMax.UseVisualStyleBackColor = True
        '
        'btnWrongCarlMax
        '
        Me.btnWrongCarlMax.Location = New System.Drawing.Point(12, 145)
        Me.btnWrongCarlMax.Name = "btnWrongCarlMax"
        Me.btnWrongCarlMax.Size = New System.Drawing.Size(99, 23)
        Me.btnWrongCarlMax.TabIndex = 5
        Me.btnWrongCarlMax.Text = "Wrong &Carl Max"
        Me.btnWrongCarlMax.UseVisualStyleBackColor = True
        '
        'btnFixedCarlMax
        '
        Me.btnFixedCarlMax.Location = New System.Drawing.Point(12, 174)
        Me.btnFixedCarlMax.Name = "btnFixedCarlMax"
        Me.btnFixedCarlMax.Size = New System.Drawing.Size(100, 23)
        Me.btnFixedCarlMax.TabIndex = 6
        Me.btnFixedCarlMax.Text = "&Fixed Carl Max"
        Me.btnFixedCarlMax.UseVisualStyleBackColor = True
        '
        'frmMax
        '
        Me.AcceptButton = Me.btnWinnyMax
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(123, 207)
        Me.Controls.Add(Me.btnFixedCarlMax)
        Me.Controls.Add(Me.btnWrongCarlMax)
        Me.Controls.Add(Me.btnWinnyMax)
        Me.Controls.Add(Me.txtGreatestNumber)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMax"
        Me.Text = "Max 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtGreatestNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnWinnyMax As System.Windows.Forms.Button
    Friend WithEvents btnWrongCarlMax As System.Windows.Forms.Button
    Friend WithEvents btnFixedCarlMax As System.Windows.Forms.Button

End Class
