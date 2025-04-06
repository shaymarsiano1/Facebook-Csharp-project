using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class UserInfoPanelControl : BasePanelControl
    {
        public UserInfoPanelControl()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(User i_LoggedInUser)
        {
            try
            {
                labelUserName.Text = i_LoggedInUser.Name;
                pictureBoxUserProfile.ImageLocation = i_LoggedInUser.PictureNormalURL;
                labelUserEmail.Text = i_LoggedInUser.Email ?? "Email not available";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user info: {ex.Message}");
            }
        }
    }
}