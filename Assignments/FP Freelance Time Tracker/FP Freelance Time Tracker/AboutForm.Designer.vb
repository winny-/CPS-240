<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Me.AboutWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'AboutWebBrowser
        '
        Me.AboutWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AboutWebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.AboutWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.AboutWebBrowser.Name = "AboutWebBrowser"
        Me.AboutWebBrowser.Size = New System.Drawing.Size(713, 626)
        Me.AboutWebBrowser.TabIndex = 0
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 626)
        Me.Controls.Add(Me.AboutWebBrowser)
        Me.MaximizeBox = False
        Me.Name = "AboutForm"
        Me.Text = "About Freelance Time Tracker"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AboutWebBrowser As System.Windows.Forms.WebBrowser
End Class
