using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace LinkedInProject
{
    public class LinkedIn
    {

        #region Properties
        private readonly IList<Profile> _profiles;
        private readonly IList<Post> _posts;
        private readonly Dictionary<Profile, List<Website>> _websites;

        #endregion

        #region CTor
        public LinkedIn(IList<Profile> profiles, IList<Post> posts, Dictionary<Profile, List<Website>> websites)
        {
            _profiles = profiles;
            _posts = posts;
            _websites = websites;
        }
        #endregion

        #region Methods
        public void AddComment(Post post, string comment)
        {
            _posts.First(poste => poste.Equals(post)).AddComment(comment);
        }

        public void AddLike(Post post,Like like)
        {
            _posts.First(poste => poste.Equals(post)).AddLike(like);
        }

        public static void AddConnection(Profile profile1, Profile profile2)
        {
            if(!profile1.GetConnections().Contains(new Connection(profile1.GetUser(),profile2.GetUser())))
            {
                profile1.AddConnection(profile2);
                profile2.AddConnection(profile1);
            }
            
        }

        public void RemoveConnection(Profile profile1,Profile profile2)
        {
            if(profile1.GetConnections().Contains(new Connection(profile1.GetUser(),profile2.GetUser())))
            {
                profile1.RemoveConnection(profile2);
                profile2.RemoveConnection(profile1);
            }
            
        }

        public void AddPrimiumToProfile(Profile profile)
        {
            if (!profile.GetIsPrimium())
                profile.AddPrimiumToProfile();
        }
        
        public void RemovePrimiumToProfile(Profile profile)
        {
            if (profile.GetIsPrimium())
                profile.RemvePrimiumFromProfile();            
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

        public Dictionary<Profile, List<Website>> GetWebsites()
        {
            return this._websites;
        }
        #endregion
        
        #region OverrideMethods

        public override bool Equals(object obj)
        {
            LinkedIn newObj = (LinkedIn)obj;
            return newObj != null 
                   && newObj.GetPosts().Equals(this.GetPosts()) 
                   && newObj.GetProfiles().Equals(this.GetProfiles())
                   && newObj.GetWebsites().Equals(this.GetWebsites());
        }

        public override string ToString()
        {
            return $"This user name is the LinkedIn Network";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_posts,_profiles,_websites);
        }

        #endregion
    }
}