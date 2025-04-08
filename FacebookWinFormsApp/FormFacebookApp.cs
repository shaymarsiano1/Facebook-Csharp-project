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
            navigationPanelControl.ProfileButtonClicked += navigationPanel_ProfileButtonClicked;
            navigationPanelControl.PhotosButtonClicked += navigationPanel_PhotosButtonClicked;
            navigationPanelControl.SettingsButtonClicked += navigationPanel_SettingsButtonClicked;
            navigationPanelControl.FriendsButtonClicked += navigationPanel_FriendsButtonClicked;
            navigationPanelControl.FriendFeedButtonClicked += navigationPanel_FriendFeedButtonClicked;

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
            navigationPanelControl.ProfileButtonClicked += navigationPanel_ProfileButtonClicked;
            navigationPanelControl.PhotosButtonClicked += navigationPanel_PhotosButtonClicked;
            navigationPanelControl.SettingsButtonClicked += navigationPanel_SettingsButtonClicked;
            navigationPanelControl.FriendsButtonClicked += navigationPanel_FriendsButtonClicked;
            navigationPanelControl.FriendFeedButtonClicked += navigationPanel_FriendFeedButtonClicked;
            showProfile();
        }

        private void navigationPanel_ProfileButtonClicked(object sender, EventArgs e)
        {
            showProfile();
        }

        private void navigationPanel_PhotosButtonClicked(object sender, EventArgs e)
        {
            basePanel.Controls.Clear();
            AlbumsPanelControl photosPanelControl;
            if (Panels.ContainsKey("PhotosPanel") == false)
            {
                photosPanelControl = new AlbumsPanelControl(LoggedInUser, UserActivity);
                Panels["PhotosPanel"] = photosPanelControl;
            }
            else
            {
                photosPanelControl = Panels["PhotosPanel"] as AlbumsPanelControl;
                photosPanelControl.InitializeData();
            }
            basePanel.Controls.Add(photosPanelControl);
        }
        
        private void navigationPanel_SettingsButtonClicked(object sender, EventArgs e)
        {
            FormUserPreferences preferencesForm = new FormUserPreferences(UserPreferences);
            if (preferencesForm.ShowDialog() == DialogResult.OK)
            {
                applyUserPreferences();
            }
        }

        private void navigationPanel_FriendsButtonClicked(object sender, EventArgs e)
        {
            UserActivity.FriendsVisitCount++;
            basePanel.Controls.Clear();
            FriendsPanelControl friendsPanel = new FriendsPanelControl();
            friendsPanel.UpdateFriends(LoggedInUser);
            basePanel.Controls.Add(friendsPanel);
        }

        private void navigationPanel_FriendFeedButtonClicked(object sender, EventArgs e)
        {
            basePanel.Controls.Clear();
            basePanel.Controls.Clear();
            UserActivity.FeedVisitCount++;
            FriendFeedPanelControl friendFeedPanel;

            if (Panels.ContainsKey("FriendFeed") == false)
            {
                friendFeedPanel = new FriendFeedPanelControl(LoggedInUser, UserActivity);
                Panels["FriendFeed"] = friendFeedPanel;
            }
            else
            {
                friendFeedPanel = Panels["FriendFeed"] as FriendFeedPanelControl;
                friendFeedPanel.InitializeData();
            }
            basePanel.Controls.Add(friendFeedPanel);
        }

        private void showProfile()
        {
            basePanel.Controls.Clear();
            ProfilePanelControl profilePanel = new ProfilePanelControl(LoggedInUser, UserActivity);
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