using System;

namespace LinkedInProject
{
    public class Comments
    {
        #region Properties
        private readonly User _userCommented;
        private readonly string _text;
        #endregion

        #region Ctor

        public Comments(User userCommented, string text)
        {
            _userCommented = userCommented;
            _text = text;
        }

        #endregion

        #region Gets

        public User GetUserCommented()
        {
            return _userCommented;
        }

        public string GetText()
        {
            return _text;
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            Comments newObj = (Comments)obj;
            return newObj!=null
                && newObj.GetText()==this.GetText()
                && newObj.GetUserCommented()==this.GetUserCommented();
        }

        public override string ToString()
        {
            return $"This comment has text: {GetText()}" +
                   $"And User That Commented: {GetUserCommented()}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_text,_userCommented);
        }

        #endregion
    }
}