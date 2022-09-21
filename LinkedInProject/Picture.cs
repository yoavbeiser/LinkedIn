using System;

namespace LinkedInProject
{
    public class Picture
    {
        #region Properties
        private readonly string _pictureLink;
        #endregion
        
        #region Ctor
        public Picture(string pictureLink)
        {
            _pictureLink = pictureLink;
        }
        #endregion
        
        #region Gets
        public string GetPictureLink()
        {
            return _pictureLink;
        }
        #endregion
        
        #region OverrideMethod

        public override bool Equals(object obj)
        {
            Picture newObj = (Picture)obj;
            return newObj!=null
                   &&this.GetPictureLink()==newObj.GetPictureLink();
        }

        public override string ToString()
        {
            return $"This Picture's link is {this.GetPictureLink()}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_pictureLink);
        }

        #endregion
        
    }
}