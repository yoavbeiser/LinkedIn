using System;
using System.Collections.Generic;
using LinkedIn.ProfileManage;

namespace LinkedIn
{
    public class Profile : IProfile
    {
        #region Properties
        private readonly User _user;
        private readonly List<WorkPlace> _listOfWorkPlaces;
        private readonly List<Education> _listOfEducation;
        private readonly List<User> _connections;
        private readonly string _bio;
        private bool _isPremium;
        #endregion

        #region CTor
        public Profile(User user, string bio, bool isPremium = false)
        {
            _bio = bio;
            _user = user;
            _isPremium = isPremium;
            _listOfWorkPlaces = new List<WorkPlace>();
            _listOfEducation = new List<Education>();
            _connections = new List<User>();
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
        public IList<Education> GetListOfEducation()
        {
            return _listOfEducation;
        }
        public string GetBio()
        {
            return _bio;
        }
        public bool GetIsPremium()
        {
            return _isPremium;
        }
        #endregion

        #region Methods
        public void ChangePremiumSettings()
        {
            _isPremium = !_isPremium;
        }

        public void AddWorkPlace(WorkPlace workPlace)
        {
            _listOfWorkPlaces.Add(workPlace);
        }

        public void AddEducation(Education education)
        {
            _listOfEducation.Add(education);
        }

        public void AddConnection(User user)
        {
            _connections.Add(user);
        }

        public void RemoveConnection(User user)
        {
            if (_connections.Contains(user))
                _connections.Remove(user);
            else
                throw new ConnectionNotFound($"cannot find {user.GetUserName()} in {_user.GetUserName()} connections");
        }

        private string PrintProp<T>(List<T> list)
        {
            string outPut = "";
            if (list is List<Education>)
            {
                if (list.Count == 0)
                    return "No previous education places yet :(";
                outPut = "His/Her previous education places are: \n";
            }
            if (list is List<User>)
            {
                if (list.Count == 0)
                    return "No connections yet :(";
                outPut = "His/Her connections are: \n";
            }
            if (list is List<WorkPlace>)
            {
                if (list.Count == 0)
                    return "No previous work places yet :(";
                outPut = "His/Her previous work places are: \n";
            }
            foreach (T prop in list)
                outPut += $"\t{prop}\n";
            return outPut;
        }
        #endregion

        #region OverrideMethods
        public override string ToString()
        {
            string status = _isPremium ? "Premium user" : "regular user";
            return $"{_user}\tstatus:{status}" +
                $"\nbio:\n\t{_bio}\n" +
                $"{PrintProp<User>(_connections)}\n" +
                $"{PrintProp<WorkPlace>(_listOfWorkPlaces)}" +
                $"{PrintProp<Education>(_listOfEducation)}";
        }

        public override bool Equals(object obj)
        {
            Profile newObj = (Profile)obj;
            return newObj != null
                && newObj._listOfWorkPlaces.Equals(_listOfWorkPlaces)
                && newObj._bio == _bio;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_user, _listOfWorkPlaces, _bio);
        }


        #endregion
    }
}

