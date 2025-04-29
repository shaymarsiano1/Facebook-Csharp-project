using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.IO;

namespace FacebookWinFormsApp
{
    public partial class ProfilePanelControl : BasePanelControl
    {
        private readonly BindingList<SimplePost> m_PostsList = new BindingList<SimplePost>();

        public ProfilePanelControl(User i_LoggedInUser, UserActivity i_UserActivity)
        {
            InitializeComponent();
            panel1.Visible = false;
            postBindingSource.DataSource = m_PostsList;

            LoggedInUser = i_LoggedInUser;
            UserActivity = i_UserActivity;
            LoadUserProfile(i_LoggedInUser);
        }

        public void LoadUserProfile(User i_LoggedInUser)
        {
            profilePicturesBtn.Click += profilePicturesBtn_Click;
            profilePostBtn.Click += profilePostsBtn_Click;
            profileActivityBtn.Click += profileActivityBtn_Click;
            postSomethingButton.Click += postSomethingButton_Click;
            happyPostBtn.Click += quickPostBtn_Click;
            talkPostBtn.Click += quickPostBtn_Click;
            sadPostBtn.Click += quickPostBtn_Click;
        }

        private void postSomethingButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoggedInUser.PostStatus(PostSomethingTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Posting is not available at this moment...");
            }

        }

        private void profileActivityBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            flowLayoutPanelProfile.Controls.Clear();
            UserActivityPanelControl activityPanel = new UserActivityPanelControl();
            activityPanel.SetContext(LoggedInUser, UserActivity, UserPreferences);
            activityPanel.LoadUserActivity(UserActivity);
            flowLayoutPanelProfile.Controls.Add(activityPanel);
        }

        private void profilePostsBtn_Click(object sender, EventArgs e)
        {
            UserActivity.PostsVisitCount++;
            IPost postFetcher = new FacebookPostAdapter(LoggedInUser);
            List<Post> posts = postFetcher.fetchPosts();            

            foreach (var post in LoggedInUser.Posts.Where(p => p != null && !string.IsNullOrEmpty(p.Message)))
            {
                m_PostsList.Add(new SimplePost{Message = post.Message,PictureURL = post.PictureURL,CreatedTime = post.CreatedTime ?? DateTime.Now});
            }
            panel1.Visible = true;
            flowLayoutPanelProfile.Visible = false;
        }

        private void profilePicturesBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelProfile.Controls.Clear();
            UserActivity.PhotoViewCount++;

            Thread thread = new Thread(() =>
            {
                List<PostControl> pictureControls = new List<PostControl>();

                foreach (Post post in LoggedInUser.Posts)
                {
                    if (post.PictureURL != null)
                    {
                        PostControl picturePost = new PostControl();
                        picturePost.Initialize(LoggedInUser, post);
                        picturePost.AutoSize = true;
                        pictureControls.Add(picturePost);
                    }
                }

                flowLayoutPanelProfile.Invoke(new Action(() =>
                {
                    flowLayoutPanelProfile.Controls.Clear();
                    foreach (var control in pictureControls)
                    {
                        flowLayoutPanelProfile.Controls.Add(control);
                    }
                }));
            });
            panel1.Visible = false;   
            flowLayoutPanelProfile.Visible = true;

            thread.Start();
        }

        private void quickPostBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                string message = btn.Text.Trim();
                string resourcesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
                string pic = Path.Combine(resourcesFolder, message + ".png");

                m_PostsList.Add(new SimplePost { Message = message, PictureURL = pic, CreatedTime = DateTime.Now });
            }
        }
    }
}