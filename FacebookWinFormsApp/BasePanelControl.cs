using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class BasePanelControl : UserControl
        // This class supposed to be an Abstruct class, the designer blocked that option
    {
        protected User m_LoggedInUser;
        protected UserActivity m_UserActivity;
        private static DateTime s_LastRefetched = DateTime.Now;
        protected UserPreferences m_UserPreferences;

        private DateTime LastRefreshed { get; set; }
        private static Object s_Lock = new Object();

        public void SetContext(User i_User, UserActivity i_Activity,UserPreferences i_UserPreferences)
        {
            m_LoggedInUser = i_User;
            m_UserActivity = i_Activity;
            m_UserPreferences = i_UserPreferences;
        }

        protected bool RefetchIfNeeded()
        {
            bool didRefetch = false;

            lock (s_Lock)
            {
                int refreshInterval = m_UserPreferences?.RefreshInterval ?? 60;
                if ((DateTime.Now - s_LastRefetched).TotalSeconds > refreshInterval)
                {
                    try
                    {
                        m_LoggedInUser.ReFetch();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to ReFetch data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    s_LastRefetched = DateTime.Now;
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