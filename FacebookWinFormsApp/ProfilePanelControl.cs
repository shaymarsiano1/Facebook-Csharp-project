using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace FacebookWinFormsApp
{
    public partial class ProfilePanelControl : BasePanelControl 
    {
        public ProfilePanelControl(User i_LoggedInUser, UserActivity i_UserActivity)
        {
            InitializeComponent();
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
            flowLayoutPanelProfile.Controls.Clear();
            UserActivityPanelControl activityPanel = new UserActivityPanelControl();
            activityPanel.SetContext(LoggedInUser, UserActivity, UserPreferences);
            activityPanel.LoadUserActivity(UserActivity);
            flowLayoutPanelProfile.Controls.Add(activityPanel);
        }

        private void profilePostsBtn_Click(object sender, EventArgs e)
        {
            //flowLayoutPanelProfile.Controls.Clear();
            UserActivity.PostsVisitCount++;
            postBindingSource.DataSource = LoggedInUser.Posts;
            //Thread thread = new Thread(() =>
            //{
                //foreach (Post post in LoggedInUser.Posts)
                //{
                //    if (post != null && string.IsNullOrEmpty(post.PictureURL) && post.Message != null)
                //    {
                //        PersonalPostControl postControl = new PersonalPostControl();
                //        postControl.SetPost(post);
                //        postControls.Add(postControl);
                //    }
                //}

                //flowLayoutPanelProfile.Invoke(new Action(() =>
                //{
                //    flowLayoutPanelProfile.Controls.Clear();
                //    foreach (var control in postControls)
                //    {
                //        flowLayoutPanelProfile.Controls.Add(control);
                //    }
            //    //}));
            //});

            //thread.Start();

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

            thread.Start();
        }

        private void postSomethingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}