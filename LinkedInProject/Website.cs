using System;

namespace LinkedInProject
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

        #region Gets

        public string GetName()
        {
            return _name;
        }

        public string GetWebsiteLink()
        {
            return _websiteLink;
        }

        #endregion

        #region OverrideMethod

        public override bool Equals(object obj)
        {
            Website newObj = (Website)obj;
            return newObj != null
                   && this.GetWebsiteLink() == newObj.GetWebsiteLink()
                   && this.GetName() == newObj.GetName();
        }

        public override string ToString()
        {
            return $"This Website name is {GetName()} and link {GetWebsiteLink()}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_name,_websiteLink);
        }

        #endregion
        
    }
}