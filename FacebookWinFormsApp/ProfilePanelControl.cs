using System;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;

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
                MessageBox.Show("Posting is not available at that moment, sorry");
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
            flowLayoutPanelProfile.Controls.Clear();
            UserActivity.PostsVisitCount++;
            foreach (Post post in LoggedInUser.Posts)
            {
                if (post != null && string.IsNullOrEmpty(post.PictureURL) && post.Message != null)
                {
                    PersonalPostControl postControl = new PersonalPostControl();
                    postControl.SetPost(post);
                    flowLayoutPanelProfile.Controls.Add(postControl);
                }
            }
        }

        private void profilePicturesBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelProfile.Controls.Clear();
            UserActivity.PhotoViewCount++;
            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.PictureURL != null)   
                {
                    PostControl picturePost = new PostControl();
                    picturePost.Initialize(LoggedInUser,post);
                    picturePost.AutoSize = true;
                    flowLayoutPanelProfile.Controls.Add(picturePost);
                }
            }
        }
    }
}