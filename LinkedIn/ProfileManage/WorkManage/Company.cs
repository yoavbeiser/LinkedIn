using System;
using LinkedIn.ProfileManage;

namespace LinkedIn
{
    public class Company : Association
    {
        #region Ctor
        public Company(string name) : base(name)
        {
        }
        #endregion

        #region OverrideMethods
        public override string ToString()
        {
            return $"{base.ToString()} Company";
        }

        #endregion
    }
}

