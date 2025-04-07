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

            UserActivity = userActivity;
            labelPhotosCount.Text = $"Photos viewed: {UserActivity.PhotoViewCount}";
            labelFriendsCount.Text = $"Friends list visits: {UserActivity.FriendsVisitCount}";
            labelFeedCount.Text = $"Feed visits: {UserActivity.FeedVisitCount}";
            labelPostCount.Text = $"Personal Posts visits: {UserActivity.PostsVisitCount}";
            updateDuration(); 
            m_Timer.Start();
        }

        private void updateDuration()
        {
            if (UserActivity != null)
            {
                TimeSpan duration = DateTime.Now - UserActivity.SessionStartTime;
                labelSessionDuration.Text = $"Session time: {duration:hh\\:mm\\:ss}";
            }
        }
    }
}