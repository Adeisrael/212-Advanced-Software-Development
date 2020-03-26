namespace ContactManagerCSharp
{
    partial class BusinessEditor
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
            this.dGVBusinessRecords = new System.Windows.Forms.DataGridView();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblHomeTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.tbBusTel = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusinessRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVBusinessRecords
            // 
            this.dGVBusinessRecords.AllowUserToResizeColumns = false;
            this.dGVBusinessRecords.AllowUserToResizeRows = false;
            this.dGVBusinessRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBusinessRecords.Location = new System.Drawing.Point(12, 128);
            this.dGVBusinessRecords.Name = "dGVBusinessRecords";
            this.dGVBusinessRecords.ReadOnly = true;
            this.dGVBusinessRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBusinessRecords.Size = new System.Drawing.Size(751, 295);
            this.dGVBusinessRecords.TabIndex = 0;
            this.dGVBusinessRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBusinessRecords_CellClicked);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(377, 57);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 44;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(377, 15);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 43;
            this.lblCity.Text = "City";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(190, 99);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2.TabIndex = 42;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(190, 57);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(54, 13);
            this.lblAddress1.TabIndex = 41;
            this.lblAddress1.Text = "Address 1";
            // 
            // lblHomeTel
            // 
            this.lblHomeTel.AutoSize = true;
            this.lblHomeTel.Location = new System.Drawing.Point(177, 15);
            this.lblHomeTel.Name = "lblHomeTel";
            this.lblHomeTel.Size = new System.Drawing.Size(67, 13);
            this.lblHomeTel.TabIndex = 40;
            this.lblHomeTel.Text = "Business Tel";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(0, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Last Name ";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(0, 15);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 37;
            this.lblFname.Text = "First Name";
            // 
            // tbAddress2
            // 
            this.tbAddress2.Enabled = false;
            this.tbAddress2.Location = new System.Drawing.Point(249, 96);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(100, 20);
            this.tbAddress2.TabIndex = 36;
            // 
            // tbAddress1
            // 
            this.tbAddress1.Enabled = false;
            this.tbAddress1.Location = new System.Drawing.Point(249, 54);
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(100, 20);
            this.tbAddress1.TabIndex = 35;
            // 
            // tbBusTel
            // 
            this.tbBusTel.Enabled = false;
            this.tbBusTel.Location = new System.Drawing.Point(249, 13);
            this.tbBusTel.Name = "tbBusTel";
            this.tbBusTel.Size = new System.Drawing.Size(100, 20);
            this.tbBusTel.TabIndex = 34;
            // 
            // tbCity
            // 
            this.tbCity.Enabled = false;
            this.tbCity.Location = new System.Drawing.Point(435, 12);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 33;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(63, 95);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 32;
            // 
            // tbFname
            // 
            this.tbFname.Enabled = false;
            this.tbFname.Location = new System.Drawing.Point(63, 12);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(100, 20);
            this.tbFname.TabIndex = 31;
            // 
            // tbPostcode
            // 
            this.tbPostcode.Enabled = false;
            this.tbPostcode.Location = new System.Drawing.Point(435, 54);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(100, 20);
            this.tbPostcode.TabIndex = 30;
            // 
            // tbLname
            // 
            this.tbLname.Enabled = false;
            this.tbLname.Location = new System.Drawing.Point(63, 54);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(100, 20);
            this.tbLname.TabIndex = 29;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(580, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(580, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save Selected";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(686, 99);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(688, 39);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 25;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(580, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(688, 10);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 23;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // BusinessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 435);
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
            this.Controls.Add(this.tbBusTel);
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
            this.Controls.Add(this.dGVBusinessRecords);
            this.Name = "BusinessEditor";
            this.Text = "BusinessEditor";
            this.Load += new System.EventHandler(this.BusinessEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBusinessRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVBusinessRecords;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblHomeTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.TextBox tbBusTel;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
    }
}