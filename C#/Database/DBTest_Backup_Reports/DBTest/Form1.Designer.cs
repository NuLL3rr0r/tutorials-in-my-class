namespace DBTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIDAdd = new System.Windows.Forms.Label();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.lblMarkAdd = new System.Windows.Forms.Label();
            this.txtIDAdd = new System.Windows.Forms.TextBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.txtMarkAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIDEdit = new System.Windows.Forms.Label();
            this.lblNameEdit = new System.Windows.Forms.Label();
            this.lblMarkEdit = new System.Windows.Forms.Label();
            this.txtIDEdit = new System.Windows.Forms.TextBox();
            this.txtNameEdit = new System.Windows.Forms.TextBox();
            this.txtMarkEdit = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblIDSearch = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.lblNameRealTime = new System.Windows.Forms.Label();
            this.txtSearchRealTime = new System.Windows.Forms.TextBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkNewRow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDAdd
            // 
            this.lblIDAdd.AutoSize = true;
            this.lblIDAdd.Location = new System.Drawing.Point(12, 16);
            this.lblIDAdd.Name = "lblIDAdd";
            this.lblIDAdd.Size = new System.Drawing.Size(18, 13);
            this.lblIDAdd.TabIndex = 0;
            this.lblIDAdd.Text = "ID";
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(12, 42);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(35, 13);
            this.lblNameAdd.TabIndex = 0;
            this.lblNameAdd.Text = "Name";
            // 
            // lblMarkAdd
            // 
            this.lblMarkAdd.AutoSize = true;
            this.lblMarkAdd.Location = new System.Drawing.Point(12, 68);
            this.lblMarkAdd.Name = "lblMarkAdd";
            this.lblMarkAdd.Size = new System.Drawing.Size(31, 13);
            this.lblMarkAdd.TabIndex = 0;
            this.lblMarkAdd.Text = "Mark";
            // 
            // txtIDAdd
            // 
            this.txtIDAdd.Location = new System.Drawing.Point(55, 12);
            this.txtIDAdd.Name = "txtIDAdd";
            this.txtIDAdd.Size = new System.Drawing.Size(100, 20);
            this.txtIDAdd.TabIndex = 1;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(55, 38);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(100, 20);
            this.txtNameAdd.TabIndex = 2;
            // 
            // txtMarkAdd
            // 
            this.txtMarkAdd.Location = new System.Drawing.Point(55, 64);
            this.txtMarkAdd.Name = "txtMarkAdd";
            this.txtMarkAdd.Size = new System.Drawing.Size(100, 20);
            this.txtMarkAdd.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIDEdit
            // 
            this.lblIDEdit.AutoSize = true;
            this.lblIDEdit.Location = new System.Drawing.Point(424, 16);
            this.lblIDEdit.Name = "lblIDEdit";
            this.lblIDEdit.Size = new System.Drawing.Size(18, 13);
            this.lblIDEdit.TabIndex = 0;
            this.lblIDEdit.Text = "ID";
            // 
            // lblNameEdit
            // 
            this.lblNameEdit.AutoSize = true;
            this.lblNameEdit.Location = new System.Drawing.Point(424, 42);
            this.lblNameEdit.Name = "lblNameEdit";
            this.lblNameEdit.Size = new System.Drawing.Size(35, 13);
            this.lblNameEdit.TabIndex = 0;
            this.lblNameEdit.Text = "Name";
            // 
            // lblMarkEdit
            // 
            this.lblMarkEdit.AutoSize = true;
            this.lblMarkEdit.Location = new System.Drawing.Point(424, 68);
            this.lblMarkEdit.Name = "lblMarkEdit";
            this.lblMarkEdit.Size = new System.Drawing.Size(31, 13);
            this.lblMarkEdit.TabIndex = 0;
            this.lblMarkEdit.Text = "Mark";
            // 
            // txtIDEdit
            // 
            this.txtIDEdit.Location = new System.Drawing.Point(467, 12);
            this.txtIDEdit.Name = "txtIDEdit";
            this.txtIDEdit.Size = new System.Drawing.Size(100, 20);
            this.txtIDEdit.TabIndex = 8;
            // 
            // txtNameEdit
            // 
            this.txtNameEdit.Location = new System.Drawing.Point(467, 38);
            this.txtNameEdit.Name = "txtNameEdit";
            this.txtNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtNameEdit.TabIndex = 9;
            // 
            // txtMarkEdit
            // 
            this.txtMarkEdit.Location = new System.Drawing.Point(467, 64);
            this.txtMarkEdit.Name = "txtMarkEdit";
            this.txtMarkEdit.Size = new System.Drawing.Size(100, 20);
            this.txtMarkEdit.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(492, 91);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblIDSearch
            // 
            this.lblIDSearch.AutoSize = true;
            this.lblIDSearch.Location = new System.Drawing.Point(205, 20);
            this.lblIDSearch.Name = "lblIDSearch";
            this.lblIDSearch.Size = new System.Drawing.Size(18, 13);
            this.lblIDSearch.TabIndex = 0;
            this.lblIDSearch.Text = "ID";
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(229, 16);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(100, 20);
            this.txtIDSearch.TabIndex = 5;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 164);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Location = new System.Drawing.Point(144, 172);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(35, 13);
            this.lblNameSearch.TabIndex = 0;
            this.lblNameSearch.Text = "Name";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(187, 168);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(100, 20);
            this.txtNameSearch.TabIndex = 13;
            // 
            // lblNameRealTime
            // 
            this.lblNameRealTime.AutoSize = true;
            this.lblNameRealTime.Location = new System.Drawing.Point(424, 169);
            this.lblNameRealTime.Name = "lblNameRealTime";
            this.lblNameRealTime.Size = new System.Drawing.Size(35, 13);
            this.lblNameRealTime.TabIndex = 0;
            this.lblNameRealTime.Text = "Name";
            // 
            // txtSearchRealTime
            // 
            this.txtSearchRealTime.Location = new System.Drawing.Point(467, 165);
            this.txtSearchRealTime.Name = "txtSearchRealTime";
            this.txtSearchRealTime.Size = new System.Drawing.Size(100, 20);
            this.txtSearchRealTime.TabIndex = 15;
            this.txtSearchRealTime.TextChanged += new System.EventHandler(this.txtSearchRealTime_TextChanged);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(291, 42);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 7;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(293, 166);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchName.TabIndex = 14;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 196);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(555, 173);
            this.dgvStudents.TabIndex = 16;
            this.dgvStudents.CurrentCellChanged += new System.EventHandler(this.dgvStudents_CurrentCellChanged);
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(208, 42);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchID.TabIndex = 6;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 62);
            this.button2.TabIndex = 17;
            this.button2.Text = "Backup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkNewRow
            // 
            this.chkNewRow.AutoSize = true;
            this.chkNewRow.Checked = true;
            this.chkNewRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNewRow.Location = new System.Drawing.Point(15, 375);
            this.chkNewRow.Name = "chkNewRow";
            this.chkNewRow.Size = new System.Drawing.Size(70, 17);
            this.chkNewRow.TabIndex = 18;
            this.chkNewRow.Text = "NewRow";
            this.chkNewRow.UseVisualStyleBackColor = true;
            this.chkNewRow.CheckedChanged += new System.EventHandler(this.chkNewRow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 498);
            this.Controls.Add(this.chkNewRow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMarkEdit);
            this.Controls.Add(this.txtMarkAdd);
            this.Controls.Add(this.txtNameEdit);
            this.Controls.Add(this.txtSearchRealTime);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.txtNameAdd);
            this.Controls.Add(this.txtIDEdit);
            this.Controls.Add(this.lblMarkEdit);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.txtIDAdd);
            this.Controls.Add(this.lblNameEdit);
            this.Controls.Add(this.lblMarkAdd);
            this.Controls.Add(this.lblNameRealTime);
            this.Controls.Add(this.lblIDEdit);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.lblNameAdd);
            this.Controls.Add(this.lblIDSearch);
            this.Controls.Add(this.lblIDAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDAdd;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.Label lblMarkAdd;
        private System.Windows.Forms.TextBox txtIDAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.TextBox txtMarkAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIDEdit;
        private System.Windows.Forms.Label lblNameEdit;
        private System.Windows.Forms.Label lblMarkEdit;
        private System.Windows.Forms.TextBox txtIDEdit;
        private System.Windows.Forms.TextBox txtNameEdit;
        private System.Windows.Forms.TextBox txtMarkEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblIDSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label lblNameRealTime;
        private System.Windows.Forms.TextBox txtSearchRealTime;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkNewRow;
    }
}

