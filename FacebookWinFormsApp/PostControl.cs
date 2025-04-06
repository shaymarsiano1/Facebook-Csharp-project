using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class PostControl : UserControl
    {
        private User Owner { get; set; }
        private Post Post { get; set; }
        public DateTime Date { get { return Post.CreatedTime.Value; } }

        private bool m_IsImageEnlarged = false;

        private Rectangle m_OriginalBounds;

        public PostControl()
        {
            InitializeComponent();
        }

        public void Initialize(User i_Owner, Post i_Post)
        {
            Owner = i_Owner;
            Post = i_Post;
            ownerName.Text = i_Owner.Name;
            postDate.Text = i_Post.CreatedTime.ToString();
            ownerProfilePicture.ImageLocation = i_Owner.PictureNormalURL;

            if (i_Post.PictureURL != null)
            {
                postPicture.ImageLocation = i_Post.PictureURL;
                postPicture.Cursor = Cursors.Hand;
                postPicture.Click += postPicture_Click;
            }

            if (i_Post.Message != null)
            {
                postMessage.Text = i_Post.Message;
            }
        }

        protected virtual void postPicture_Click(object sender, EventArgs e)
        {
            if (m_IsImageEnlarged == false)
            {
                m_OriginalBounds = postPicture.Bounds;
                postPicture.Size = new Size(200, 200);
                postPicture.Location = new Point((this.Width - postPicture.Width) / 2, (this.Height - postPicture.Height) / 2);
                m_IsImageEnlarged = true;
            }
            else
            {
                postPicture.Bounds = m_OriginalBounds;
                m_IsImageEnlarged = false;
            }
        }
    }
}