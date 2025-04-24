namespace BasicFacebookFeatures
{
    partial class FriendsPanelControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label imageNormalLabel1;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loginToFriendLabel = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.ownerObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            imageNormalLabel = new System.Windows.Forms.Label();
            imageNormalLabel1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerObjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Location = new System.Drawing.Point(321, 24);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(0, 13);
            imageNormalLabel.TabIndex = 2;
            // 
            // imageNormalLabel1
            // 
            imageNormalLabel1.AutoSize = true;
            imageNormalLabel1.Location = new System.Drawing.Point(327, 24);
            imageNormalLabel1.Name = "imageNormalLabel1";
            imageNormalLabel1.Size = new System.Drawing.Size(72, 13);
            imageNormalLabel1.TabIndex = 3;
            imageNormalLabel1.Text = "Profile Picture";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.loginToFriendLabel);
            this.flowLayoutPanel1.Controls.Add(this.listBoxFriends);
            this.flowLayoutPanel1.Controls.Add(imageNormalLabel);
            this.flowLayoutPanel1.Controls.Add(imageNormalLabel1);
            this.flowLayoutPanel1.Controls.Add(this.imageNormalPictureBox);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(629, 336);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // loginToFriendLabel
            // 
            this.loginToFriendLabel.AutoSize = true;
            this.loginToFriendLabel.BackColor = System.Drawing.SystemColors.Control;
            this.loginToFriendLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginToFriendLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginToFriendLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginToFriendLabel.Location = new System.Drawing.Point(3, 0);
            this.loginToFriendLabel.Name = "loginToFriendLabel";
            this.loginToFriendLabel.Size = new System.Drawing.Size(340, 24);
            this.loginToFriendLabel.TabIndex = 1;
            this.loginToFriendLabel.Text = "Double click to login as your friend";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 25;
            this.listBoxFriends.Location = new System.Drawing.Point(3, 27);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(312, 279);
            this.listBoxFriends.TabIndex = 0;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.ownerObjectBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(405, 27);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(115, 101);
            this.imageNormalPictureBox.TabIndex = 4;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // ownerObjectBindingSource
            // 
            this.ownerObjectBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.OwnerObject);
            // 
            // FriendsPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FriendsPanelControl";
            this.Size = new System.Drawing.Size(632, 339);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerObjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label loginToFriendLabel;
        private System.Windows.Forms.BindingSource ownerObjectBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
    }
}
