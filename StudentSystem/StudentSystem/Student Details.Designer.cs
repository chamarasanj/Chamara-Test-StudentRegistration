namespace StudentSystem
{
    partial class frmStudentDetails
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
            this.gvStudentDetails = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.clmStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGradePointAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStudentDetails
            // 
            this.gvStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStudentID,
            this.clmName,
            this.clmDob,
            this.clmGradePointAvg,
            this.clmActive});
            this.gvStudentDetails.Location = new System.Drawing.Point(23, 12);
            this.gvStudentDetails.Name = "gvStudentDetails";
            this.gvStudentDetails.Size = new System.Drawing.Size(556, 156);
            this.gvStudentDetails.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(42, 206);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // clmStudentID
            // 
            this.clmStudentID.DataPropertyName = "StudentID";
            this.clmStudentID.HeaderText = "Student ID";
            this.clmStudentID.Name = "clmStudentID";
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            // 
            // clmDob
            // 
            this.clmDob.DataPropertyName = "DOB";
            this.clmDob.HeaderText = "DOB";
            this.clmDob.Name = "clmDob";
            // 
            // clmGradePointAvg
            // 
            this.clmGradePointAvg.DataPropertyName = "GradePointAvg";
            this.clmGradePointAvg.HeaderText = "GPA";
            this.clmGradePointAvg.Name = "clmGradePointAvg";
            // 
            // clmActive
            // 
            this.clmActive.DataPropertyName = "Active";
            this.clmActive.HeaderText = "Active";
            this.clmActive.Name = "clmActive";
            // 
            // frmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 253);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gvStudentDetails);
            this.Name = "frmStudentDetails";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.frmStudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvStudentDetails;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGradePointAvg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmActive;
    }
}