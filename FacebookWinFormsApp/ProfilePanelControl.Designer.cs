namespace FacebookWinFormsApp
{
    partial class ProfilePanelControl
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
            this.profilePostBtn = new System.Windows.Forms.Button();
            this.profilePicturesBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanelProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ProfileTitle = new System.Windows.Forms.Label();
            this.profileActivityBtn = new System.Windows.Forms.Button();
            this.postSomethingButton = new System.Windows.Forms.Button();
            this.PostSomethingTextBox = new System.Windows.Forms.TextBox();
            this.postSomethingLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePostBtn
            // 
            this.profilePostBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePostBtn.Location = new System.Drawing.Point(322, 63);
            this.profilePostBtn.Name = "profilePostBtn";
            this.profilePostBtn.Size = new System.Drawing.Size(92, 33);
            this.profilePostBtn.TabIndex = 2;
            this.profilePostBtn.Text = "Posts";
            this.profilePostBtn.UseVisualStyleBackColor = true;
            // 
            // profilePicturesBtn
            // 
            this.profilePicturesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePicturesBtn.Location = new System.Drawing.Point(212, 63);
            this.profilePicturesBtn.Name = "profilePicturesBtn";
            this.profilePicturesBtn.Size = new System.Drawing.Size(92, 33);
            this.profilePicturesBtn.TabIndex = 3;
            this.profilePicturesBtn.Text = "Pictures";
            this.profilePicturesBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProfile
            // 
            this.flowLayoutPanelProfile.AutoScroll = true;
            this.flowLayoutPanelProfile.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanelProfile.Location = new System.Drawing.Point(0, 102);
            this.flowLayoutPanelProfile.Name = "flowLayoutPanelProfile";
            this.flowLayoutPanelProfile.Size = new System.Drawing.Size(536, 248);
            this.flowLayoutPanelProfile.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(12, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // ProfileTitle
            // 
            this.ProfileTitle.AutoSize = true;
            this.ProfileTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProfileTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProfileTitle.Location = new System.Drawing.Point(16, 14);
            this.ProfileTitle.Name = "ProfileTitle";
            this.ProfileTitle.Size = new System.Drawing.Size(118, 25);
            this.ProfileTitle.TabIndex = 1;
            this.ProfileTitle.Text = "My Profile";
            // 
            // profileActivityBtn
            // 
            this.profileActivityBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileActivityBtn.Location = new System.Drawing.Point(103, 63);
            this.profileActivityBtn.Name = "profileActivityBtn";
            this.profileActivityBtn.Size = new System.Drawing.Size(92, 33);
            this.profileActivityBtn.TabIndex = 6;
            this.profileActivityBtn.Text = "Activy";
            this.profileActivityBtn.UseVisualStyleBackColor = true;
            // 
            // postSomethingButton
            // 
            this.postSomethingButton.Location = new System.Drawing.Point(461, 12);
            this.postSomethingButton.Name = "postSomethingButton";
            this.postSomethingButton.Size = new System.Drawing.Size(72, 22);
            this.postSomethingButton.TabIndex = 10;
            this.postSomethingButton.Text = "Post";
            this.postSomethingButton.UseVisualStyleBackColor = true;
            // 
            // PostSomethingTextBox
            // 
            this.PostSomethingTextBox.Location = new System.Drawing.Point(292, 13);
            this.PostSomethingTextBox.Name = "PostSomethingTextBox";
            this.PostSomethingTextBox.Size = new System.Drawing.Size(164, 20);
            this.PostSomethingTextBox.TabIndex = 9;
            // 
            // postSomethingLabel
            // 
            this.postSomethingLabel.AutoSize = true;
            this.postSomethingLabel.Location = new System.Drawing.Point(204, 15);
            this.postSomethingLabel.Name = "postSomethingLabel";
            this.postSomethingLabel.Size = new System.Drawing.Size(81, 13);
            this.postSomethingLabel.TabIndex = 8;
            this.postSomethingLabel.Text = "Post Something";
            // 
            // ProfilePanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.postSomethingButton);
            this.Controls.Add(this.PostSomethingTextBox);
            this.Controls.Add(this.postSomethingLabel);
            this.Controls.Add(this.profileActivityBtn);
            this.Controls.Add(this.flowLayoutPanelProfile);
            this.Controls.Add(this.profilePicturesBtn);
            this.Controls.Add(this.profilePostBtn);
            this.Controls.Add(this.ProfileTitle);
            this.Name = "ProfilePanelControl";
            this.Size = new System.Drawing.Size(536, 350);
            this.flowLayoutPanelProfile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button profilePostBtn;
        private System.Windows.Forms.Button profilePicturesBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProfile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label ProfileTitle;
        private System.Windows.Forms.Button profileActivityBtn;
        private System.Windows.Forms.Button postSomethingButton;
        private System.Windows.Forms.TextBox PostSomethingTextBox;
        private System.Windows.Forms.Label postSomethingLabel;
    }
}
