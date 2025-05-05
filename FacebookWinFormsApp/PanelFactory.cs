using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures;

namespace FacebookWinFormsApp
{

    public static class PanelFactory
    {
        public static BasePanelControl CreatePanel(
            ePanelType i_PanelType,
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
                    panel = new ProfilePanelControl();
                    break;

                case ePanelType.Photos:
                    panel = new AlbumsPanelControl();
                    break;

                case ePanelType.FriendFeed:
                    panel = new FriendFeedPanelControl();
                    break;

                case ePanelType.Friends:
                    FriendsPanelControl friendsPanel = new FriendsPanelControl();
                    friendsPanel.UpdateFriends();
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
