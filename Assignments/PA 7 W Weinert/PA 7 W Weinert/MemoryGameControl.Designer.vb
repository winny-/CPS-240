<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemoryGameControl
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
        Me.components = New System.ComponentModel.Container()
        Me.Board = New System.Windows.Forms.FlowLayoutPanel()
        Me.tmrHideMisses = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Board
        '
        Me.Board.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Board.Location = New System.Drawing.Point(0, 0)
        Me.Board.Name = "Board"
        Me.Board.Size = New System.Drawing.Size(348, 254)
        Me.Board.TabIndex = 0
        '
        'Timer1
        '
        Me.tmrHideMisses.Interval = 750
        '
        'MemoryGameControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Board)
        Me.Name = "MemoryGameControl"
        Me.Size = New System.Drawing.Size(348, 254)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Board As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tmrHideMisses As System.Windows.Forms.Timer

End Class
