using System;
namespace LinkedIn.ProfileManage
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
            Like other = (Like)obj;
            return other != null
                   && other._userLiked.Equals(_userLiked);
        }

        public override string ToString()
        {
            return $"this Liked by {_userLiked}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_userLiked);
        }
        #endregion
    }
}

