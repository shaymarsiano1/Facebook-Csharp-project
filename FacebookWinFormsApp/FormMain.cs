using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWinFormsApp;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private ApplicationSettings ApplicationSettings { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            ApplicationSettings = ApplicationSettings.LoadSettingFromFile();
            this.Size = ApplicationSettings.LastWindowSize;
            this.Location = ApplicationSettings.LastWindowLocation;
            this.rememberMe.Checked = ApplicationSettings.RememberUser;

        }

        FacebookWrapper.LoginResult m_LoginResult;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (ApplicationSettings.RememberUser && string.IsNullOrEmpty(ApplicationSettings.LastUserAccessToken) == false) 
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(ApplicationSettings.LastUserAccessToken);

                    if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) == false) 
                    {
                        MessageBox.Show("Auto-login failed. Please login manually.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    FacebookApp facebookApp = new FacebookApp(m_LoginResult);
                    this.Location = ApplicationSettings.LastWindowLocation;
                    this.Size = ApplicationSettings.LastWindowSize;
                    
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
            ApplicationSettings.LastWindowSize = this.Size;
            ApplicationSettings.LastWindowLocation = this.Location;
            ApplicationSettings.RememberUser = this.rememberMe.Checked;

            if (this.rememberMe.Checked == true) 
            {
                ApplicationSettings.LastUserAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                ApplicationSettings.LastUserAccessToken = null;
            }

            ApplicationSettings.SaveSettingsToFile();
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
            "user_videos"            );
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