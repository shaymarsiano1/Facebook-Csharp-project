using BasicFacebookFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    public partial class NavigationPanelControl : BasePanelControl
    {
        public event EventHandler<PanelEventArgs> PanelButtonClicked;
        public event EventHandler SettingsButtonClicked;
        private Dictionary<string, NavigationItem> m_NavigationMap;

        public NavigationPanelControl()
        {
            InitializeComponent();
            loadNavigationMap();
            //buttonProfile.Click += OnNavigationButtonClick;
            //buttonPhotos.Click += OnNavigationButtonClick;
            //buttonFriends.Click += OnNavigationButtonClick;
            //buttonFriendFeed.Click += OnNavigationButtonClick;
            //buttonSettings.Click += OnNavigationButtonClick;
        }

        protected virtual void OnNavigationButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button && m_NavigationMap.TryGetValue(button.Text, out NavigationItem item))
            {
                item.Selected();
            }
            else
            {
                MessageBox.Show($"No action found for '{(sender as Button)?.Text}'");
            }
        }

        private void loadNavigationMap()
        {
            List<NavigationItem> items = initializeNavigationItems();
            m_NavigationMap = items.ToDictionary(item => item.Text);

            foreach (var item in items)
            {
                Button button = new Button
                {
                    Text = item.Text,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5)
                };

                button.Click += (sender, e) => item.Selected();

                flowLayoutPanelNavigation.Controls.Add(button); 
            }
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

        [NavigationAction("Albums")]
        private void ShowPhotosPanel()
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.Photos));
        }

        [NavigationAction("Friends")]
        private void ShowFriendsPanel()
        {
            PanelButtonClicked?.Invoke(this, new PanelEventArgs(ePanelType.Friends));
        }

        [NavigationAction("Feed")]
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