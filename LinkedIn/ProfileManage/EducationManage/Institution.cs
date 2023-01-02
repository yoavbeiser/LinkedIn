using System;
namespace LinkedIn.ProfileManage.EducationManage
{
	public class Institution : Association
    {
        public Institution(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()} Institution";
        }
    }
}

