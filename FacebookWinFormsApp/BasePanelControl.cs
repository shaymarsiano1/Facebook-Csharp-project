using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class BasePanelControl : UserControl
        // This class supposed to be an Abstruct class, the designer blocked that option
    {
        protected User LoggedInUser { get; set; }
        protected UserActivity UserActivity { get; set; }
        private static DateTime LastRefetched { get; set; } = DateTime.Now;
        protected UserPreferences UserPreferences { get; set; }
        private DateTime LastRefreshed { get; set; }
        private static Object s_Lock = new Object();

        public BasePanelControl()
        {
            LoggedInUser = FacebookUserSingleton.Instance.LoggedInUser;
            UserActivity = UserActivity.Instance;
            InitializeComponent();
        }

        public void SetContext(User i_User, UserActivity i_Activity,UserPreferences i_UserPreferences)
        {
            LoggedInUser = i_User;
            UserActivity = i_Activity;
            UserPreferences = i_UserPreferences;
        }

        protected bool RefetchIfNeeded()
        {
            bool didRefetch = false;

            lock (s_Lock) 
            {
                int refreshInterval = UserPreferences?.RefreshInterval ?? 60;
                if ((DateTime.Now - LastRefetched).TotalSeconds > refreshInterval)
                {
                    try
                    {
                        LoggedInUser.ReFetch();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to ReFetch data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LastRefetched = DateTime.Now;
                    didRefetch = true;
                }
            }

            return didRefetch;
        }

        public virtual void InitializeData()
        {
            RefetchIfNeeded();
        }
    }
}