using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures;

namespace FacebookWinFormsApp
{
    public enum ePanelType
    {
        Profile,
        Photos,
        FriendFeed,
        Friends
    }

    public static class PanelFactory
    {
        public static BasePanelControl CreatePanel(
            ePanelType i_PanelType,
            User i_User,
            UserActivity i_Activity,
            Dictionary<string, Control> io_PanelCache)
        {
            string key = i_PanelType.ToString();

            if (io_PanelCache.ContainsKey(key))
            {
                return io_PanelCache[key] as BasePanelControl;
            }

            BasePanelControl panel = null;

            switch (i_PanelType)
            {
                case ePanelType.Profile:
                    panel = new ProfilePanelControl(i_User, i_Activity);
                    break;

                case ePanelType.Photos:
                    panel = new AlbumsPanelControl(i_User, i_Activity);
                    break;

                case ePanelType.FriendFeed:
                    panel = new FriendFeedPanelControl(i_User, i_Activity);
                    break;

                case ePanelType.Friends:
                    FriendsPanelControl friendsPanel = new FriendsPanelControl();
                    friendsPanel.UpdateFriends(i_User);
                    panel = friendsPanel;
                    break;
            }

            if (panel != null)
            {
                io_PanelCache[key] = panel;
            }

            return panel;
        }
    }
}
