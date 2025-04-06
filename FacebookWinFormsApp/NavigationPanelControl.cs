using BasicFacebookFeatures;
using System;

namespace FacebookWinFormsApp
{
    public partial class NavigationPanelControl : BasePanelControl
    {
        public event EventHandler ProfileButtonClicked;
        public event EventHandler PhotosButtonClicked;
        public event EventHandler SettingsButtonClicked;
        public event EventHandler FriendsButtonClicked;
        public event EventHandler FriendFeedButtonClicked;

        public NavigationPanelControl()
        {
            InitializeComponent();
        }

        protected virtual void OnbuttonProfileClick(object sender, EventArgs e)
        {
            ProfileButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnButtonPhotosClick(object sender, EventArgs e)
        {
            PhotosButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnButtonSettingsClick(object sender, EventArgs e)
        {
            SettingsButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnButtonFriendsClick(object sender, EventArgs e)
        {
            FriendsButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnButtonFriendsFeedClick(object sender, EventArgs e)
        {
            FriendFeedButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}