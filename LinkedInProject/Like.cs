using System;

namespace LinkedInProject
{
    public class Like
    {
        #region Properties
        private readonly User _userLiked;
        #endregion

        #region Ctor
        public Like(User userLiked)
        {
            _userLiked = userLiked;
        }
        #endregion

        #region Gets
        public User GetUserLiked()
        {
            return _userLiked;
        }
        #endregion

        #region OverrideMethods
        public override bool Equals(object obj)
        {
            Like newObj = (Like)obj;
            return newObj!=null
                   && newObj.GetUserLiked().Equals(this.GetUserLiked());
        }

        public override string ToString()
        {
            return $"this Liked by {GetUserLiked()}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_userLiked);
        }
        #endregion
    }
}