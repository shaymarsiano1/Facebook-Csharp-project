namespace BasicFacebookFeatures
{
    partial class UserInfoPanelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserEmail = new System.Windows.Forms.Label();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.Location = new System.Drawing.Point(132, 20);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(105, 25);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "UserName";
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserEmail.Location = new System.Drawing.Point(132, 55);
            this.labelUserEmail.Name = "labelUserEmail";
            this.labelUserEmail.Size = new System.Drawing.Size(101, 25);
            this.labelUserEmail.TabIndex = 2;
            this.labelUserEmail.Text = "UserEmail";
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(131, 112);
            this.pictureBoxUserProfile.TabIndex = 0;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // UserInfoPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelUserEmail);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Name = "UserInfoPanelControl";
            this.Size = new System.Drawing.Size(484, 112);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserEmail;
    }
}
