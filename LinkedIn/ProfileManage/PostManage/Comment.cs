using System;
namespace LinkedIn.ProfileManage.PostManage
{
    public class Comment
    {
        #region Properties
        private readonly User _userCommented;
        private readonly string _text;
        #endregion

        #region Ctor

        public Comment(User userCommented, string text)
        {
            _userCommented = userCommented;
            _text = text;
        }

        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            Comment newObj = (Comment)obj;
            return newObj != null
                && newObj._text == _text
                && newObj._userCommented.Equals(_userCommented);
        }

        public override string ToString()
        {
            return $"text: {_text}" +
                   $" by: {_userCommented.GetUserName()}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_text, _userCommented);
        }

        #endregion
    }
}

