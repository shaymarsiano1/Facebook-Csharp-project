using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IPost
    {
        List<Post> fetchPosts();
    }
}
