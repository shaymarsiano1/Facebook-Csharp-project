namespace BasicFacebookFeatures
{
    partial class PersonalPostControl
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
            this.personalPostText = new System.Windows.Forms.Label();
            this.personalPostDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personalPostText
            // 
            this.personalPostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.personalPostText.Location = new System.Drawing.Point(3, 25);
            this.personalPostText.Name = "personalPostText";
            this.personalPostText.Size = new System.Drawing.Size(397, 63);
            this.personalPostText.TabIndex = 0;
            this.personalPostText.Text = "label1";
            // 
            // personalPostDate
            // 
            this.personalPostDate.AutoSize = true;
            this.personalPostDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.personalPostDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.personalPostDate.Location = new System.Drawing.Point(97, 0);
            this.personalPostDate.Name = "personalPostDate";
            this.personalPostDate.Size = new System.Drawing.Size(41, 15);
            this.personalPostDate.TabIndex = 1;
            this.personalPostDate.Text = "label2";
            // 
            // PersonalPostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personalPostDate);
            this.Controls.Add(this.personalPostText);
            this.Name = "PersonalPostControl";
            this.Size = new System.Drawing.Size(403, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personalPostText;
        private System.Windows.Forms.Label personalPostDate;
    }
}
