﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeEntryInfoBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.EntryDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entry &Date"
        '
        'EntryDateTextBox
        '
        Me.EntryDateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntryDateTextBox.Location = New System.Drawing.Point(21, 20)
        Me.EntryDateTextBox.Name = "EntryDateTextBox"
        Me.EntryDateTextBox.ReadOnly = True
        Me.EntryDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EntryDateTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Hours"
        '
        'HoursTextBox
        '
        Me.HoursTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HoursTextBox.Location = New System.Drawing.Point(21, 63)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.ReadOnly = True
        Me.HoursTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HoursTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Comment"
        '
        'CommentTextBox
        '
        Me.CommentTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommentTextBox.Location = New System.Drawing.Point(21, 103)
        Me.CommentTextBox.Multiline = True
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.ReadOnly = True
        Me.CommentTextBox.Size = New System.Drawing.Size(100, 40)
        Me.CommentTextBox.TabIndex = 5
        '
        'TimeEntryInfoBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CommentTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HoursTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EntryDateTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TimeEntryInfoBox"
        Me.Size = New System.Drawing.Size(131, 146)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EntryDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CommentTextBox As System.Windows.Forms.TextBox

End Class
