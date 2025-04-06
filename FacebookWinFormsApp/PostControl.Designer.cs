namespace BasicFacebookFeatures
{
    partial class PostControl
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
            this.ownerName = new System.Windows.Forms.Label();
            this.postDate = new System.Windows.Forms.Label();
            this.ownerProfilePicture = new System.Windows.Forms.PictureBox();
            this.postMessage = new System.Windows.Forms.Label();
            this.postPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ownerProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ownerName
            // 
            this.ownerName.AutoSize = true;
            this.ownerName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerName.Location = new System.Drawing.Point(88, 12);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(58, 22);
            this.ownerName.TabIndex = 0;
            this.ownerName.Text = "Name";
            // 
            // postDate
            // 
            this.postDate.AutoSize = true;
            this.postDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.postDate.Location = new System.Drawing.Point(89, 47);
            this.postDate.Name = "postDate";
            this.postDate.Size = new System.Drawing.Size(30, 13);
            this.postDate.TabIndex = 1;
            this.postDate.Text = "Date";
            // 
            // ownerProfilePicture
            // 
            this.ownerProfilePicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ownerProfilePicture.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_logo_svg;
            this.ownerProfilePicture.Location = new System.Drawing.Point(8, 11);
            this.ownerProfilePicture.Name = "ownerProfilePicture";
            this.ownerProfilePicture.Size = new System.Drawing.Size(65, 66);
            this.ownerProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ownerProfilePicture.TabIndex = 2;
            this.ownerProfilePicture.TabStop = false;
            // 
            // postMessage
            // 
            this.postMessage.Location = new System.Drawing.Point(11, 92);
            this.postMessage.Name = "postMessage";
            this.postMessage.Size = new System.Drawing.Size(193, 98);
            this.postMessage.TabIndex = 3;
            // 
            // postPicture
            // 
            this.postPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postPicture.Location = new System.Drawing.Point(285, 82);
            this.postPicture.Name = "postPicture";
            this.postPicture.Size = new System.Drawing.Size(122, 108);
            this.postPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postPicture.TabIndex = 4;
            this.postPicture.TabStop = false;
            // 
            // PostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.postPicture);
            this.Controls.Add(this.postMessage);
            this.Controls.Add(this.ownerProfilePicture);
            this.Controls.Add(this.postDate);
            this.Controls.Add(this.ownerName);
            this.Name = "PostControl";
            this.Size = new System.Drawing.Size(413, 196);
            ((System.ComponentModel.ISupportInitialize)(this.ownerProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ownerName;
        private System.Windows.Forms.Label postDate;
        private System.Windows.Forms.PictureBox ownerProfilePicture;
        private System.Windows.Forms.Label postMessage;
        private System.Windows.Forms.PictureBox postPicture;
    }
}
