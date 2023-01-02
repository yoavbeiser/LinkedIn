using System;
namespace LinkedIn.ProfileManage
{
	public abstract class Association
	{
        #region Properties
        private readonly string _name;
        #endregion

        #region Ctor
        public Association(string name)
		{
            _name = name;
		}
        #endregion

        #region Gets
        public string GetName()
        {
            return _name;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return _name;
        }

        public override bool Equals(object? obj)
        {
            Association other = (Association)obj;
            return other !=null
                && other._name == _name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(_name);
        }
        #endregion
    }
}

