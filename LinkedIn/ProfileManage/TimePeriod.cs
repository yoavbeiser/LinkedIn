using System;
namespace LinkedIn.ProfileManage
{
    public class TimePeriod : ITimePeriod
    {
        #region Prop
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;
        #endregion

        #region Ctor
        public TimePeriod(DateTime startDate, DateTime endDate)
        {
            _startDate = startDate;
            _endDate = endDate;
        }
        #endregion

        #region Get
        public DateTime GetStartDate()
        {
            return _startDate;
        }

        public DateTime GetEndDate()
        {
            return _endDate;
        }
        #endregion
    }
}

