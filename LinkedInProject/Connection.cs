using System;

namespace LinkedInProject
{
    public class Connection
    {
        #region Properties
        private readonly User _user1;
        private readonly User _user2;
        #endregion
        
        #region CTor
        public Connection(User user1, User user2)
        {
            _user1 = user1;
            _user2 = user2;
        }
        #endregion

        #region Gets
        public User GetUser1()
        {
            return _user1;
        }
        public User GetUser2()
        {
            return _user2;
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            Connection newObj = (Connection)obj;
            return newObj != null
                   && newObj.GetUser1().Equals(this.GetUser1())
                   && newObj.GetUser2().Equals(this.GetUser2());
        }

        public override string ToString()
        {
            return $"this Connection has {GetUser1()} and {GetUser2()}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_user1,_user2);
        }
        #endregion
    }
}