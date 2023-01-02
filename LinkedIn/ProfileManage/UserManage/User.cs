using System;
namespace LinkedIn
{
    public class User : IUser
    {
        #region Properties
        private readonly string _userName;
        private readonly string _id;
        private readonly string _email;
        private readonly int _age;
        private readonly Profession _profession;
        private readonly CreditCard _creditCard;
        #endregion

        #region Ctor
        public User(string userName, string id, string email, int age, Profession profession, CreditCard credit)
        {
            _userName = userName;
            _id = id;
            _email = email;
            _age = age;
            _profession = profession;
            _creditCard = credit;
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

        public CreditCard GetCredit()
        {
            return _creditCard;
        }
        #endregion

        #region OverrideMethods
        public override bool Equals(object obj)
        {
            User newObj = (User)obj;
            return newObj != null
                   && _age == newObj._age
                   && _creditCard.Equals(newObj._creditCard)
                   && _email == newObj._email
                   && _id == newObj._id
                   && _profession == newObj._profession;
        }

        public override string ToString()
        {
            return $"Name: {_userName}\n" +
                   $"\tId: {_id}\n" +
                   $"\tEmail: {_email}\n" +
                   $"\tProfession: {_profession}\n" +
                   $"\tCredit: {_creditCard}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_userName, _id, _email, _age, _profession, _creditCard);
        }
        #endregion
    }
}

