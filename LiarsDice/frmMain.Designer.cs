namespace LiarsDice
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstProfiles = new System.Windows.Forms.ListBox();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProfiles
            // 
            this.lstProfiles.BackColor = System.Drawing.Color.Black;
            this.lstProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProfiles.ForeColor = System.Drawing.Color.White;
            this.lstProfiles.FormattingEnabled = true;
            this.lstProfiles.ItemHeight = 24;
            this.lstProfiles.Location = new System.Drawing.Point(12, 77);
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(138, 312);
            this.lstProfiles.TabIndex = 0;
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.BackColor = System.Drawing.Color.Black;
            this.btnNewProfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewProfile.FlatAppearance.BorderSize = 8;
            this.btnNewProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNewProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProfile.ForeColor = System.Drawing.Color.White;
            this.btnNewProfile.Location = new System.Drawing.Point(168, 91);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(183, 49);
            this.btnNewProfile.TabIndex = 0;
            this.btnNewProfile.Text = "New Profile";
            this.btnNewProfile.UseVisualStyleBackColor = false;
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(10, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 74);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "LIARS DICE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.BackColor = System.Drawing.Color.Black;
            this.btnLoadProfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadProfile.FlatAppearance.BorderSize = 8;
            this.btnLoadProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnLoadProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProfile.ForeColor = System.Drawing.Color.White;
            this.btnLoadProfile.Location = new System.Drawing.Point(168, 146);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(183, 49);
            this.btnLoadProfile.TabIndex = 1;
            this.btnLoadProfile.Text = "Load Profile";
            this.btnLoadProfile.UseVisualStyleBackColor = false;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnLoadProfile_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.BackColor = System.Drawing.Color.Black;
            this.btnDeleteProfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteProfile.FlatAppearance.BorderSize = 8;
            this.btnDeleteProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProfile.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProfile.Location = new System.Drawing.Point(168, 201);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(183, 49);
            this.btnDeleteProfile.TabIndex = 2;
            this.btnDeleteProfile.Text = "Delete Profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = false;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.Color.Black;
            this.btnHowToPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHowToPlay.FlatAppearance.BorderSize = 8;
            this.btnHowToPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHowToPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.ForeColor = System.Drawing.Color.White;
            this.btnHowToPlay.Location = new System.Drawing.Point(168, 283);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(183, 49);
            this.btnHowToPlay.TabIndex = 3;
            this.btnHowToPlay.Text = "How To Play";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.Color.Black;
            this.btnExitApplication.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExitApplication.FlatAppearance.BorderSize = 8;
            this.btnExitApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnExitApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApplication.ForeColor = System.Drawing.Color.White;
            this.btnExitApplication.Location = new System.Drawing.Point(168, 338);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(183, 49);
            this.btnExitApplication.TabIndex = 4;
            this.btnExitApplication.Text = "Exit Game";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(379, 457);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.btnLoadProfile);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnNewProfile);
            this.Controls.Add(this.lstProfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 457);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 457);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liar\'s Dice";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProfiles;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoadProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnExitApplication;
    }
}

