namespace ContactManagerCSharp
{
    partial class PersonalEditor
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
            this.dGVPersonalDetails = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbHomeTel = new System.Windows.Forms.TextBox();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHomeTel = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPersonalDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVPersonalDetails
            // 
            this.dGVPersonalDetails.AllowUserToDeleteRows = false;
            this.dGVPersonalDetails.AllowUserToResizeColumns = false;
            this.dGVPersonalDetails.AllowUserToResizeRows = false;
            this.dGVPersonalDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPersonalDetails.Location = new System.Drawing.Point(12, 130);
            this.dGVPersonalDetails.Name = "dGVPersonalDetails";
            this.dGVPersonalDetails.ReadOnly = true;
            this.dGVPersonalDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPersonalDetails.Size = new System.Drawing.Size(761, 249);
            this.dGVPersonalDetails.TabIndex = 0;
            this.dGVPersonalDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPersonalDetails_CellClicked);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(700, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(592, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(700, 41);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 3;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(698, 101);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(592, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Selected";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(592, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbLname
            // 
            this.tbLname.Enabled = false;
            this.tbLname.Location = new System.Drawing.Point(75, 56);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(100, 20);
            this.tbLname.TabIndex = 7;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Enabled = false;
            this.tbPostcode.Location = new System.Drawing.Point(447, 56);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(100, 20);
            this.tbPostcode.TabIndex = 8;
            // 
            // tbFname
            // 
            this.tbFname.Enabled = false;
            this.tbFname.Location = new System.Drawing.Point(75, 14);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(100, 20);
            this.tbFname.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(75, 97);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // tbCity
            // 
            this.tbCity.Enabled = false;
            this.tbCity.Location = new System.Drawing.Point(447, 14);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 11;
            this.tbCity.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbHomeTel
            // 
            this.tbHomeTel.Enabled = false;
            this.tbHomeTel.Location = new System.Drawing.Point(261, 15);
            this.tbHomeTel.Name = "tbHomeTel";
            this.tbHomeTel.Size = new System.Drawing.Size(100, 20);
            this.tbHomeTel.TabIndex = 12;
            this.tbHomeTel.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tbAddress1
            // 
            this.tbAddress1.Enabled = false;
            this.tbAddress1.Location = new System.Drawing.Point(261, 56);
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(100, 20);
            this.tbAddress1.TabIndex = 13;
            // 
            // tbAddress2
            // 
            this.tbAddress2.Enabled = false;
            this.tbAddress2.Location = new System.Drawing.Point(261, 98);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(100, 20);
            this.tbAddress2.TabIndex = 14;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(12, 17);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 15;
            this.lblFname.Text = "First Name";
            this.lblFname.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // lblHomeTel
            // 
            this.lblHomeTel.AutoSize = true;
            this.lblHomeTel.Location = new System.Drawing.Point(202, 17);
            this.lblHomeTel.Name = "lblHomeTel";
            this.lblHomeTel.Size = new System.Drawing.Size(53, 13);
            this.lblHomeTel.TabIndex = 18;
            this.lblHomeTel.Text = "Home Tel";
            this.lblHomeTel.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(202, 59);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(54, 13);
            this.lblAddress1.TabIndex = 19;
            this.lblAddress1.Text = "Address 1";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(202, 101);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2.TabIndex = 20;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(389, 17);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 21;
            this.lblCity.Text = "City";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(389, 59);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 22;
            this.lblPostcode.Text = "Postcode";
            // 
            // PersonalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 391);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblHomeTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.tbAddress1);
            this.Controls.Add(this.tbHomeTel);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dGVPersonalDetails);
            this.Name = "PersonalEditor";
            this.Text = "PersonalEditor";
            this.Load += new System.EventHandler(this.PersonalEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPersonalDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVPersonalDetails;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbHomeTel;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHomeTel;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostcode;
    }
}