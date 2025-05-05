using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using BasicFacebookFeatures.Properties;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.InteropServices.ComTypes;

namespace FacebookWinFormsApp
{
    public partial class ProfilePanelControl : BasePanelControl
    {
        private readonly BindingList<IPost> m_PostsList = new BindingList<IPost>();

        public ProfilePanelControl()
        {
            InitializeComponent();
            panel1.Visible = false;
            allPostsBindingSource.DataSource = m_PostsList;
            UserActivity = UserActivity.Instance;
            LoggedInUser = FacebookUserSingleton.Instance.LoggedInUser;
            LoadUserProfile(LoggedInUser);
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
            activityPanel.LoadUserActivity();
            flowLayoutPanelProfile.Controls.Add(activityPanel);
        }

        private void profilePostsBtn_Click(object sender, EventArgs e)
        {
            refreshPosts();
        }

        private void refreshPosts()
        {
            m_PostsList.Clear();
            foreach (IPost post in FacebookUserSingleton.Instance.AllPosts.Where(p => p != null && !string.IsNullOrEmpty(p.Message)))
            {
                m_PostsList.Add(post);
            }
            panel1.Visible = true;
            flowLayoutPanelProfile.Visible = false;
        }

        private void profilePicturesBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanelProfile.Controls.Clear();
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
                FacebookUserSingleton.Instance.AllPosts.Add(new SerializablePost { Message = message, PictureURL = pic, CreatedTime = DateTime.Now,Creator = LoggedInUser.Name,PostType = Post.eType.status });
                refreshPosts();
            }
        }
       

        private void exportPostsBtn_Click(object sender, EventArgs e)
        {
            if (LoggedInUser.Posts == null || LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No posts to save.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                Title = "Save Posts",
                FileName = "MyPosts.xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    SerializablePost.ExportSerializablePosts(saveFileDialog.FileName);
                    MessageBox.Show("User activity saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving user activity: {ex.Message}");
                }
            }
        }

        private void importPostsBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                Title = "Open Posts"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<SerializablePost> importedPosts = SerializablePost.ImportSerializablePosts(openFileDialog.FileName);
                    FacebookUserSingleton.Instance.AllPosts.AddRange(importedPosts);
                    MessageBox.Show("User activity loaded successfully.");
                    refreshPosts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading user activity: {ex.Message}");
                }
            }
        }

    }
}