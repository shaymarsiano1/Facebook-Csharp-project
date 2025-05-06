using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    [Serializable]
    [XmlRoot("Post")]
    public class SerializablePost : IPost
    {
        [XmlAttribute("Post Type")]
        public Post.eType PostType { get; set; }
        [XmlElement("Message")]
        public string Message { get; set; }
        [XmlElement("Application Source")]
        public string ApplicationSource { get; set; }
        [XmlElement("Post Creator")]
        public string Creator { get; set; }
        [XmlElement("Created Time")]
        public DateTime CreatedTime { get; set; }
        [XmlElement("Photo URL")]
        public string PictureURL { get; set; }

        public SerializablePost() { }

        public SerializablePost(IPost i_Post)
        {
            ApplicationSource = i_Post.GetType().ToString();
            PostType = i_Post.PostType;
            Message = i_Post.Message;
            CreatedTime = i_Post.CreatedTime;
            Creator = i_Post.Creator ?? "NONE";
            PictureURL = i_Post.PictureURL;
        }

        public static void ExportSerializablePosts(string i_FileLocation)
        {
            User LoggedInUser = FacebookUserSingleton.Instance.LoggedInUser;
            List<SerializablePost> serializablePosts = LoggedInUser.Posts
                       .Select(post => new SerializablePost(new FacebookPostAdapter(post)))
                       .ToList();

            foreach (User friend in LoggedInUser.Friends)
            {
                serializablePosts.AddRange(friend.Posts.Select(post => new SerializablePost(new FacebookPostAdapter(post))));
            }

            using (Stream stream = new FileStream(i_FileLocation, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<SerializablePost>));
                xmlSerializer.Serialize(stream, serializablePosts);
            }
        }

        public static List<SerializablePost> ImportSerializablePosts(string i_FileLocation)
        {
            if (!File.Exists(i_FileLocation))
            {
                throw new FileNotFoundException("The specified file was not found.", i_FileLocation);
            }

            using (Stream stream = new FileStream(i_FileLocation, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<SerializablePost>));
                return (List<SerializablePost>)xmlSerializer.Deserialize(stream);
            }
        }
    }
}
