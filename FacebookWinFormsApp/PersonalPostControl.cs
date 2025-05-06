using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class PersonalPostControl : UserControl
    {
        public event EventHandler<Post> PostClicked;
        private Post m_Post;

        public PersonalPostControl()
        {
            InitializeComponent();
            attachClickHandlers(this);

        }

        public void SetPost(Post i_Post)
        {
            m_Post = i_Post;
            personalPostText.Text = i_Post.Message ?? "[Empty Post]";
            personalPostDate.Text = i_Post.CreatedTime?.ToString("dd/MM/yyyy HH:mm") ?? "Unknown Date";
        }
       
        private void attachClickHandlers(Control i_Root)
        {
            i_Root.Click += onAnyControlClicked;

            foreach (Control child in i_Root.Controls)
            {
                attachClickHandlers(child);   
            }
        }

        private void onAnyControlClicked(object sender, EventArgs e)
        {
            PostClicked?.Invoke(this, m_Post);
        }
    }
}