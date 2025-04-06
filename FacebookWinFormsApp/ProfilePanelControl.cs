using System;
using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class ProfilePanelControl : BasePanelControl 
    {
        public ProfilePanelControl(User i_LoggedInUser, UserActivity i_UserActivity)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_UserActivity = i_UserActivity;
            LoadUserProfile(i_LoggedInUser);
        }

        public void LoadUserProfile(User i_LoggedInUser)
        {
            profilePicturesBtn.Click += ProfilePicturesBtn_Click;
            profilePostBtn.Click += profilePostsBtn_Click;
            profileActivityBtn.Click += profileActivityBtn_Click;
        }

        private void profileActivityBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelProfile.Controls.Clear();
            UserActivityPanelControl activityPanel = new UserActivityPanelControl();
            activityPanel.SetContext(m_LoggedInUser, m_UserActivity, m_UserPreferences);
            activityPanel.LoadUserActivity(m_UserActivity);
            flowLayoutPanelProfile.Controls.Add(activityPanel);
        }

        private void profilePostsBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelProfile.Controls.Clear();
            m_UserActivity.PostsVisitCount++;
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post != null && string.IsNullOrEmpty(post.PictureURL) && post.Message != null)
                {
                    PersonalPostControl postControl = new PersonalPostControl();
                    postControl.SetPost(post);
                    flowLayoutPanelProfile.Controls.Add(postControl);
                }
            }
        }

        protected virtual void ProfilePicturesBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelProfile.Controls.Clear();
            m_UserActivity.PhotoViewCount++;
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.PictureURL != null)   
                {
                    PostControl picturePost = new PostControl();
                    picturePost.Initialize(m_LoggedInUser,post);
                    picturePost.AutoSize = true;
                    flowLayoutPanelProfile.Controls.Add(picturePost);
                }
            }
        }
    }
}