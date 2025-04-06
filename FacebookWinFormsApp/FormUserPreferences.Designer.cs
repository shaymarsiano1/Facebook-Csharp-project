namespace FacebookWinFormsApp
{
    partial class FormUserPreferences
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
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.numericUpDownRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.labelRefreshInterval = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(25, 25);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(115, 17);
            this.checkBoxAutoRefresh.TabIndex = 0;
            this.checkBoxAutoRefresh.Text = "Auto Refresh Feed";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRefreshInterval
            // 
            this.numericUpDownRefreshInterval.Location = new System.Drawing.Point(144, 55);
            this.numericUpDownRefreshInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownRefreshInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRefreshInterval.Name = "numericUpDownRefreshInterval";
            this.numericUpDownRefreshInterval.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownRefreshInterval.TabIndex = 1;
            this.numericUpDownRefreshInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // labelRefreshInterval
            // 
            this.labelRefreshInterval.AutoSize = true;
            this.labelRefreshInterval.Location = new System.Drawing.Point(25, 57);
            this.labelRefreshInterval.Name = "labelRefreshInterval";
            this.labelRefreshInterval.Size = new System.Drawing.Size(85, 13);
            this.labelRefreshInterval.TabIndex = 10;
            this.labelRefreshInterval.Text = "Refresh Interval:";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(217, 57);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(47, 13);
            this.labelSeconds.TabIndex = 11;
            this.labelSeconds.Text = "seconds";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(197, 120);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(116, 120);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormUserPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 160);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelRefreshInterval);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownRefreshInterval);
            this.Controls.Add(this.checkBoxAutoRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRefreshInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.NumericUpDown numericUpDownRefreshInterval;
        private System.Windows.Forms.Label labelRefreshInterval;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}