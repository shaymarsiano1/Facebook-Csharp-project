namespace BasicFacebookFeatures
{
    partial class AlbumTemplateControl
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
            this.Title = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.albumCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumCover)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Title.Location = new System.Drawing.Point(12, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(79, 15);
            this.Title.TabIndex = 1;
            this.Title.Text = "Album Title";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Date.Location = new System.Drawing.Point(12, 43);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(81, 15);
            this.Date.TabIndex = 2;
            this.Date.Text = "Album Date";
            // 
            // albumCover
            // 
            this.albumCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.albumCover.Location = new System.Drawing.Point(219, 58);
            this.albumCover.Name = "albumCover";
            this.albumCover.Size = new System.Drawing.Size(120, 107);
            this.albumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumCover.TabIndex = 0;
            this.albumCover.TabStop = false;
            // 
            // AlbumTemplateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.albumCover);
            this.Name = "AlbumTemplateControl";
            this.Size = new System.Drawing.Size(347, 173);
            ((System.ComponentModel.ISupportInitialize)(this.albumCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox albumCover;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Date;
    }
}
