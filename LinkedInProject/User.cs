using System;

namespace LinkedInProject
{
    public class User
    {
        #region Properties
            private readonly string _userName;
            private readonly string _id;
            private readonly string _email;
            private readonly int _age;
            private readonly Profession _profession;
            private readonly int _credit;
        #endregion

        #region Ctor
            public User(string userName, string id, string email, int age, Profession profession, int credit)
            {
                _userName = userName;
                _id = id;
                _email = email;
                _age = age;
                _profession = profession;
                _credit = credit;
            }
        #endregion

        #region AllGet
        public string GetUserName()
        {
            return _userName;
        }

        public string GetId()
        {
            return _id;
        }

        public string GetEmail()
        {
            return _email;
        }

        public int GetAge()
        {
            return _age;
        }

        public Profession GetProfession()
        {
            return _profession;
        }

        public int GetCredit()
        {
            return _credit;
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            User newObj = (User)obj;
            return newObj != null 
                   && this.GetAge() == newObj.GetAge() 
                   && this.GetCredit() == newObj.GetCredit() 
                   && this.GetEmail() == newObj.GetEmail() 
                   && this.GetId() == newObj.GetId() 
                   && this.GetProfession() == newObj.GetProfession();
        }

        public override string ToString()
        {
            return $"this user name is {GetAge()}," +
                   $"his id is {GetId()}," +
                   $"his email {GetEmail()}," +
                   $"his profession is {GetProfession()}," +
                   $"his credit is {GetCredit()}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_userName, _age, _credit, _email, _id, _profession);
        }

        #endregion
    }
}