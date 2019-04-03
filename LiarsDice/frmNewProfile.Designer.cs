namespace LiarsDice
{
    partial class frmNewProfile
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
            this.lblNewProfile = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewProfile
            // 
            this.lblNewProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNewProfile.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProfile.Location = new System.Drawing.Point(0, 0);
            this.lblNewProfile.Name = "lblNewProfile";
            this.lblNewProfile.Size = new System.Drawing.Size(284, 58);
            this.lblNewProfile.TabIndex = 0;
            this.lblNewProfile.Text = "New Profile";
            this.lblNewProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.Location = new System.Drawing.Point(0, 72);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(284, 43);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(10, 118);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(260, 31);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.WordWrap = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(12, 206);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(260, 31);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.WordWrap = false;
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.BackColor = System.Drawing.Color.Black;
            this.btnCreateProfile.FlatAppearance.BorderSize = 0;
            this.btnCreateProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            this.btnCreateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.btnCreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProfile.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProfile.Location = new System.Drawing.Point(28, 267);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(222, 63);
            this.btnCreateProfile.TabIndex = 3;
            this.btnCreateProfile.Text = "Create";
            this.btnCreateProfile.UseVisualStyleBackColor = false;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // frmNewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblNewProfile);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewProfile;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnCreateProfile;
    }
}