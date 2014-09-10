<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShippingProblem
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
        Me.lblShippingCostTitle = New System.Windows.Forms.Label()
        Me.gbInputs = New System.Windows.Forms.GroupBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtOunces = New System.Windows.Forms.TextBox()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblOunces = New System.Windows.Forms.Label()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbSummary = New System.Windows.Forms.GroupBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtTotalWeight = New System.Windows.Forms.TextBox()
        Me.lblTotalWeight = New System.Windows.Forms.Label()
        Me.lstSummary = New System.Windows.Forms.ListBox()
        Me.btnCanculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAssignmentName = New System.Windows.Forms.Label()
        Me.chkLiveUpdate = New System.Windows.Forms.CheckBox()
        Me.gbInputs.SuspendLayout()
        Me.gbSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblShippingCostTitle
        '
        Me.lblShippingCostTitle.AutoSize = True
        Me.lblShippingCostTitle.Location = New System.Drawing.Point(178, 9)
        Me.lblShippingCostTitle.Name = "lblShippingCostTitle"
        Me.lblShippingCostTitle.Size = New System.Drawing.Size(72, 13)
        Me.lblShippingCostTitle.TabIndex = 0
        Me.lblShippingCostTitle.Text = "Shipping Cost"
        '
        'gbInputs
        '
        Me.gbInputs.Controls.Add(Me.txtCost)
        Me.gbInputs.Controls.Add(Me.txtOunces)
        Me.gbInputs.Controls.Add(Me.txtPounds)
        Me.gbInputs.Controls.Add(Me.txtID)
        Me.gbInputs.Controls.Add(Me.lblCost)
        Me.gbInputs.Controls.Add(Me.lblOunces)
        Me.gbInputs.Controls.Add(Me.lblPounds)
        Me.gbInputs.Controls.Add(Me.lblID)
        Me.gbInputs.Location = New System.Drawing.Point(12, 32)
        Me.gbInputs.Name = "gbInputs"
        Me.gbInputs.Size = New System.Drawing.Size(200, 134)
        Me.gbInputs.TabIndex = 1
        Me.gbInputs.TabStop = False
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(51, 108)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 7
        '
        'txtOunces
        '
        Me.txtOunces.Location = New System.Drawing.Point(51, 77)
        Me.txtOunces.Name = "txtOunces"
        Me.txtOunces.Size = New System.Drawing.Size(100, 20)
        Me.txtOunces.TabIndex = 6
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(51, 47)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(100, 20)
        Me.txtPounds.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(51, 17)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 4
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(6, 110)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(28, 13)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Cost"
        '
        'lblOunces
        '
        Me.lblOunces.AutoSize = True
        Me.lblOunces.Location = New System.Drawing.Point(6, 80)
        Me.lblOunces.Name = "lblOunces"
        Me.lblOunces.Size = New System.Drawing.Size(44, 13)
        Me.lblOunces.TabIndex = 2
        Me.lblOunces.Text = "&Ounces"
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Location = New System.Drawing.Point(6, 50)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(43, 13)
        Me.lblPounds.TabIndex = 1
        Me.lblPounds.Text = "&Pounds"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 20)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'gbSummary
        '
        Me.gbSummary.Controls.Add(Me.txtTotalCost)
        Me.gbSummary.Controls.Add(Me.lblTotalCost)
        Me.gbSummary.Controls.Add(Me.txtTotalWeight)
        Me.gbSummary.Controls.Add(Me.lblTotalWeight)
        Me.gbSummary.Location = New System.Drawing.Point(12, 172)
        Me.gbSummary.Name = "gbSummary"
        Me.gbSummary.Size = New System.Drawing.Size(408, 55)
        Me.gbSummary.TabIndex = 2
        Me.gbSummary.TabStop = False
        Me.gbSummary.Text = "Summary"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(275, 22)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 3
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(214, 25)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(55, 13)
        Me.lblTotalCost.TabIndex = 2
        Me.lblTotalCost.Text = "Total Cost"
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.Location = New System.Drawing.Point(88, 22)
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.ReadOnly = True
        Me.txtTotalWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalWeight.TabIndex = 1
        '
        'lblTotalWeight
        '
        Me.lblTotalWeight.AutoSize = True
        Me.lblTotalWeight.Location = New System.Drawing.Point(21, 25)
        Me.lblTotalWeight.Name = "lblTotalWeight"
        Me.lblTotalWeight.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalWeight.TabIndex = 0
        Me.lblTotalWeight.Text = "Total Weight"
        '
        'lstSummary
        '
        Me.lstSummary.FormattingEnabled = True
        Me.lstSummary.Location = New System.Drawing.Point(225, 32)
        Me.lstSummary.Name = "lstSummary"
        Me.lstSummary.Size = New System.Drawing.Size(185, 134)
        Me.lstSummary.TabIndex = 3
        '
        'btnCanculate
        '
        Me.btnCanculate.Location = New System.Drawing.Point(74, 243)
        Me.btnCanculate.Name = "btnCanculate"
        Me.btnCanculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCanculate.TabIndex = 4
        Me.btnCanculate.Text = "&Calculate"
        Me.btnCanculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(175, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(276, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAssignmentName
        '
        Me.lblAssignmentName.AutoSize = True
        Me.lblAssignmentName.Location = New System.Drawing.Point(298, 281)
        Me.lblAssignmentName.Name = "lblAssignmentName"
        Me.lblAssignmentName.Size = New System.Drawing.Size(126, 13)
        Me.lblAssignmentName.TabIndex = 7
        Me.lblAssignmentName.Text = "PA 2 by Winston Weinert"
        '
        'chkLiveUpdate
        '
        Me.chkLiveUpdate.AutoSize = True
        Me.chkLiveUpdate.Location = New System.Drawing.Point(12, 280)
        Me.chkLiveUpdate.Name = "chkLiveUpdate"
        Me.chkLiveUpdate.Size = New System.Drawing.Size(84, 17)
        Me.chkLiveUpdate.TabIndex = 8
        Me.chkLiveUpdate.Text = "&Live Update"
        Me.chkLiveUpdate.UseVisualStyleBackColor = True
        '
        'frmShippingProblem
        '
        Me.AcceptButton = Me.btnCanculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 303)
        Me.Controls.Add(Me.chkLiveUpdate)
        Me.Controls.Add(Me.lblAssignmentName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCanculate)
        Me.Controls.Add(Me.lstSummary)
        Me.Controls.Add(Me.gbSummary)
        Me.Controls.Add(Me.gbInputs)
        Me.Controls.Add(Me.lblShippingCostTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmShippingProblem"
        Me.Text = "The Shipping Problem"
        Me.gbInputs.ResumeLayout(False)
        Me.gbInputs.PerformLayout()
        Me.gbSummary.ResumeLayout(False)
        Me.gbSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblShippingCostTitle As System.Windows.Forms.Label
    Friend WithEvents gbInputs As System.Windows.Forms.GroupBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtOunces As System.Windows.Forms.TextBox
    Friend WithEvents txtPounds As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblOunces As System.Windows.Forms.Label
    Friend WithEvents lblPounds As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents gbSummary As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtTotalWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalWeight As System.Windows.Forms.Label
    Friend WithEvents lstSummary As System.Windows.Forms.ListBox
    Friend WithEvents btnCanculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAssignmentName As System.Windows.Forms.Label
    Friend WithEvents chkLiveUpdate As System.Windows.Forms.CheckBox

End Class
