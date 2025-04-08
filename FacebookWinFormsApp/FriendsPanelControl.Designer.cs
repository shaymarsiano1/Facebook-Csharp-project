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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.loginToFriendLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.loginToFriendLabel);
            this.flowLayoutPanel1.Controls.Add(this.listBoxFriends);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(629, 336);
            this.flowLayoutPanel1.TabIndex = 0;
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
            // loginToFriendLabel
            // 
            this.loginToFriendLabel.AutoSize = true;
            this.loginToFriendLabel.BackColor = System.Drawing.SystemColors.Control;
            this.loginToFriendLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginToFriendLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginToFriendLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginToFriendLabel.Location = new System.Drawing.Point(3, 0);
            this.loginToFriendLabel.Name = "loginToFriendLabel";
            this.loginToFriendLabel.Size = new System.Drawing.Size(312, 24);
            this.loginToFriendLabel.TabIndex = 1;
            this.loginToFriendLabel.Text = "Double click to login your friend";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label loginToFriendLabel;
    }
}
