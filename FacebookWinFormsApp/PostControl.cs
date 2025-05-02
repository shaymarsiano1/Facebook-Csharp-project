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
        private bool IsImageEnlarged { get; set; } = false;
        private Rectangle OriginalBounds { get; set; }

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

        private void postPicture_Click(object sender, EventArgs e)
        {
            if (IsImageEnlarged == false)
            {
                OriginalBounds = postPicture.Bounds;
                postPicture.Size = new Size(200, 200);
                postPicture.Location = new Point((this.Width - postPicture.Width) / 2, (this.Height - postPicture.Height) / 2);
                IsImageEnlarged = true;
            }
            else
            {
                postPicture.Bounds = OriginalBounds;
                IsImageEnlarged = false;
            }
        }
    }
}