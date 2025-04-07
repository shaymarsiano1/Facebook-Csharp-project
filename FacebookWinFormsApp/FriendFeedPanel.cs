using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FriendFeedPanelControl : BasePanelControl
    {
        private List<PostControl> AllPosts { get; set; }

        public FriendFeedPanelControl()
        {
            InitializeComponent();
            AllPosts = new List<PostControl>();
        }

        public FriendFeedPanelControl(User i_LoggedInUser, UserActivity i_UserActivity)
        {
            InitializeComponent();
            LoggedInUser = i_LoggedInUser;
            UserActivity = i_UserActivity;
            AllPosts = new List<PostControl>();
            if (DesignMode == false) 
            {
                InitializeData();
            }
        }
        
        public override void InitializeData()
        {
            base.InitializeData();
            flowLayoutPanelFeed.Controls.Clear();
            flowLayoutPanelFeed.Controls.Add(new Label()
            {
                Text = "Loading feed...",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                AutoSize = true
            });
            Thread thread = new Thread(() => loadData());
            thread.Start();
        }

        private void loadData()
        {
            AllPosts.Clear();
            foreach (User friend in LoggedInUser.Friends)
            {
                foreach (Post post in friend.Posts)
                {
                    if (post != null && post.CreatedTime.HasValue)
                    {
                        PostControl newPost = new PostControl();

                        newPost.Initialize(friend, post);
                        newPost.Dock = DockStyle.Top;
                        AllPosts.Add(newPost);
                    }
                }
            }

            foreach (Post post in LoggedInUser.Posts)
            {
                if (post != null && post.CreatedTime.HasValue)
                {
                    PostControl newPost = new PostControl();

                    newPost.Initialize(LoggedInUser, post);
                    newPost.Dock = DockStyle.Top;
                    AllPosts.Add(newPost);
                }
            }

            flowLayoutPanelFeed.Invoke(new Action(() =>
            {
                flowLayoutPanelFeed.Controls.Clear();
                AllPosts = AllPosts.OrderByDescending(postControl => postControl.Date).ToList();

                foreach (PostControl postControl in AllPosts)
                {
                    flowLayoutPanelFeed.Controls.Add(postControl);
                }
            }));
        }
    }
}