using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label pictureURLLabel;
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postSomethingButton = new System.Windows.Forms.Button();
            this.PostSomethingTextBox = new System.Windows.Forms.TextBox();
            this.postSomethingLabel = new System.Windows.Forms.Label();
            this.profileActivityBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanelProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportPostsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.talkPostBtn = new System.Windows.Forms.Button();
            this.happyPostBtn = new System.Windows.Forms.Button();
            this.sadPostBtn = new System.Windows.Forms.Button();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureURLPictureBox = new System.Windows.Forms.PictureBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.profilePicturesBtn = new System.Windows.Forms.Button();
            this.profilePostBtn = new System.Windows.Forms.Button();
            this.ProfileTitle = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.importPostsBtn = new System.Windows.Forms.Button();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            pictureURLLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.flowLayoutPanelProfile.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(435, 290);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(0, 13);
            createdTimeLabel.TabIndex = 11;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(438, 189);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(0, 13);
            messageLabel.TabIndex = 13;
            // 
            // pictureURLLabel
            // 
            pictureURLLabel.AutoSize = true;
            pictureURLLabel.Location = new System.Drawing.Point(435, 221);
            pictureURLLabel.Name = "pictureURLLabel";
            pictureURLLabel.Size = new System.Drawing.Size(0, 13);
            pictureURLLabel.TabIndex = 15;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // postSomethingButton
            // 
            this.postSomethingButton.Location = new System.Drawing.Point(461, 16);
            this.postSomethingButton.Name = "postSomethingButton";
            this.postSomethingButton.Size = new System.Drawing.Size(72, 22);
            this.postSomethingButton.TabIndex = 10;
            this.postSomethingButton.Text = "Post";
            this.postSomethingButton.UseVisualStyleBackColor = true;
            // 
            // PostSomethingTextBox
            // 
            this.PostSomethingTextBox.Location = new System.Drawing.Point(292, 17);
            this.PostSomethingTextBox.Name = "PostSomethingTextBox";
            this.PostSomethingTextBox.Size = new System.Drawing.Size(164, 20);
            this.PostSomethingTextBox.TabIndex = 9;
            // 
            // postSomethingLabel
            // 
            this.postSomethingLabel.AutoSize = true;
            this.postSomethingLabel.Location = new System.Drawing.Point(204, 19);
            this.postSomethingLabel.Name = "postSomethingLabel";
            this.postSomethingLabel.Size = new System.Drawing.Size(84, 13);
            this.postSomethingLabel.TabIndex = 8;
            this.postSomethingLabel.Text = "Post Something:";
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
            // flowLayoutPanelProfile
            // 
            this.flowLayoutPanelProfile.AutoScroll = true;
            this.flowLayoutPanelProfile.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanelProfile.Location = new System.Drawing.Point(0, 102);
            this.flowLayoutPanelProfile.Name = "flowLayoutPanelProfile";
            this.flowLayoutPanelProfile.Size = new System.Drawing.Size(456, 258);
            this.flowLayoutPanelProfile.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(12, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.importPostsBtn);
            this.panel1.Controls.Add(this.exportPostsBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.talkPostBtn);
            this.panel1.Controls.Add(this.happyPostBtn);
            this.panel1.Controls.Add(this.sadPostBtn);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(this.pictureURLPictureBox);
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Controls.Add(this.listBoxPosts);
            this.panel1.Location = new System.Drawing.Point(3, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 258);
            this.panel1.TabIndex = 1;
            // 
            // exportPostsBtn
            // 
            this.exportPostsBtn.Location = new System.Drawing.Point(460, 169);
            this.exportPostsBtn.Name = "exportPostsBtn";
            this.exportPostsBtn.Size = new System.Drawing.Size(113, 32);
            this.exportPostsBtn.TabIndex = 27;
            this.exportPostsBtn.Text = "Export my posts";
            this.exportPostsBtn.UseVisualStyleBackColor = true;
            this.exportPostsBtn.Click += new System.EventHandler(this.exportPostsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(440, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Click -> Post:";
            // 
            // talkPostBtn
            // 
            this.talkPostBtn.Location = new System.Drawing.Point(440, 107);
            this.talkPostBtn.Name = "talkPostBtn";
            this.talkPostBtn.Size = new System.Drawing.Size(133, 28);
            this.talkPostBtn.TabIndex = 25;
            this.talkPostBtn.Text = "Need To Talk, Text Me";
            this.talkPostBtn.UseVisualStyleBackColor = true;
            // 
            // happyPostBtn
            // 
            this.happyPostBtn.Location = new System.Drawing.Point(440, 73);
            this.happyPostBtn.Name = "happyPostBtn";
            this.happyPostBtn.Size = new System.Drawing.Size(90, 28);
            this.happyPostBtn.TabIndex = 24;
            this.happyPostBtn.Text = "I\'m Happy!";
            this.happyPostBtn.UseVisualStyleBackColor = true;
            // 
            // sadPostBtn
            // 
            this.sadPostBtn.Location = new System.Drawing.Point(439, 38);
            this.sadPostBtn.Name = "sadPostBtn";
            this.sadPostBtn.Size = new System.Drawing.Size(91, 28);
            this.sadPostBtn.TabIndex = 23;
            this.sadPostBtn.Text = "I\'m Sad..";
            this.sadPostBtn.UseVisualStyleBackColor = true;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(212, 194);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.postBindingSource, "PictureURL", true));
            this.pictureURLPictureBox.Location = new System.Drawing.Point(104, 125);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(98, 91);
            this.pictureURLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureURLPictureBox.TabIndex = 5;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // messageTextBox
            // 
            this.messageTextBox.AllowDrop = true;
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(225, 125);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(187, 40);
            this.messageTextBox.TabIndex = 3;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listBoxPosts.Location = new System.Drawing.Point(104, 11);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.ScrollAlwaysVisible = true;
            this.listBoxPosts.Size = new System.Drawing.Size(308, 95);
            this.listBoxPosts.TabIndex = 21;
            this.listBoxPosts.ValueMember = "Caption";
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
            // ProfileTitle
            // 
            this.ProfileTitle.AutoSize = true;
            this.ProfileTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProfileTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProfileTitle.Location = new System.Drawing.Point(16, 13);
            this.ProfileTitle.Name = "ProfileTitle";
            this.ProfileTitle.Size = new System.Drawing.Size(118, 25);
            this.ProfileTitle.TabIndex = 1;
            this.ProfileTitle.Text = "My Profile";
            // 
            // importPostsBtn
            // 
            this.importPostsBtn.Location = new System.Drawing.Point(458, 207);
            this.importPostsBtn.Name = "importPostsBtn";
            this.importPostsBtn.Size = new System.Drawing.Size(113, 32);
            this.importPostsBtn.TabIndex = 28;
            this.importPostsBtn.Text = "Import posts";
            this.importPostsBtn.UseVisualStyleBackColor = true;
            this.importPostsBtn.Click += new System.EventHandler(this.importPostsBtn_Click);
            // 
            // ProfilePanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(createdTimeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(messageLabel);
            this.Controls.Add(pictureURLLabel);
            this.Controls.Add(this.postSomethingButton);
            this.Controls.Add(this.PostSomethingTextBox);
            this.Controls.Add(this.postSomethingLabel);
            this.Controls.Add(this.profileActivityBtn);
            this.Controls.Add(this.flowLayoutPanelProfile);
            this.Controls.Add(this.profilePicturesBtn);
            this.Controls.Add(this.profilePostBtn);
            this.Controls.Add(this.ProfileTitle);
            this.Name = "ProfilePanelControl";
            this.Size = new System.Drawing.Size(597, 370);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.flowLayoutPanelProfile.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button profilePostBtn;
        private System.Windows.Forms.Button profilePicturesBtn;
        private System.Windows.Forms.Label ProfileTitle;
        private System.Windows.Forms.Button profileActivityBtn;
        private System.Windows.Forms.Button postSomethingButton;
        private System.Windows.Forms.TextBox PostSomethingTextBox;
        private System.Windows.Forms.Label postSomethingLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProfile;
        private System.Windows.Forms.BindingSource postBindingSource;
        private Panel panel1;
        private ListBox listBoxPosts;
        private DateTimePicker createdTimeDateTimePicker;
        private TextBox messageTextBox;
        private PictureBox pictureURLPictureBox;
        private Label label1;
        private Button talkPostBtn;
        private Button happyPostBtn;
        private Button sadPostBtn;
        private Button exportPostsBtn;
        private SaveFileDialog saveFileDialog1;
        private Button importPostsBtn;
    }
}
