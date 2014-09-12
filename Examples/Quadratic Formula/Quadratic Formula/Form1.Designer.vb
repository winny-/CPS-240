<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuadraticFormula
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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.picQuadraticFormula = New System.Windows.Forms.PictureBox()
        Me.gbInputs = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.txtDiscriminant = New System.Windows.Forms.TextBox()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.lblX1 = New System.Windows.Forms.Label()
        Me.lblDiscriminant = New System.Windows.Forms.Label()
        Me.txtSolutions = New System.Windows.Forms.TextBox()
        Me.lblSolutions = New System.Windows.Forms.Label()
        CType(Me.picQuadraticFormula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInputs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(50, 222)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "C&ompute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(26, 17)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(22, 13)
        Me.lblA.TabIndex = 0
        Me.lblA.Text = "&a ="
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(26, 43)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(22, 13)
        Me.lblB.TabIndex = 2
        Me.lblB.Text = "&b ="
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(26, 69)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(22, 13)
        Me.lblC.TabIndex = 4
        Me.lblC.Text = "&c ="
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(54, 14)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(78, 20)
        Me.txtA.TabIndex = 1
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(54, 40)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(78, 20)
        Me.txtB.TabIndex = 3
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(54, 66)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(78, 20)
        Me.txtC.TabIndex = 5
        '
        'picQuadraticFormula
        '
        Me.picQuadraticFormula.Image = Global.Quadratic_Formula.My.Resources.Resources.Quadratic_Formula
        Me.picQuadraticFormula.Location = New System.Drawing.Point(66, 12)
        Me.picQuadraticFormula.Name = "picQuadraticFormula"
        Me.picQuadraticFormula.Size = New System.Drawing.Size(268, 73)
        Me.picQuadraticFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQuadraticFormula.TabIndex = 0
        Me.picQuadraticFormula.TabStop = False
        '
        'gbInputs
        '
        Me.gbInputs.Controls.Add(Me.txtB)
        Me.gbInputs.Controls.Add(Me.lblA)
        Me.gbInputs.Controls.Add(Me.txtC)
        Me.gbInputs.Controls.Add(Me.lblB)
        Me.gbInputs.Controls.Add(Me.lblC)
        Me.gbInputs.Controls.Add(Me.txtA)
        Me.gbInputs.Location = New System.Drawing.Point(12, 100)
        Me.gbInputs.Name = "gbInputs"
        Me.gbInputs.Size = New System.Drawing.Size(160, 100)
        Me.gbInputs.TabIndex = 0
        Me.gbInputs.TabStop = False
        Me.gbInputs.Text = "Inputs"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtX2)
        Me.GroupBox1.Controls.Add(Me.txtX1)
        Me.GroupBox1.Controls.Add(Me.txtDiscriminant)
        Me.GroupBox1.Controls.Add(Me.lblX2)
        Me.GroupBox1.Controls.Add(Me.lblX1)
        Me.GroupBox1.Controls.Add(Me.lblDiscriminant)
        Me.GroupBox1.Controls.Add(Me.txtSolutions)
        Me.GroupBox1.Controls.Add(Me.lblSolutions)
        Me.GroupBox1.Location = New System.Drawing.Point(188, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 161)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(82, 119)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.ReadOnly = True
        Me.txtX2.Size = New System.Drawing.Size(115, 20)
        Me.txtX2.TabIndex = 7
        Me.txtX2.TabStop = False
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(82, 85)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.ReadOnly = True
        Me.txtX1.Size = New System.Drawing.Size(115, 20)
        Me.txtX1.TabIndex = 5
        Me.txtX1.TabStop = False
        '
        'txtDiscriminant
        '
        Me.txtDiscriminant.Location = New System.Drawing.Point(82, 51)
        Me.txtDiscriminant.Name = "txtDiscriminant"
        Me.txtDiscriminant.ReadOnly = True
        Me.txtDiscriminant.Size = New System.Drawing.Size(115, 20)
        Me.txtDiscriminant.TabIndex = 3
        Me.txtDiscriminant.TabStop = False
        '
        'lblX2
        '
        Me.lblX2.AutoSize = True
        Me.lblX2.Location = New System.Drawing.Point(15, 122)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(27, 13)
        Me.lblX2.TabIndex = 6
        Me.lblX2.Text = "x&2 ="
        '
        'lblX1
        '
        Me.lblX1.AutoSize = True
        Me.lblX1.Location = New System.Drawing.Point(15, 88)
        Me.lblX1.Name = "lblX1"
        Me.lblX1.Size = New System.Drawing.Size(27, 13)
        Me.lblX1.TabIndex = 4
        Me.lblX1.Text = "x&1 ="
        '
        'lblDiscriminant
        '
        Me.lblDiscriminant.AutoSize = True
        Me.lblDiscriminant.Location = New System.Drawing.Point(12, 54)
        Me.lblDiscriminant.Name = "lblDiscriminant"
        Me.lblDiscriminant.Size = New System.Drawing.Size(64, 13)
        Me.lblDiscriminant.TabIndex = 2
        Me.lblDiscriminant.Text = "&Discriminant"
        '
        'txtSolutions
        '
        Me.txtSolutions.Location = New System.Drawing.Point(82, 17)
        Me.txtSolutions.Name = "txtSolutions"
        Me.txtSolutions.ReadOnly = True
        Me.txtSolutions.Size = New System.Drawing.Size(115, 20)
        Me.txtSolutions.TabIndex = 1
        Me.txtSolutions.TabStop = False
        '
        'lblSolutions
        '
        Me.lblSolutions.AutoSize = True
        Me.lblSolutions.Location = New System.Drawing.Point(9, 20)
        Me.lblSolutions.Name = "lblSolutions"
        Me.lblSolutions.Size = New System.Drawing.Size(50, 13)
        Me.lblSolutions.TabIndex = 0
        Me.lblSolutions.Text = "&Solutions"
        '
        'frmQuadraticFormula
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 273)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbInputs)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.picQuadraticFormula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmQuadraticFormula"
        Me.Text = "Quadratic Formula"
        CType(Me.picQuadraticFormula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInputs.ResumeLayout(False)
        Me.gbInputs.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picQuadraticFormula As System.Windows.Forms.PictureBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents gbInputs As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtX2 As System.Windows.Forms.TextBox
    Friend WithEvents txtX1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscriminant As System.Windows.Forms.TextBox
    Friend WithEvents lblX2 As System.Windows.Forms.Label
    Friend WithEvents lblX1 As System.Windows.Forms.Label
    Friend WithEvents lblDiscriminant As System.Windows.Forms.Label
    Friend WithEvents txtSolutions As System.Windows.Forms.TextBox
    Friend WithEvents lblSolutions As System.Windows.Forms.Label

End Class
