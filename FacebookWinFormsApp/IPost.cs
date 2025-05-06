using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IPost
    {
        Post.eType PostType { get; }
        string Message { get; }
        string Creator { get; }
        DateTime CreatedTime { get;  }
        string PictureURL { get;  }
        string ApplicationSource { get; }
    }
}