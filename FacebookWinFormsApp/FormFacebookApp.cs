using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWrapper;
using Timer = System.Windows.Forms.Timer;
using FacebookWrapper.ObjectModel;


namespace FacebookWinFormsApp
{
    public partial class FacebookApp : Form
    {
        private LoginResult LoginResult { get; }
        private User LoggedInUser { get;}
        private UserPreferences UserPreferences { get; }
        private UserActivity UserActivity { get; }
        private Timer RefreshTimer { get; set; }
        private Dictionary<string, Control> Panels { get; set; } = new Dictionary<string, Control>();

        public FacebookApp(User i_LoginUser)
        {
            LoggedInUser = i_LoginUser;
            UserPreferences = new UserPreferences();
            UserActivity = new UserActivity();
            InitializeComponent();
            RefreshTimer = new Timer();
            RefreshTimer.Tick += refreshTimer_Tick;
            applyUserPreferences();
            userInfoPanelControl21.LoadUserInfo(LoggedInUser);
            navigationPanelControl.PanelButtonClicked += handlePanelButtonClicked;
            navigationPanelControl.SettingsButtonClicked += navigationPanel_SettingsButtonClicked;


            showProfile();
        }

        public FacebookApp(LoginResult i_LoginResult)
        {
            LoginResult = i_LoginResult;
            LoggedInUser = i_LoginResult.LoggedInUser;
            UserPreferences = new UserPreferences();
            UserActivity = new UserActivity();
            InitializeComponent();
            RefreshTimer = new Timer();
            applyUserPreferences();
            userInfoPanelControl21.LoadUserInfo(LoggedInUser);
            navigationPanelControl.PanelButtonClicked += handlePanelButtonClicked;
            navigationPanelControl.SettingsButtonClicked += navigationPanel_SettingsButtonClicked;


            showProfile();
        }

        private void handlePanelButtonClicked(object sender, PanelEventArgs e)
        {
            BasePanelControl panel = PanelFactory.CreatePanel(e.PanelType, LoggedInUser, UserActivity, Panels);

            if (panel is AlbumsPanelControl albumsPanel)
            {
                UserActivity.PhotoViewCount++;
                albumsPanel.InitializeData();
            }
            else if (panel is FriendFeedPanelControl feedPanel)
            {
                UserActivity.FeedVisitCount++;
                feedPanel.InitializeData();
            }
            else if (panel is FriendsPanelControl friendsPanel)
            {
                UserActivity.FriendsVisitCount++;
                friendsPanel.InitializeData();
            }
            else if (panel is ProfilePanelControl profilePanel)
            {
                profilePanel.InitializeData();
            }
            else
            {
                throw new Exception("no such panel exists");
            }

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
            ProfilePanelControl profilePanel = PanelFactory.CreatePanel(ePanelType.Profile, LoggedInUser, UserActivity, Panels) as ProfilePanelControl;

            basePanel.Controls.Clear();
            basePanel.Controls.Add(profilePanel);
        }

        private void applyUserPreferences()
        {
            if (UserPreferences.AutoRefreshFeed)
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