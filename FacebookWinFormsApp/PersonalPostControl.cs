using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class PersonalPostControl : UserControl
    {
        public PersonalPostControl()
        {
            InitializeComponent();
        }

        public void SetPost(Post i_Post)
        {
            personalPostText.Text = i_Post.Message ?? "[Empty Post]";
            personalPostDate.Text = i_Post.CreatedTime?.ToString("dd/MM/yyyy HH:mm") ?? "Unknown Date";
        }
    }
}