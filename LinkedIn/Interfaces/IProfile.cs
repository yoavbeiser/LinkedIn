using LinkedIn.ProfileManage;

namespace LinkedIn
{
    public interface IProfile
    {
        void AddConnection(User user);
        void AddEducation(Education education);
        void AddWorkPlace(WorkPlace workPlace);
        void ChangePremiumSettings();
        string GetBio();
        bool GetIsPremium();
        IList<Education> GetListOfEducation();
        IList<WorkPlace> GetListOfWorkPlaces();
        User GetUser();
        void RemoveConnection(User user);
    }
}