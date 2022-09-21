using System;

namespace LinkedInProject
{
    public class WorkPlace
    {
        #region Properties
        private readonly Company _company;
        private readonly DateTime _startDate;
        private readonly DateTime _endDate;
        #endregion
        
        #region Ctor
        public WorkPlace(Company company, DateTime startDate, DateTime endDate)
        {
            _company = company;
            _startDate = startDate;
            _endDate = endDate;
        }
        #endregion

        #region Gets

        public Company GetCompany()
        {
            return _company;
        }
        
        public DateTime GetStartDate()
        {
            return _startDate;
        }
        
        public DateTime GetEndDate()
        {
            return _endDate;
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            WorkPlace newObj = (WorkPlace)obj;
            return newObj != null
                   && newObj.GetCompany() == this.GetCompany();
        }

        #endregion
        
    }
}