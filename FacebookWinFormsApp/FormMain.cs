using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWinFormsApp;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private ApplicationSettings m_ApplicationSettings;
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_ApplicationSettings = ApplicationSettings.LoadSettingFromFile();
            this.Size = m_ApplicationSettings.LastWindowSize;
            this.Location = m_ApplicationSettings.LastWindowLocation;
            this.rememberMe.Checked = m_ApplicationSettings.RememberUser;

        }
        FacebookWrapper.LoginResult m_LoginResult;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (m_ApplicationSettings.RememberUser && string.IsNullOrEmpty(m_ApplicationSettings.lastUserAccessToken) == false) 
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(m_ApplicationSettings.lastUserAccessToken);

                    if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) == false) 
                    {
                        MessageBox.Show("Auto-login failed. Please login manually.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    FacebookApp facebookApp = new FacebookApp(m_LoginResult);
                    this.Location = m_ApplicationSettings.LastWindowLocation;
                    this.Size = m_ApplicationSettings.LastWindowSize;
                    
                    facebookApp.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Auto-login failed: {ex.Message}");
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_ApplicationSettings.LastWindowSize = this.Size;
            m_ApplicationSettings.LastWindowLocation = this.Location;
            m_ApplicationSettings.RememberUser = this.rememberMe.Checked;

            if (this.rememberMe.Checked == true) 
            {
                m_ApplicationSettings.lastUserAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_ApplicationSettings.lastUserAccessToken = null;
            }

            m_ApplicationSettings.SaveSettingsToFile();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
            "1145497437055500",
            "email",
            "public_profile",
            "user_posts",
            "user_photos",
            "user_friends",
            "user_events",
            "user_videos"
            );
            string accessToken = m_LoginResult.AccessToken;

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) == true) 
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;

                FacebookApp facebookApp = new FacebookApp(m_LoginResult);
                facebookApp.Show();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }
    }
}