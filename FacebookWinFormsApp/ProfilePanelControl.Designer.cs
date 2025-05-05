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
            System.Windows.Forms.Label messageLabel1;
            System.Windows.Forms.Label postTypeLabel;
            System.Windows.Forms.Label createdTimeLabel1;
            System.Windows.Forms.Label pictureURLLabel1;
            System.Windows.Forms.Label applicationSourceLabel;
            this.postSomethingButton = new System.Windows.Forms.Button();
            this.PostSomethingTextBox = new System.Windows.Forms.TextBox();
            this.postSomethingLabel = new System.Windows.Forms.Label();
            this.profileActivityBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanelProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureURLPictureBox = new System.Windows.Forms.PictureBox();
            this.allPostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postTypeLabel1 = new System.Windows.Forms.Label();
            this.creatorLabel1 = new System.Windows.Forms.Label();
            this.importPostsBtn = new System.Windows.Forms.Button();
            this.exportPostsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.talkPostBtn = new System.Windows.Forms.Button();
            this.happyPostBtn = new System.Windows.Forms.Button();
            this.sadPostBtn = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.profilePicturesBtn = new System.Windows.Forms.Button();
            this.profilePostBtn = new System.Windows.Forms.Button();
            this.ProfileTitle = new System.Windows.Forms.Label();
            this.applicationSourceLabel1 = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            pictureURLLabel = new System.Windows.Forms.Label();
            messageLabel1 = new System.Windows.Forms.Label();
            postTypeLabel = new System.Windows.Forms.Label();
            createdTimeLabel1 = new System.Windows.Forms.Label();
            pictureURLLabel1 = new System.Windows.Forms.Label();
            applicationSourceLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelProfile.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPostsBindingSource)).BeginInit();
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
            // messageLabel1
            // 
            messageLabel1.AutoSize = true;
            messageLabel1.Location = new System.Drawing.Point(316, 115);
            messageLabel1.Name = "messageLabel1";
            messageLabel1.Size = new System.Drawing.Size(53, 13);
            messageLabel1.TabIndex = 29;
            messageLabel1.Text = "Message:";
            // 
            // postTypeLabel
            // 
            postTypeLabel.AutoSize = true;
            postTypeLabel.Location = new System.Drawing.Point(221, 198);
            postTypeLabel.Name = "postTypeLabel";
            postTypeLabel.Size = new System.Drawing.Size(58, 13);
            postTypeLabel.TabIndex = 31;
            postTypeLabel.Text = "Post Type:";
            // 
            // createdTimeLabel1
            // 
            createdTimeLabel1.AutoSize = true;
            createdTimeLabel1.Location = new System.Drawing.Point(145, 219);
            createdTimeLabel1.Name = "createdTimeLabel1";
            createdTimeLabel1.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel1.TabIndex = 32;
            createdTimeLabel1.Text = "Created Time:";
            // 
            // pictureURLLabel1
            // 
            pictureURLLabel1.Location = new System.Drawing.Point(0, 0);
            pictureURLLabel1.Name = "pictureURLLabel1";
            pictureURLLabel1.Size = new System.Drawing.Size(100, 23);
            pictureURLLabel1.TabIndex = 0;
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
            this.panel1.Controls.Add(applicationSourceLabel);
            this.panel1.Controls.Add(this.applicationSourceLabel1);
            this.panel1.Controls.Add(pictureURLLabel1);
            this.panel1.Controls.Add(this.pictureURLPictureBox);
            this.panel1.Controls.Add(createdTimeLabel1);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(postTypeLabel);
            this.panel1.Controls.Add(this.postTypeLabel1);
            this.panel1.Controls.Add(this.creatorLabel1);
            this.panel1.Controls.Add(messageLabel1);
            this.panel1.Controls.Add(this.importPostsBtn);
            this.panel1.Controls.Add(this.exportPostsBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.talkPostBtn);
            this.panel1.Controls.Add(this.happyPostBtn);
            this.panel1.Controls.Add(this.sadPostBtn);
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Controls.Add(this.listBoxPosts);
            this.panel1.Location = new System.Drawing.Point(3, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 268);
            this.panel1.TabIndex = 1;
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.allPostsBindingSource, "PictureURL", true));
            this.pictureURLPictureBox.Location = new System.Drawing.Point(104, 119);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(111, 97);
            this.pictureURLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureURLPictureBox.TabIndex = 34;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // allPostsBindingSource
            // 
            this.allPostsBindingSource.AllowNew = true;
            this.allPostsBindingSource.DataSource = typeof(BasicFacebookFeatures.IPost);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.allPostsBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Enabled = false;
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(224, 214);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.createdTimeDateTimePicker.TabIndex = 33;
            // 
            // postTypeLabel1
            // 
            this.postTypeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allPostsBindingSource, "PostType", true));
            this.postTypeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postTypeLabel1.Location = new System.Drawing.Point(326, 197);
            this.postTypeLabel1.Name = "postTypeLabel1";
            this.postTypeLabel1.Size = new System.Drawing.Size(100, 23);
            this.postTypeLabel1.TabIndex = 32;
            this.postTypeLabel1.Text = "label2";
            // 
            // creatorLabel1
            // 
            this.creatorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allPostsBindingSource, "Creator", true));
            this.creatorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.creatorLabel1.Location = new System.Drawing.Point(221, 115);
            this.creatorLabel1.Name = "creatorLabel1";
            this.creatorLabel1.Size = new System.Drawing.Size(80, 13);
            this.creatorLabel1.TabIndex = 30;
            this.creatorLabel1.Text = "label2";
            // 
            // importPostsBtn
            // 
            this.importPostsBtn.BackColor = System.Drawing.Color.DarkRed;
            this.importPostsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.importPostsBtn.Location = new System.Drawing.Point(460, 193);
            this.importPostsBtn.Name = "importPostsBtn";
            this.importPostsBtn.Size = new System.Drawing.Size(113, 32);
            this.importPostsBtn.TabIndex = 28;
            this.importPostsBtn.Text = "Import posts";
            this.importPostsBtn.UseVisualStyleBackColor = false;
            this.importPostsBtn.Click += new System.EventHandler(this.importPostsBtn_Click);
            // 
            // exportPostsBtn
            // 
            this.exportPostsBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.exportPostsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exportPostsBtn.Location = new System.Drawing.Point(460, 155);
            this.exportPostsBtn.Name = "exportPostsBtn";
            this.exportPostsBtn.Size = new System.Drawing.Size(113, 32);
            this.exportPostsBtn.TabIndex = 27;
            this.exportPostsBtn.Text = "Export my posts";
            this.exportPostsBtn.UseVisualStyleBackColor = false;
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
            this.talkPostBtn.BackColor = System.Drawing.Color.Khaki;
            this.talkPostBtn.Location = new System.Drawing.Point(440, 107);
            this.talkPostBtn.Name = "talkPostBtn";
            this.talkPostBtn.Size = new System.Drawing.Size(133, 28);
            this.talkPostBtn.TabIndex = 25;
            this.talkPostBtn.Text = "Need To Talk, Text Me";
            this.talkPostBtn.UseVisualStyleBackColor = false;
            // 
            // happyPostBtn
            // 
            this.happyPostBtn.BackColor = System.Drawing.Color.Green;
            this.happyPostBtn.Location = new System.Drawing.Point(440, 73);
            this.happyPostBtn.Name = "happyPostBtn";
            this.happyPostBtn.Size = new System.Drawing.Size(90, 28);
            this.happyPostBtn.TabIndex = 24;
            this.happyPostBtn.Text = "I\'m Happy!";
            this.happyPostBtn.UseVisualStyleBackColor = false;
            // 
            // sadPostBtn
            // 
            this.sadPostBtn.BackColor = System.Drawing.Color.Red;
            this.sadPostBtn.Location = new System.Drawing.Point(439, 38);
            this.sadPostBtn.Name = "sadPostBtn";
            this.sadPostBtn.Size = new System.Drawing.Size(91, 28);
            this.sadPostBtn.TabIndex = 23;
            this.sadPostBtn.Text = "I\'m Sad..";
            this.sadPostBtn.UseVisualStyleBackColor = false;
            // 
            // messageTextBox
            // 
            this.messageTextBox.AllowDrop = true;
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allPostsBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(224, 131);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(187, 40);
            this.messageTextBox.TabIndex = 3;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.allPostsBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listBoxPosts.Location = new System.Drawing.Point(103, 3);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.ScrollAlwaysVisible = true;
            this.listBoxPosts.Size = new System.Drawing.Size(308, 108);
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
            // applicationSourceLabel
            // 
            applicationSourceLabel.AutoSize = true;
            applicationSourceLabel.Location = new System.Drawing.Point(221, 174);
            applicationSourceLabel.Name = "applicationSourceLabel";
            applicationSourceLabel.Size = new System.Drawing.Size(99, 13);
            applicationSourceLabel.TabIndex = 34;
            applicationSourceLabel.Text = "Application Source:";
            // 
            // applicationSourceLabel1
            // 
            this.applicationSourceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allPostsBindingSource, "ApplicationSource", true));
            this.applicationSourceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.applicationSourceLabel1.Location = new System.Drawing.Point(326, 174);
            this.applicationSourceLabel1.Name = "applicationSourceLabel1";
            this.applicationSourceLabel1.Size = new System.Drawing.Size(73, 23);
            this.applicationSourceLabel1.TabIndex = 35;
            this.applicationSourceLabel1.Text = "label2";
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
            this.Size = new System.Drawing.Size(652, 370);
            this.flowLayoutPanelProfile.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPostsBindingSource)).EndInit();
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
        private Panel panel1;
        private ListBox listBoxPosts;
        private TextBox messageTextBox;
        private Label label1;
        private Button talkPostBtn;
        private Button happyPostBtn;
        private Button sadPostBtn;
        private Button exportPostsBtn;
        private Button importPostsBtn;
        private BindingSource allPostsBindingSource;
        private Label creatorLabel1;
        private Label postTypeLabel1;
        private DateTimePicker createdTimeDateTimePicker;
        private PictureBox pictureURLPictureBox;
        private Label applicationSourceLabel1;
    }
}
