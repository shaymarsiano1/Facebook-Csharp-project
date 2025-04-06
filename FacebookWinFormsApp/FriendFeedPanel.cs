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
        List<PostControl> m_AllPosts;

        public FriendFeedPanelControl()
        {
            InitializeComponent();
            m_AllPosts = new List<PostControl>();
        }

        public FriendFeedPanelControl(User i_LoggedInUser, UserActivity i_UserActivity)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_UserActivity = i_UserActivity;
            m_AllPosts = new List<PostControl>();
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
            m_AllPosts.Clear();
            foreach (User friend in m_LoggedInUser.Friends)
            {
                foreach (Post post in friend.Posts)
                {
                    if (post != null && post.CreatedTime.HasValue)
                    {
                        PostControl newPost = new PostControl();

                        newPost.Initialize(friend, post);
                        newPost.Dock = DockStyle.Top;
                        m_AllPosts.Add(newPost);
                    }
                }
            }

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post != null && post.CreatedTime.HasValue)
                {
                    PostControl newPost = new PostControl();

                    newPost.Initialize(m_LoggedInUser, post);
                    newPost.Dock = DockStyle.Top;
                    m_AllPosts.Add(newPost);
                }
            }

            flowLayoutPanelFeed.Invoke(new Action(() =>
            {
                flowLayoutPanelFeed.Controls.Clear();
                m_AllPosts = m_AllPosts.OrderByDescending(postControl => postControl.Date).ToList();

                foreach (PostControl postControl in m_AllPosts)
                {
                    flowLayoutPanelFeed.Controls.Add(postControl);
                }
            }));
        }
    }
}