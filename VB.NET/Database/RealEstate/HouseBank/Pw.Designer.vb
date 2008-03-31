<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPw = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtPw
        '
        Me.txtPw.Location = New System.Drawing.Point(12, 12)
        Me.txtPw.Name = "txtPw"
        Me.txtPw.Size = New System.Drawing.Size(100, 20)
        Me.txtPw.TabIndex = 0
        Me.txtPw.UseSystemPasswordChar = True
        '
        'frmPw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(126, 46)
        Me.Controls.Add(Me.txtPw)
        Me.Name = "frmPw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ò·„Â ⁄»Ê—"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPw As System.Windows.Forms.TextBox
End Class
