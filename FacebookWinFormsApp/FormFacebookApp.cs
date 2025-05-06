using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace FacebookWinFormsApp
{
    public partial class FacebookApp : Form
    {
        private User LoggedInUser { get;}
        private UserPreferences UserPreferences { get; }
        private UserActivity UserActivity { get; }
        private Timer RefreshTimer { get; set; }
        private Dictionary<string, Control> Panels { get; set; } = new Dictionary<string, Control>();

        public FacebookApp()
        {
            LoggedInUser = FacebookUserSingleton.Instance.LoggedInUser;
            UserPreferences = new UserPreferences();
            UserActivity = UserActivity.Instance;
            InitializeComponent();
            RefreshTimer = new Timer();
            RefreshTimer.Tick += refreshTimer_Tick;
            applyUserPreferences();
            userInfoPanelControl21.LoadUserInfo(LoggedInUser);
            navigationPanelControl.PanelButtonClicked += handlePanelButtonClicked;
            navigationPanelControl.SettingsButtonClicked += navigationPanel_SettingsButtonClicked;

            showProfile();
        }

        private void handlePanelButtonClicked(object sender, PanelEventArgs e)
        {
            BasePanelControl panel = PanelFactory.CreatePanel(e.PanelType, Panels);

            panel.InitializeData();
            UserActivity.UpdateActivity(e.PanelType);
            basePanel.Controls.Clear();
            basePanel.Controls.Add(panel);
        }

        private void navigationPanel_SettingsButtonClicked(object sender, EventArgs e)
        {
            FormUserPreferences preferencesForm = new FormUserPreferences(UserPreferences);
            if (preferencesForm.ShowDialog() == DialogResult.OK)
            {
                applyUserPreferences();
            }
        }
       
        private void showProfile()
        {
            ProfilePanelControl profilePanel = PanelFactory.CreatePanel(ePanelType.Profile, Panels) as ProfilePanelControl;

            basePanel.Controls.Clear();
            basePanel.Controls.Add(profilePanel);
        }

        private void applyUserPreferences()
        {
            if (UserPreferences.AutoRefreshFeed == true) 
            {
                RefreshTimer.Interval = UserPreferences.RefreshInterval * 1000; 
                RefreshTimer.Start();
            }
            else
            {
                RefreshTimer.Stop();
            }

        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                LoggedInUser.ReFetch();

                if (Panels.ContainsKey("FriendFeed") && Panels["FriendFeed"].Visible)
                {
                    ((FriendFeedPanelControl)Panels["FriendFeed"]).InitializeData();
                }
                else if (Panels.ContainsKey("PhotosPanel") && Panels["PhotosPanel"].Visible)
                {
                    ((AlbumsPanelControl)Panels["PhotosPanel"]).InitializeData();
                }
            }
            catch (Facebook.FacebookOAuthException ex)
            {
                MessageBox.Show("Session expired. Please login again.");
                RefreshTimer.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Auto-refresh failed: " + ex.Message);
            }
        }
    }
}