using LinkedIn.ProfileManage;

namespace LinkedIn
{
    public interface ILinkedIn
    {
        void AddPost(Post post);
        void AddProfile(Profile profile);
        void AddWebsiteToProfileHistory(User user, Website web);
        IList<Post> GetPosts();
        IList<Profile> GetProfiles();
        Dictionary<User, List<Website>> GetWebsites();
        string PrintWebsitesForEachProfile();
    }
}