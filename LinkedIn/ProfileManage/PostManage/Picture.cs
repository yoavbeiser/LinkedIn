using System;
namespace LinkedIn.ProfileManage
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

        #region OverrideMethod

        public override bool Equals(object obj)
        {
            Picture newObj = (Picture)obj;
            return newObj != null
                   && _pictureLink == newObj._pictureLink;
        }

        public override string ToString()
        {
            return $"This Picture's link is '{_pictureLink}'";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_pictureLink);
        }

        #endregion
    }
}

