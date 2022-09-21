namespace LinkedInProject
{
    public class Company
    {
        #region Properties
        private readonly string _name;
        #endregion

        #region Ctor
        public Company(string name)
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

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            Company newObj = (Company)obj;
            return newObj!=null
                && newObj.GetName()==this.GetName();
        }

        public override string ToString()
        {
            return $"this is {GetName()} Company";
        }

        #endregion
    }
}