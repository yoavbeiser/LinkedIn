using System;
using System.Collections.Generic;

namespace LinkedInProject
{
    public class Profile
    {
        #region Properties
        private User _user { get; set; }
        private readonly IList<WorkPlace> _listOfWorkPlaces;
        private readonly IList<Connection> _connections;
        private readonly string _bio;
        private bool _isPrimium;
        #endregion

        #region CTor
        public Profile(IList<WorkPlace> listOfWorkPlaces, IList<Connection> connections, string bio, User user)
        {
            _listOfWorkPlaces = listOfWorkPlaces;
            _connections = connections;
            _bio = bio;
            _user = user;
            _isPrimium = false;
        }
        #endregion

        #region Gets
        public User GetUser()
        {
            return _user;
        }
        public IList<WorkPlace> GetListOfWorkPlaces()
        {
            return _listOfWorkPlaces;
        }
        
        public IList<Connection> GetConnections()
        {
            return _connections;
        }
        public string GetBio()
        {
            return _bio;
        }

        public bool GetIsPrimium()
        {
            return _isPrimium;
        }
        #endregion

        #region Methods

        public void AddConnection(Profile profile)
        {
            _connections.Add(new Connection(this._user,profile._user));
        }

        public void RemoveConnection(Profile profile)
        {
            _connections.Remove(new Connection(this._user,profile._user));
        }

        public void AddPrimiumToProfile()
        {
            _isPrimium = true;
        }
        public void RemvePrimiumFromProfile()
        {
            _isPrimium = false;
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            Profile newObj = (Profile)obj;
            return newObj!=null
                && newObj.GetListOfWorkPlaces().Equals(this.GetListOfWorkPlaces())
                && newObj.GetIsPrimium().Equals(this.GetIsPrimium())
                && newObj.GetBio().Equals(this.GetBio())
                && newObj.GetConnections().Equals(this.GetConnections());
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_user, _listOfWorkPlaces, _connections, _bio, _isPrimium);
        }


        #endregion
    }
}