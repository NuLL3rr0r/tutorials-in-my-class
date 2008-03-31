<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.chkNewRow = New System.Windows.Forms.CheckBox
        Me.dgvStudents = New System.Windows.Forms.DataGridView
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnShowAll = New System.Windows.Forms.Button
        Me.btnSearchName = New System.Windows.Forms.Button
        Me.btnSearchID = New System.Windows.Forms.Button
        Me.btnErase = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtMarkEdit = New System.Windows.Forms.TextBox
        Me.txtMarkAdd = New System.Windows.Forms.TextBox
        Me.txtNameEdit = New System.Windows.Forms.TextBox
        Me.txtSearchRealTime = New System.Windows.Forms.TextBox
        Me.txtNameSearch = New System.Windows.Forms.TextBox
        Me.txtNameAdd = New System.Windows.Forms.TextBox
        Me.txtIDEdit = New System.Windows.Forms.TextBox
        Me.lblMarkEdit = New System.Windows.Forms.Label
        Me.txtIDSearch = New System.Windows.Forms.TextBox
        Me.txtIDAdd = New System.Windows.Forms.TextBox
        Me.lblNameEdit = New System.Windows.Forms.Label
        Me.lblMarkAdd = New System.Windows.Forms.Label
        Me.lblNameRealTime = New System.Windows.Forms.Label
        Me.lblIDEdit = New System.Windows.Forms.Label
        Me.lblNameSearch = New System.Windows.Forms.Label
        Me.lblNameAdd = New System.Windows.Forms.Label
        Me.lblIDSearch = New System.Windows.Forms.Label
        Me.lblIDAdd = New System.Windows.Forms.Label
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkNewRow
        '
        Me.chkNewRow.AutoSize = True
        Me.chkNewRow.Checked = True
        Me.chkNewRow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNewRow.Location = New System.Drawing.Point(15, 375)
        Me.chkNewRow.Name = "chkNewRow"
        Me.chkNewRow.Size = New System.Drawing.Size(70, 17)
        Me.chkNewRow.TabIndex = 46
        Me.chkNewRow.Text = "NewRow"
        Me.chkNewRow.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(12, 196)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.Size = New System.Drawing.Size(555, 173)
        Me.dgvStudents.TabIndex = 43
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(492, 91)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 38
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(12, 164)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(75, 23)
        Me.btnShowAll.TabIndex = 39
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnSearchName
        '
        Me.btnSearchName.Location = New System.Drawing.Point(293, 166)
        Me.btnSearchName.Name = "btnSearchName"
        Me.btnSearchName.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchName.TabIndex = 41
        Me.btnSearchName.Text = "Search"
        Me.btnSearchName.UseVisualStyleBackColor = True
        '
        'btnSearchID
        '
        Me.btnSearchID.Location = New System.Drawing.Point(208, 42)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchID.TabIndex = 33
        Me.btnSearchID.Text = "Search"
        Me.btnSearchID.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.Location = New System.Drawing.Point(291, 42)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(75, 23)
        Me.btnErase.TabIndex = 34
        Me.btnErase.Text = "Erase"
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(80, 90)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtMarkEdit
        '
        Me.txtMarkEdit.Location = New System.Drawing.Point(467, 64)
        Me.txtMarkEdit.Name = "txtMarkEdit"
        Me.txtMarkEdit.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkEdit.TabIndex = 37
        '
        'txtMarkAdd
        '
        Me.txtMarkAdd.Location = New System.Drawing.Point(55, 64)
        Me.txtMarkAdd.Name = "txtMarkAdd"
        Me.txtMarkAdd.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkAdd.TabIndex = 30
        '
        'txtNameEdit
        '
        Me.txtNameEdit.Location = New System.Drawing.Point(467, 38)
        Me.txtNameEdit.Name = "txtNameEdit"
        Me.txtNameEdit.Size = New System.Drawing.Size(100, 20)
        Me.txtNameEdit.TabIndex = 36
        '
        'txtSearchRealTime
        '
        Me.txtSearchRealTime.Location = New System.Drawing.Point(467, 165)
        Me.txtSearchRealTime.Name = "txtSearchRealTime"
        Me.txtSearchRealTime.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchRealTime.TabIndex = 42
        '
        'txtNameSearch
        '
        Me.txtNameSearch.Location = New System.Drawing.Point(187, 168)
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtNameSearch.TabIndex = 40
        '
        'txtNameAdd
        '
        Me.txtNameAdd.Location = New System.Drawing.Point(55, 38)
        Me.txtNameAdd.Name = "txtNameAdd"
        Me.txtNameAdd.Size = New System.Drawing.Size(100, 20)
        Me.txtNameAdd.TabIndex = 29
        '
        'txtIDEdit
        '
        Me.txtIDEdit.Location = New System.Drawing.Point(467, 12)
        Me.txtIDEdit.Name = "txtIDEdit"
        Me.txtIDEdit.Size = New System.Drawing.Size(100, 20)
        Me.txtIDEdit.TabIndex = 35
        '
        'lblMarkEdit
        '
        Me.lblMarkEdit.AutoSize = True
        Me.lblMarkEdit.Location = New System.Drawing.Point(424, 68)
        Me.lblMarkEdit.Name = "lblMarkEdit"
        Me.lblMarkEdit.Size = New System.Drawing.Size(31, 13)
        Me.lblMarkEdit.TabIndex = 21
        Me.lblMarkEdit.Text = "Mark"
        '
        'txtIDSearch
        '
        Me.txtIDSearch.Location = New System.Drawing.Point(229, 16)
        Me.txtIDSearch.Name = "txtIDSearch"
        Me.txtIDSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtIDSearch.TabIndex = 32
        '
        'txtIDAdd
        '
        Me.txtIDAdd.Location = New System.Drawing.Point(55, 12)
        Me.txtIDAdd.Name = "txtIDAdd"
        Me.txtIDAdd.Size = New System.Drawing.Size(100, 20)
        Me.txtIDAdd.TabIndex = 28
        '
        'lblNameEdit
        '
        Me.lblNameEdit.AutoSize = True
        Me.lblNameEdit.Location = New System.Drawing.Point(424, 42)
        Me.lblNameEdit.Name = "lblNameEdit"
        Me.lblNameEdit.Size = New System.Drawing.Size(35, 13)
        Me.lblNameEdit.TabIndex = 23
        Me.lblNameEdit.Text = "Name"
        '
        'lblMarkAdd
        '
        Me.lblMarkAdd.AutoSize = True
        Me.lblMarkAdd.Location = New System.Drawing.Point(12, 68)
        Me.lblMarkAdd.Name = "lblMarkAdd"
        Me.lblMarkAdd.Size = New System.Drawing.Size(31, 13)
        Me.lblMarkAdd.TabIndex = 22
        Me.lblMarkAdd.Text = "Mark"
        '
        'lblNameRealTime
        '
        Me.lblNameRealTime.AutoSize = True
        Me.lblNameRealTime.Location = New System.Drawing.Point(424, 169)
        Me.lblNameRealTime.Name = "lblNameRealTime"
        Me.lblNameRealTime.Size = New System.Drawing.Size(35, 13)
        Me.lblNameRealTime.TabIndex = 20
        Me.lblNameRealTime.Text = "Name"
        '
        'lblIDEdit
        '
        Me.lblIDEdit.AutoSize = True
        Me.lblIDEdit.Location = New System.Drawing.Point(424, 16)
        Me.lblIDEdit.Name = "lblIDEdit"
        Me.lblIDEdit.Size = New System.Drawing.Size(18, 13)
        Me.lblIDEdit.TabIndex = 19
        Me.lblIDEdit.Text = "ID"
        '
        'lblNameSearch
        '
        Me.lblNameSearch.AutoSize = True
        Me.lblNameSearch.Location = New System.Drawing.Point(144, 172)
        Me.lblNameSearch.Name = "lblNameSearch"
        Me.lblNameSearch.Size = New System.Drawing.Size(35, 13)
        Me.lblNameSearch.TabIndex = 26
        Me.lblNameSearch.Text = "Name"
        '
        'lblNameAdd
        '
        Me.lblNameAdd.AutoSize = True
        Me.lblNameAdd.Location = New System.Drawing.Point(12, 42)
        Me.lblNameAdd.Name = "lblNameAdd"
        Me.lblNameAdd.Size = New System.Drawing.Size(35, 13)
        Me.lblNameAdd.TabIndex = 25
        Me.lblNameAdd.Text = "Name"
        '
        'lblIDSearch
        '
        Me.lblIDSearch.AutoSize = True
        Me.lblIDSearch.Location = New System.Drawing.Point(205, 20)
        Me.lblIDSearch.Name = "lblIDSearch"
        Me.lblIDSearch.Size = New System.Drawing.Size(18, 13)
        Me.lblIDSearch.TabIndex = 24
        Me.lblIDSearch.Text = "ID"
        '
        'lblIDAdd
        '
        Me.lblIDAdd.AutoSize = True
        Me.lblIDAdd.Location = New System.Drawing.Point(12, 16)
        Me.lblIDAdd.Name = "lblIDAdd"
        Me.lblIDAdd.Size = New System.Drawing.Size(18, 13)
        Me.lblIDAdd.TabIndex = 27
        Me.lblIDAdd.Text = "ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 401)
        Me.Controls.Add(Me.chkNewRow)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnSearchName)
        Me.Controls.Add(Me.btnSearchID)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMarkEdit)
        Me.Controls.Add(Me.txtMarkAdd)
        Me.Controls.Add(Me.txtNameEdit)
        Me.Controls.Add(Me.txtSearchRealTime)
        Me.Controls.Add(Me.txtNameSearch)
        Me.Controls.Add(Me.txtNameAdd)
        Me.Controls.Add(Me.txtIDEdit)
        Me.Controls.Add(Me.lblMarkEdit)
        Me.Controls.Add(Me.txtIDSearch)
        Me.Controls.Add(Me.txtIDAdd)
        Me.Controls.Add(Me.lblNameEdit)
        Me.Controls.Add(Me.lblMarkAdd)
        Me.Controls.Add(Me.lblNameRealTime)
        Me.Controls.Add(Me.lblIDEdit)
        Me.Controls.Add(Me.lblNameSearch)
        Me.Controls.Add(Me.lblNameAdd)
        Me.Controls.Add(Me.lblIDSearch)
        Me.Controls.Add(Me.lblIDAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chkNewRow As System.Windows.Forms.CheckBox
    Private WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents btnShowAll As System.Windows.Forms.Button
    Private WithEvents btnSearchName As System.Windows.Forms.Button
    Private WithEvents btnSearchID As System.Windows.Forms.Button
    Private WithEvents btnErase As System.Windows.Forms.Button
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents txtMarkEdit As System.Windows.Forms.TextBox
    Private WithEvents txtMarkAdd As System.Windows.Forms.TextBox
    Private WithEvents txtNameEdit As System.Windows.Forms.TextBox
    Private WithEvents txtSearchRealTime As System.Windows.Forms.TextBox
    Private WithEvents txtNameSearch As System.Windows.Forms.TextBox
    Private WithEvents txtNameAdd As System.Windows.Forms.TextBox
    Private WithEvents txtIDEdit As System.Windows.Forms.TextBox
    Private WithEvents lblMarkEdit As System.Windows.Forms.Label
    Private WithEvents txtIDSearch As System.Windows.Forms.TextBox
    Private WithEvents txtIDAdd As System.Windows.Forms.TextBox
    Private WithEvents lblNameEdit As System.Windows.Forms.Label
    Private WithEvents lblMarkAdd As System.Windows.Forms.Label
    Private WithEvents lblNameRealTime As System.Windows.Forms.Label
    Private WithEvents lblIDEdit As System.Windows.Forms.Label
    Private WithEvents lblNameSearch As System.Windows.Forms.Label
    Private WithEvents lblNameAdd As System.Windows.Forms.Label
    Private WithEvents lblIDSearch As System.Windows.Forms.Label
    Private WithEvents lblIDAdd As System.Windows.Forms.Label

End Class
