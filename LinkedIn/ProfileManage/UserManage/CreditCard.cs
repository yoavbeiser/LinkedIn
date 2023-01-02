using System;
namespace LinkedIn
{
	public class CreditCard
	{
        #region Prop
        private readonly int _number;
		private readonly DateTime _expireDate;
		private readonly int _cvv;
        #endregion

        #region Ctor
        public CreditCard(int number, DateTime expireDate, int cvv)
        {
            _number = number;
            _expireDate = expireDate;
            _cvv = cvv;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"last digits: {_cvv}\n";
        }

        public override bool Equals(object? obj)
        {
            CreditCard other = (CreditCard)obj;
            return other!=null &&
                   _number == other._number &&
                   _expireDate.Equals(other._expireDate) &&
                   _cvv == other._cvv;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_number, _expireDate, _cvv);
        }
        #endregion
    }
}

