namespace FacebookWinFormsApp
{
    partial class FacebookApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookApp));
            this.basePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userInfoPanelControl21 = new BasicFacebookFeatures.UserInfoPanelControl();
            this.navigationPanelControl = new FacebookWinFormsApp.NavigationPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.Location = new System.Drawing.Point(210, 114);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(588, 331);
            this.basePanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // userInfoPanelControl21
            // 
            this.userInfoPanelControl21.BackColor = System.Drawing.SystemColors.Control;
            this.userInfoPanelControl21.Location = new System.Drawing.Point(371, 12);
            this.userInfoPanelControl21.Name = "userInfoPanelControl21";
            this.userInfoPanelControl21.Size = new System.Drawing.Size(404, 96);
            this.userInfoPanelControl21.TabIndex = 3;
            // 
            // navigationPanelControl
            // 
            this.navigationPanelControl.Location = new System.Drawing.Point(-1, 114);
            this.navigationPanelControl.Name = "navigationPanelControl";
            this.navigationPanelControl.Size = new System.Drawing.Size(205, 333);
            this.navigationPanelControl.TabIndex = 1;
            // 
            // FacebookApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userInfoPanelControl21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.navigationPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacebookApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NavigationPanelControl navigationPanelControl;
        private System.Windows.Forms.Panel basePanel;
        private BasicFacebookFeatures.UserInfoPanelControl userInfoPanelControl21;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}