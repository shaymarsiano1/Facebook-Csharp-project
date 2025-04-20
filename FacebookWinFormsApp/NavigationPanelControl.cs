using BasicFacebookFeatures;
using System;

namespace FacebookWinFormsApp
{
    public partial class NavigationPanelControl : BasePanelControl
    {
        public event EventHandler<PanelEventArgs> PanelButtonClicked;
        public event EventHandler SettingsButtonClicked;

        public NavigationPanelControl()
        {
            InitializeComponent();
        }

        protected virtual void OnButtonProfileClick(object sender, EventArgs e)
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.Profile));
        }

        protected virtual void OnButtonPhotosClick(object sender, EventArgs e)
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.Photos));
        }

        protected virtual void OnButtonSettingsClick(object sender, EventArgs e)
        {
            SettingsButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnButtonFriendsClick(object sender, EventArgs e)
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.Friends));
        }

        protected virtual void OnButtonFriendsFeedClick(object sender, EventArgs e)
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.FriendFeed));
        }
    }
}