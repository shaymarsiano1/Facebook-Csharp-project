using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class UserActivityPanelControl : BasePanelControl
    {
        private Timer m_Timer;

        public UserActivityPanelControl()
        {
            InitializeComponent();
            setupTimer();
        }

        private void setupTimer()
        {
            m_Timer = new Timer();
            m_Timer.Interval = 1000; 
            m_Timer.Tick += (s, e) => updateDuration();
        }

        public void LoadUserActivity(UserActivity userActivity)
        {
            if (userActivity == null) return;

            m_UserActivity = userActivity;
            labelPhotosCount.Text = $"Photos viewed: {m_UserActivity.PhotoViewCount}";
            labelFriendsCount.Text = $"Friends list visits: {m_UserActivity.FriendsVisitCount}";
            labelFeedCount.Text = $"Feed visits: {m_UserActivity.FeedVisitCount}";
            labelPostCount.Text = $"Personal Posts visits: {m_UserActivity.PostsVisitCount}";
            updateDuration(); 
            m_Timer.Start();
        }

        private void updateDuration()
        {
            if (m_UserActivity != null)
            {
                TimeSpan duration = DateTime.Now - m_UserActivity.SessionStartTime;
                labelSessionDuration.Text = $"Session time: {duration:hh\\:mm\\:ss}";
            }
        }
    }
}