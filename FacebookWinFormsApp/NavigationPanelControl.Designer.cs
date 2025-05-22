namespace FacebookWinFormsApp
{
    partial class NavigationPanelControl
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
            this.flowLayoutPanelNavigation = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelNavigation
            // 
            this.flowLayoutPanelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelNavigation.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelNavigation.Name = "flowLayoutPanelNavigation";
            this.flowLayoutPanelNavigation.Size = new System.Drawing.Size(150, 272);
            this.flowLayoutPanelNavigation.TabIndex = 0;
            // 
            // NavigationPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.flowLayoutPanelNavigation);
            this.Name = "NavigationPanelControl";
            this.Size = new System.Drawing.Size(150, 275);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavigation;
    }
}