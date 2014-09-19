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
        Me.btnMax = New System.Windows.Forms.Button()
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
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(22, 116)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(75, 23)
        Me.btnMax.TabIndex = 4
        Me.btnMax.Text = "&Max"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'frmMax
        '
        Me.AcceptButton = Me.btnMax
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(123, 147)
        Me.Controls.Add(Me.btnMax)
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
    Friend WithEvents btnMax As System.Windows.Forms.Button

End Class
