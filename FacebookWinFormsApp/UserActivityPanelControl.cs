using System;
using System.Windows.Forms;
using FacebookWinFormsApp;

namespace BasicFacebookFeatures
{
    public partial class UserActivityPanelControl : BasePanelControl
    {
        Label m_SessionTimeLabel;

        public UserActivityPanelControl()
        {
            InitializeComponent();
            setupTimerLabel();
        }

        private void setupTimerLabel()
        {
            m_SessionTimeLabel = new Label();
            m_SessionTimeLabel.Dock = DockStyle.Top;
            m_SessionTimeLabel.AutoSize = true;
            Controls.Add(m_SessionTimeLabel);

        }

        public void LoadUserActivity()
        {

            foreach (ePanelType panelType in Enum.GetValues(typeof(ePanelType)))
            {
                Label label = new Label();
                label.Text = $"{panelType} Panel Visited: {UserActivity.GetPanelVisitCount(panelType)}";
                label.Dock = DockStyle.Top;
                label.AutoSize = true;
                Controls.Add(label);
            }
            updateDuration();
        }

        private void updateDuration()
        {

            TimeSpan duration = DateTime.Now - UserActivity.SessionStartTime;
            m_SessionTimeLabel.Text = $"Session time: {duration:hh\\:mm\\:ss}";

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            updateDuration();
        }
    }
}