using System;
namespace LinkedIn
{
    public class Website
    {
        #region Properties
        private readonly string _name;
        private readonly string _websiteLink;
        #endregion

        #region Ctor
        public Website(string name, string websiteLink)
        {
            _name = name;
            _websiteLink = websiteLink;
        }
        #endregion

        #region OverrideMethod
        public override bool Equals(object obj)
        {
            Website newObj = (Website)obj;
            return newObj != null
                   && _websiteLink == newObj._websiteLink
                   && _name == newObj._name;
        }

        public override string ToString()
        {
            return $"This Website name is {_name} and link {_websiteLink}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_name, _websiteLink);
        }
        #endregion
    }
}

