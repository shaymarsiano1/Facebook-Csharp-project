using FacebookWinFormsApp;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FriendsPanelControl : BasePanelControl
    {
        public FriendsPanelControl()
        {
            InitializeComponent();
        }

        public void UpdateFriends()
        {
            try
            {
                listBoxFriends.Items.Clear();
                listBoxFriends.DisplayMember = "Name";
                listBoxFriends.MouseDoubleClick += listBoxFriends_Click;
                foreach (User friend in LoggedInUser.Friends)
                {
                    listBoxFriends.Items.Add(friend);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading friends: {ex.Message}");
            }
        }

        private void listBoxFriends_Click(object sender, EventArgs e)
        {
            try
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;

                if (selectedFriend != null)
                {
                    FacebookApp facebookApp = new FacebookApp();
                    ownerObjectBindingSource.DataSource = selectedFriend;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing friend profile picture: {ex.Message}");
            }
        }
    }
}