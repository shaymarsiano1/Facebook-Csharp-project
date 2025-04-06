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
        private readonly LoginResult r_LoginResult;
        private readonly User r_LoggedInUser;
        private readonly UserPreferences r_UserPreferences;
        private readonly UserActivity r_UserActivity;
        private Timer m_RefreshTimer;
        private Dictionary<string, Control> m_Panels = new Dictionary<string, Control>();

        public FacebookApp(User i_LoginUser)
        {
            r_LoggedInUser = i_LoginUser;
            r_UserPreferences = new UserPreferences();
            r_UserActivity = new UserActivity();
            InitializeComponent();
            m_RefreshTimer = new Timer();
            m_RefreshTimer.Tick += refreshTimer_Tick;
            applyUserPreferences();
            userInfoPanelControl21.LoadUserInfo(r_LoggedInUser);
            navigationPanelControl.ProfileButtonClicked += navigationPanel_ProfileButtonClicked;
            navigationPanelControl.PhotosButtonClicked += navigationPanel_PhotosButtonClicked;
            navigationPanelControl.SettingsButtonClicked += navigationPanel_SettingsButtonClicked;
            navigationPanelControl.FriendsButtonClicked += navigationPanel_FriendsButtonClicked;
            navigationPanelControl.FriendFeedButtonClicked += navigationPanel_FriendFeedButtonClicked;

            showProfile();
        }

        public FacebookApp(LoginResult i_LoginResult)
        {
            r_LoginResult = i_LoginResult;
            r_LoggedInUser = i_LoginResult.LoggedInUser;
            r_UserPreferences = new UserPreferences();
            r_UserActivity = new UserActivity();
            InitializeComponent();
            m_RefreshTimer = new Timer();
            applyUserPreferences();
            userInfoPanelControl21.LoadUserInfo(r_LoggedInUser);
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
            if (m_Panels.ContainsKey("PhotosPanel") == false)
            {
                photosPanelControl = new AlbumsPanelControl(r_LoggedInUser, r_UserActivity);
                m_Panels["PhotosPanel"] = photosPanelControl;
            }
            else
            {
                photosPanelControl = m_Panels["PhotosPanel"] as AlbumsPanelControl;
                photosPanelControl.InitializeData();
            }
            basePanel.Controls.Add(photosPanelControl);
        }
        
        private void navigationPanel_SettingsButtonClicked(object sender, EventArgs e)
        {
            FormUserPreferences preferencesForm = new FormUserPreferences(r_UserPreferences);
            if (preferencesForm.ShowDialog() == DialogResult.OK)
            {
                applyUserPreferences();
            }
        }

        private void navigationPanel_FriendsButtonClicked(object sender, EventArgs e)
        {
            r_UserActivity.FriendsVisitCount++;
            basePanel.Controls.Clear();
            FriendsPanelControl friendsPanel = new FriendsPanelControl();
            friendsPanel.UpdateFriends(r_LoggedInUser);
            basePanel.Controls.Add(friendsPanel);
        }

        private void navigationPanel_FriendFeedButtonClicked(object sender, EventArgs e)
        {
            basePanel.Controls.Clear();
            basePanel.Controls.Clear();
            r_UserActivity.FeedVisitCount++;
            FriendFeedPanelControl friendFeedPanel;

            if (m_Panels.ContainsKey("FriendFeed") == false)
            {
                friendFeedPanel = new FriendFeedPanelControl(r_LoggedInUser, r_UserActivity);
                m_Panels["FriendFeed"] = friendFeedPanel;
            }
            else
            {
                friendFeedPanel = m_Panels["FriendFeed"] as FriendFeedPanelControl;
                friendFeedPanel.InitializeData();
            }
            basePanel.Controls.Add(friendFeedPanel);
        }

        private void showProfile()
        {
            basePanel.Controls.Clear();
            ProfilePanelControl profilePanel = new ProfilePanelControl(r_LoggedInUser, r_UserActivity);
            basePanel.Controls.Add(profilePanel);
        }

        private void applyUserPreferences()
        {
            if (r_UserPreferences.AutoRefreshFeed)
            {
                m_RefreshTimer.Interval = r_UserPreferences.RefreshInterval * 1000; 
                m_RefreshTimer.Start();
            }
            else
            {
                m_RefreshTimer.Stop();
            }

        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                r_LoggedInUser.ReFetch();

                if (m_Panels.ContainsKey("FriendFeed") && m_Panels["FriendFeed"].Visible)
                {
                    ((FriendFeedPanelControl)m_Panels["FriendFeed"]).InitializeData();
                }
                else if (m_Panels.ContainsKey("PhotosPanel") && m_Panels["PhotosPanel"].Visible)
                {
                    ((AlbumsPanelControl)m_Panels["PhotosPanel"]).InitializeData();
                }
            }
            catch (Facebook.FacebookOAuthException ex)
            {
                MessageBox.Show("Session expired. Please login again.");
                m_RefreshTimer.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Auto-refresh failed: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}