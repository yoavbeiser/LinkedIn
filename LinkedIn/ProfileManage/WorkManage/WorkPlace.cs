using System;
using LinkedIn.ProfileManage;

namespace LinkedIn
{
    public class WorkPlace
    {
        #region Properties
        private readonly Company _company;
        private readonly TimePeriod _timePeriod;
        #endregion

        #region Ctor
        public WorkPlace(Company company, DateTime startDate, DateTime endDate)
        {
            _company = company;
            _timePeriod = new TimePeriod(startDate, endDate);
        }
        #endregion

        #region Gets

        public Company GetCompany()
        {
            return _company;
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            WorkPlace other = (WorkPlace)obj;
            return other != null
                   && other._company == _company;
        }

        public override string ToString()
        {
            string dateFinished;
            DateTime endDate = _timePeriod.GetEndDate();
            if (endDate.Equals(DateTime.Now))
                dateFinished = "" + DateTime.Now.Year;
            else
                dateFinished = "" + endDate;
            return $"{_company} \n\t\tstarted: {_timePeriod.GetStartDate()} finished: {dateFinished}";
        }

        #endregion

    }
}

