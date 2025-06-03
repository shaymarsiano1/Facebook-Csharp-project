using BasicFacebookFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FacebookWinFormsApp
{
    public partial class NavigationPanelControl : BasePanelControl
    {
        public event EventHandler<PanelEventArgs> PanelButtonClicked;
        public event EventHandler SettingsButtonClicked;
        private Dictionary<string, NavigationItem> m_NavigationMap;
        private Menu m_Menu;

        public NavigationPanelControl()
        {
            InitializeComponent();
            List<NavigationItem> items = initializeNavigationItems();
            m_NavigationMap = items.ToDictionary(item => item.Text);
            m_Menu = new Menu(flowLayoutPanelNavigation);

            m_Menu.AddRange(items);
            m_Menu.BuildUI();
        }

        private List<NavigationItem> initializeNavigationItems()
        {
            return this.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(method => method.GetCustomAttributes(typeof(NavigationActionAttribute), false).Length > 0)
                .Select(method =>
                {
                    var attr = (NavigationActionAttribute)method.GetCustomAttributes(typeof(NavigationActionAttribute), false).First();
                    Action action = (Action)Delegate.CreateDelegate(typeof(Action), this, method);
                    return new NavigationItem(attr.DisplayName, action);
                })
                .ToList();
        }

        [NavigationAction("Profile")]
        private void ShowProfilePanel()
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.Profile));
        }

        [NavigationAction("Photos")]
        private void ShowPhotosPanel()
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.Photos));
        }

        [NavigationAction("Friends")]
        private void ShowFriendsPanel()
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.Friends));
        }

        [NavigationAction("Friend Feed")]
        private void ShowFriendFeedPanel()
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.FriendFeed));
        }

        [NavigationAction("Settings")]
        private void ShowSettingsPanel()
        {
            SettingsButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
