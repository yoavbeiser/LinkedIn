using System;
using LinkedIn.ProfileManage.EducationManage;

namespace LinkedIn.ProfileManage
{
    public class Education
    {
        #region Prop
        private readonly Institution _institution;
        private readonly TimePeriod _timePeriod;
        #endregion

        #region Ctor
        public Education(Institution institution, DateTime startDate, DateTime endDate)
        {
            _institution = institution;
            _timePeriod = new TimePeriod(startDate,endDate);
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            Education other = (Education)obj;
            return other != null
                   && other._institution == _institution;
        }

        public override string ToString()
        {
            string dateFinished;
            DateTime endDate = _timePeriod.GetEndDate();
            if (endDate.Equals(DateTime.Now))
                dateFinished = "" + DateTime.Now.Year;
            else
                dateFinished = "" + endDate;
            return $"{_institution} \n\t\tstarted: {_timePeriod.GetStartDate()} finished: {dateFinished}";
        }

        #endregion
    }
}

