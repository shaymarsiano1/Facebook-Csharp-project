using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FriendFeedPanelControl : BasePanelControl
    {
        AllPosts allPosts;
        private int m_PostsCount = 0;
        private Button m_LoadMorePostsBtn;
        public FriendFeedPanelControl()
        {
            InitializeComponent();
            LoggedInUser = FacebookUserSingleton.Instance.LoggedInUser;
            {
                InitializeData();
            }
        }

        public override void InitializeData()
        {
            base.InitializeData();
            flowLayoutPanelFeed.Controls.Clear();
            addLabelByText("Loading feed...");
            m_LoadMorePostsBtn = new Button() { Text = "Load More", AutoSize = true, Margin = new Padding(10), };
            m_LoadMorePostsBtn.Click += (sender, e) => loadData();
            Thread thread = new Thread(() => initializePosts());
            thread.Start();
        }

        private void initializePosts()
        {
            resetData();
            loadData();
        }

        private void resetData()
        {
            allPosts = new AllPosts();
            m_PostsCount = 0;
            flowLayoutPanelFeed.Invoke(new Action(() =>
            {
                flowLayoutPanelFeed.Controls.Clear();
            }));
        }

        private void loadData()
        {
            List<PostControl> AllPostsControls = new List<PostControl>();
            int counter = 0;
            foreach (var postTuple in allPosts.GetAllPosts())
            {
                if (counter >= 5)
                {
                    break;
                }
                if (postTuple != null && postTuple.Item1.Current.CreatedTime.HasValue) 
                {
                    PostControl newPost = new PostControl();
                    newPost.Initialize(postTuple.Item2, postTuple.Item1.Current);
                    newPost.Dock = DockStyle.Top;
                    AllPostsControls.Add(newPost);
                    counter++;
                    m_PostsCount++;
                }
            }
            flowLayoutPanelFeed.Invoke(new Action(() =>
                {
                    flowLayoutPanelFeed.Controls.Remove(m_LoadMorePostsBtn);
                    if (m_PostsCount == 0)
                    {
                        addLabelByText("No posts to load with these filters!");
                    }
                    foreach (PostControl postControl in AllPostsControls)
                    {
                        flowLayoutPanelFeed.Controls.Add(postControl);
                    }

                    if(counter >= 5)
                    {
                        flowLayoutPanelFeed.Controls.Add(m_LoadMorePostsBtn);
                    }
                }));
        }

        private void addLabelByText(string i_Text)
        {
            flowLayoutPanelFeed.Controls.Add(new Label() 
            { 
                Text = i_Text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                AutoSize = true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetData();
            if (IsPic.Checked)
            {
                allPosts.AllFilters.Add((Tuple<IEnumerator<Post>, User> tuple) => Post.eType.photo == tuple.Item1.Current.Type);
            }

            if (IsStatus.Checked)
            {
                allPosts.AllFilters.Add((Tuple<IEnumerator<Post>, User> tuple) => Post.eType.status == tuple.Item1.Current.Type);
            }

            if (CreatedByMe.Checked)
            {
                allPosts.AllFilters.Add((Tuple<IEnumerator<Post>, User> tuple) => LoggedInUser.Name == tuple.Item2.Name);
            }
            loadData();
        }
    }
}