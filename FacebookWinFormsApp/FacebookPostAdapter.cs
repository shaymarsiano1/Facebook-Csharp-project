using FacebookWrapper.ObjectModel;
using System;
using System.Xml.Serialization;


namespace BasicFacebookFeatures
{
    [Serializable]
    [XmlRoot("Post")]
    public class FacebookPostAdapter : IPost
    {
        private readonly Post r_FacebookPost;

        public FacebookPostAdapter(Post i_Post)
        {
            r_FacebookPost = i_Post;
        }

        [XmlAttribute("Type")]
        public Post.eType PostType => r_FacebookPost.Type ?? Post.eType.status;

        public string Creator => r_FacebookPost.From?.Name ?? "NONE";

        public string PhotoURL => r_FacebookPost.PictureURL;

        public string Message => r_FacebookPost.Message;

        DateTime IPost.CreatedTime => r_FacebookPost.CreatedTime ?? DateTime.MinValue;
    }

}
