using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookUserSingleton
    {
        private static FacebookUserSingleton s_Instance;
        private static readonly object sr_Lock = new object();

        public User LoggedInUser { get; private set; }

        private FacebookUserSingleton()
        {
        }

        public static FacebookUserSingleton Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_Lock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookUserSingleton();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void ResetLoggedInUser()
        {
            LoggedInUser = null;
        }

        public void SetLoggedInUser(User i_User)
        {
            if (LoggedInUser != null)
            {
                throw new InvalidOperationException($"A logged in user is already setted. {LoggedInUser.Name}");
            }
            if (i_User == null)
            {
                throw new ArgumentNullException(nameof(i_User), "Logged-in user cannot be null.");
            }

            LoggedInUser = i_User;
        }
    }
}
