namespace LinkedIn
{
    public interface IUser
    {
        int GetAge();
        CreditCard GetCredit();
        string GetEmail();
        string GetId();
        Profession GetProfession();
        string GetUserName();
    }
}