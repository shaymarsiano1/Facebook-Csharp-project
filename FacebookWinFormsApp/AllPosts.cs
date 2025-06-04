using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AllPosts
    {
        private readonly List<Tuple<IEnumerator<Post>, User>> r_Posts = new List<Tuple<IEnumerator<Post>, User>>();
        public List<Func<Tuple<IEnumerator<Post>, User>, bool>> AllFilters { get; } = new List<Func<Tuple<IEnumerator<Post>, User>, bool>>();
        private IEnumerable<Tuple<IEnumerator<Post>, User>> PostsIEnumerator { get;  }
        public const int k_NotDefined = -1;
        private User m_LoggedInUser = FacebookUserSingleton.Instance.LoggedInUser;

        public AllPosts()
        {
            IEnumerator<Post> enumerator = m_LoggedInUser.Posts.GetEnumerator();

            addIEnumerator(enumerator,m_LoggedInUser);
            foreach (User friend in FacebookUserSingleton.Instance.LoggedInUser.Friends) 
            {
                enumerator = friend.Posts.GetEnumerator();
                addIEnumerator(enumerator,friend);
            }
        }

        private void addIEnumerator(IEnumerator<Post> i_Enumerator, User i_User)
        {
            if (i_Enumerator.MoveNext()) 
            {
                r_Posts.Add(new Tuple<IEnumerator<Post>, User>(i_Enumerator, i_User));
            }
        }

        public IEnumerable<Tuple<IEnumerator<Post>, User>> GetAllPosts()
        {
            bool isAllFilterPassed;
            bool isMostRecentPost;
            while (r_Posts.Any())
            {
                int indexMostRecentPostEnumerator = k_NotDefined;

                for (int i = 0; i < r_Posts.Count; i++)
                {
                    isAllFilterPassed = true;
                    foreach (var filter in AllFilters) 
                    {
                        if (filter(r_Posts[i]) == false) 
                        {
                            isAllFilterPassed = false;
                            break;
                        }
                    }

                    if (isAllFilterPassed == false) 
                    {
                        continue;
                    }

                    if (indexMostRecentPostEnumerator == k_NotDefined)
                    {
                        indexMostRecentPostEnumerator = i;
                    }
                    else if (r_Posts[i].Item1.Current.CreatedTime.Value
                            > r_Posts[indexMostRecentPostEnumerator].Item1.Current.CreatedTime.Value) 
                    {
                        indexMostRecentPostEnumerator = i;
                    }
                }

                if (indexMostRecentPostEnumerator == k_NotDefined)
                {
                    yield break;
                }

                yield return r_Posts[indexMostRecentPostEnumerator];

                if (r_Posts[indexMostRecentPostEnumerator].Item1.MoveNext() == false) 
                {
                    r_Posts.RemoveAt(indexMostRecentPostEnumerator);
                }
            }
        }
    }
}