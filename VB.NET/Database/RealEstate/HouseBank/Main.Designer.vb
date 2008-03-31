<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Me.lblPersian = New System.Windows.Forms.Label
        Me.lblGregorian = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.tmrDate = New System.Windows.Forms.Timer(Me.components)
        Me.btnLand = New System.Windows.Forms.Button
        Me.btnBase = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnBackup = New System.Windows.Forms.Button
        Me.btnPw = New System.Windows.Forms.Button
        Me.btnAbout = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnProtect = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblPersian
        '
        Me.lblPersian.AutoSize = True
        Me.lblPersian.Location = New System.Drawing.Point(12, 9)
        Me.lblPersian.Name = "lblPersian"
        Me.lblPersian.Size = New System.Drawing.Size(42, 13)
        Me.lblPersian.TabIndex = 0
        Me.lblPersian.Text = "Persian"
        '
        'lblGregorian
        '
        Me.lblGregorian.AutoSize = True
        Me.lblGregorian.Location = New System.Drawing.Point(12, 35)
        Me.lblGregorian.Name = "lblGregorian"
        Me.lblGregorian.Size = New System.Drawing.Size(54, 13)
        Me.lblGregorian.TabIndex = 1
        Me.lblGregorian.Text = "Gregorian"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 63)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(29, 13)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time"
        '
        'tmrDate
        '
        Me.tmrDate.Enabled = True
        Me.tmrDate.Interval = 1000
        '
        'btnLand
        '
        Me.btnLand.Location = New System.Drawing.Point(142, 12)
        Me.btnLand.Name = "btnLand"
        Me.btnLand.Size = New System.Drawing.Size(173, 46)
        Me.btnLand.TabIndex = 0
        Me.btnLand.Text = "«„·«ò"
        Me.btnLand.UseVisualStyleBackColor = True
        '
        'btnBase
        '
        Me.btnBase.Location = New System.Drawing.Point(142, 64)
        Me.btnBase.Name = "btnBase"
        Me.btnBase.Size = New System.Drawing.Size(173, 46)
        Me.btnBase.TabIndex = 1
        Me.btnBase.Text = "«ÿ·«⁄«  Å«ÌÂ"
        Me.btnBase.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(142, 116)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(173, 46)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "»Â —Ê“ —”«‰Ì"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(142, 168)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(173, 46)
        Me.btnBackup.TabIndex = 3
        Me.btnBackup.Text = " ÂÌÂ / »«“Ì«»Ì Å‘ Ì»«‰"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnPw
        '
        Me.btnPw.Location = New System.Drawing.Point(142, 220)
        Me.btnPw.Name = "btnPw"
        Me.btnPw.Size = New System.Drawing.Size(173, 46)
        Me.btnPw.TabIndex = 4
        Me.btnPw.Text = "—„“ ⁄»Ê—"
        Me.btnPw.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(142, 272)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(173, 46)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "œ—»«—Â"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(142, 324)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(173, 46)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Œ—ÊÃ"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnProtect
        '
        Me.btnProtect.Location = New System.Drawing.Point(12, 87)
        Me.btnProtect.Name = "btnProtect"
        Me.btnProtect.Size = New System.Drawing.Size(54, 23)
        Me.btnProtect.TabIndex = 7
        Me.btnProtect.Text = "„Õ«›Ÿ "
        Me.btnProtect.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 386)
        Me.Controls.Add(Me.btnProtect)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnPw)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnBase)
        Me.Controls.Add(Me.btnLand)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblGregorian)
        Me.Controls.Add(Me.lblPersian)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "House Bank v1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPersian As System.Windows.Forms.Label
    Friend WithEvents lblGregorian As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tmrDate As System.Windows.Forms.Timer
    Friend WithEvents btnLand As System.Windows.Forms.Button
    Friend WithEvents btnBase As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnPw As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnProtect As System.Windows.Forms.Button

End Class
