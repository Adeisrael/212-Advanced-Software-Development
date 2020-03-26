namespace ContactManagerCSharp
{
    partial class ContactMenu
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
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_business = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_personal
            // 
            this.btn_personal.Location = new System.Drawing.Point(54, 156);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(91, 35);
            this.btn_personal.TabIndex = 0;
            this.btn_personal.Text = "Personal Contacts";
            this.btn_personal.UseVisualStyleBackColor = true;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // btn_business
            // 
            this.btn_business.Location = new System.Drawing.Point(233, 156);
            this.btn_business.Name = "btn_business";
            this.btn_business.Size = new System.Drawing.Size(81, 35);
            this.btn_business.TabIndex = 1;
            this.btn_business.Text = "Business Contacts";
            this.btn_business.UseVisualStyleBackColor = true;
            this.btn_business.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContactMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 280);
            this.Controls.Add(this.btn_business);
            this.Controls.Add(this.btn_personal);
            this.Name = "ContactMenu";
            this.Text = "Harris&Sons Contact Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_business;
    }
}

