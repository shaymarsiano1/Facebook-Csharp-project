using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    public class FacebookPostAdapter : IPost
    {
        private User m_LoggedInUser;

        public FacebookPostAdapter(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public List<Post> fetchPosts()
        {
            return m_LoggedInUser.Posts.ToList();
        }
    }
}
