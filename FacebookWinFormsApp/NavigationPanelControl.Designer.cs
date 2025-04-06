namespace FacebookWinFormsApp
{
    partial class NavigationPanelControl
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
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonPhotos = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonFriendFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(172)));
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProfile.Location = new System.Drawing.Point(0, 0);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(150, 32);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.OnbuttonProfileClick);
            // 
            // buttonPhotos
            // 
            this.buttonPhotos.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPhotos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPhotos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPhotos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPhotos.Location = new System.Drawing.Point(0, 32);
            this.buttonPhotos.Name = "buttonPhotos";
            this.buttonPhotos.Size = new System.Drawing.Size(150, 32);
            this.buttonPhotos.TabIndex = 1;
            this.buttonPhotos.Text = "Albums";
            this.buttonPhotos.UseVisualStyleBackColor = false;
            this.buttonPhotos.Click += new System.EventHandler(this.OnButtonPhotosClick);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSettings.Location = new System.Drawing.Point(0, 64);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(150, 32);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.OnButtonSettingsClick);
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFriends.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFriends.Location = new System.Drawing.Point(0, 96);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(150, 32);
            this.buttonFriends.TabIndex = 3;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.OnButtonFriendsClick);
            // 
            // buttonFriendFeed
            // 
            this.buttonFriendFeed.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFriendFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFriendFeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFriendFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFriendFeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFriendFeed.Location = new System.Drawing.Point(0, 128);
            this.buttonFriendFeed.Name = "buttonFriendFeed";
            this.buttonFriendFeed.Size = new System.Drawing.Size(150, 32);
            this.buttonFriendFeed.TabIndex = 4;
            this.buttonFriendFeed.Text = "Friends Feed";
            this.buttonFriendFeed.UseVisualStyleBackColor = false;
            this.buttonFriendFeed.Click += new System.EventHandler(this.OnButtonFriendsFeedClick);
            // 
            // NavigationPanelControl
            // 
            this.Controls.Add(this.buttonFriendFeed);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonPhotos);
            this.Controls.Add(this.buttonProfile);
            this.Name = "NavigationPanelControl";
            this.Size = new System.Drawing.Size(150, 214);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonPhotos;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonFriendFeed;
    }
}