using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{

    public interface IPost
    {
        Post.eType PostType { get; }
        string Message { get; }
        string Creator { get; }
        DateTime CreatedTime { get; }
        string PhotoURL { get; }
    }
}
