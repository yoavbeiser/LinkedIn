using System;
using LinkedIn.ProfileManage;
using LinkedIn.ProfileManage.PostManage;

namespace LinkedIn
{
    public class LinkedIn : ILinkedIn
    {
        #region Properties
        private readonly List<Profile> _profiles;
        private readonly List<Post> _posts;
        private readonly Dictionary<User, List<Website>> _websitesForProfiles;
        #endregion

        #region Ctor
        public LinkedIn()
        {
            _profiles = new List<Profile>();
            _posts = new List<Post>();
            _websitesForProfiles = new Dictionary<User, List<Website>>();
        }
        #endregion

        #region Methods

        public void AddProfile(Profile profile)
        {
            _profiles.Add(profile);
        }

        public void AddPost(Post post)
        {
            _posts.Add(post);
        }

        public void AddWebsiteToProfileHistory(User user, Website web)
        {
            _websitesForProfiles[user].Add(web);
        }

        public string PrintWebsitesForEachProfile()
        {
            if (_websitesForProfiles.Count == 0)
                return "No websites yet";
            string outPut = "Websites for each Profile:\n";
            foreach (KeyValuePair<User, List<Website>> userAndWebsites in _websitesForProfiles)
                outPut += $"For {userAndWebsites.Key.GetUserName()}:\n\t {PrintProp<Website>(userAndWebsites.Value)}";
            return outPut;
        }
        private string PrintProp<T>(List<T> list)
        {
            string outPut = "";
            if (list is List<Profile>)
            {
                if (list.Count == 0)
                    return "No Posts yet :(";
                outPut = "Profiles are: \n";
            }
            if (list is List<Post>)
            {
                if (list.Count == 0)
                    return "No Posts yet :(";
                outPut = "Posts are: \n";
            }
            if (list is List<Website>)
            {
                if (list.Count == 0)
                    return "No websites yet :(";
                outPut = "His/Her previous visited websites are: \n";
            }
            foreach (T prop in list)
            {
                if (prop is Profile)
                    outPut += "\nUser:\n";
                else if (prop is Post)
                    outPut += "Post:";
                else if (prop is Website)
                    outPut += "Website:";
                outPut += $"\t{prop}\n";
            }
            return outPut;
        }

        #endregion

        #region Gets

        public IList<Post> GetPosts()
        {
            return _posts;
        }
        public IList<Profile> GetProfiles()
        {
            return _profiles;
        }

        public Dictionary<User, List<Website>> GetWebsites()
        {
            return _websitesForProfiles;
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            LinkedIn newObj = (LinkedIn)obj;
            return newObj != null
                   && newObj._posts.Equals(_posts)
                   && newObj._profiles.Equals(_profiles)
                   && newObj._websitesForProfiles.Equals(_websitesForProfiles);
        }

        public override string ToString()
        {
            return $"LinkedIn Network" +
                $"\n{PrintProp<Profile>(_profiles)}" +
                $"\n{PrintProp<Post>(_posts)}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_posts, _profiles, _websitesForProfiles);
        }

        #endregion
    }
}

