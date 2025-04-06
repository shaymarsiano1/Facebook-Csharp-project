namespace BasicFacebookFeatures
{
    partial class UserActivityPanelControl
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
            this.labelSessionDuration = new System.Windows.Forms.Label();
            this.labelPhotosCount = new System.Windows.Forms.Label();
            this.labelFriendsCount = new System.Windows.Forms.Label();
            this.labelFeedCount = new System.Windows.Forms.Label();
            this.labelPostCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSessionDuration
            // 
            this.labelSessionDuration.AutoSize = true;
            this.labelSessionDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSessionDuration.Location = new System.Drawing.Point(29, 36);
            this.labelSessionDuration.Name = "labelSessionDuration";
            this.labelSessionDuration.Size = new System.Drawing.Size(50, 16);
            this.labelSessionDuration.TabIndex = 0;
            this.labelSessionDuration.Text = "label1";
            // 
            // labelPhotosCount
            // 
            this.labelPhotosCount.AutoSize = true;
            this.labelPhotosCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPhotosCount.Location = new System.Drawing.Point(29, 77);
            this.labelPhotosCount.Name = "labelPhotosCount";
            this.labelPhotosCount.Size = new System.Drawing.Size(50, 16);
            this.labelPhotosCount.TabIndex = 1;
            this.labelPhotosCount.Text = "label2";
            // 
            // labelFriendsCount
            // 
            this.labelFriendsCount.AutoSize = true;
            this.labelFriendsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendsCount.Location = new System.Drawing.Point(29, 114);
            this.labelFriendsCount.Name = "labelFriendsCount";
            this.labelFriendsCount.Size = new System.Drawing.Size(50, 16);
            this.labelFriendsCount.TabIndex = 2;
            this.labelFriendsCount.Text = "label3";
            // 
            // labelFeedCount
            // 
            this.labelFeedCount.AutoSize = true;
            this.labelFeedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFeedCount.Location = new System.Drawing.Point(29, 149);
            this.labelFeedCount.Name = "labelFeedCount";
            this.labelFeedCount.Size = new System.Drawing.Size(50, 16);
            this.labelFeedCount.TabIndex = 3;
            this.labelFeedCount.Text = "label3";
            // 
            // labelPostCount
            // 
            this.labelPostCount.AutoSize = true;
            this.labelPostCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostCount.Location = new System.Drawing.Point(29, 186);
            this.labelPostCount.Name = "labelPostCount";
            this.labelPostCount.Size = new System.Drawing.Size(50, 16);
            this.labelPostCount.TabIndex = 4;
            this.labelPostCount.Text = "label3";
            // 
            // UserActivityPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPostCount);
            this.Controls.Add(this.labelFeedCount);
            this.Controls.Add(this.labelFriendsCount);
            this.Controls.Add(this.labelPhotosCount);
            this.Controls.Add(this.labelSessionDuration);
            this.Name = "UserActivityPanelControl";
            this.Size = new System.Drawing.Size(431, 244);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSessionDuration;
        private System.Windows.Forms.Label labelPhotosCount;
        private System.Windows.Forms.Label labelFriendsCount;
        private System.Windows.Forms.Label labelFeedCount;
        private System.Windows.Forms.Label labelPostCount;
    }
}
