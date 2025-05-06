using FacebookWrapper.ObjectModel;
using System;


namespace BasicFacebookFeatures
{
    public class FacebookPostAdapter : IPost
    {
        private readonly Post r_FacebookPost;

        public FacebookPostAdapter(Post i_Post)
        {
            r_FacebookPost = i_Post;
        }

        public Post.eType PostType => r_FacebookPost.Type ?? Post.eType.status;

        public string Creator => r_FacebookPost.From.Name;

        public string PictureURL => r_FacebookPost.PictureURL;

        public string Message => r_FacebookPost.Message;

        public DateTime CreatedTime => r_FacebookPost.CreatedTime.Value;

        public string ApplicationSource => typeof(Post).ToString();
    }
}
