using LinkedIn.ProfileManage.PostManage;

namespace LinkedIn.ProfileManage
{
    public interface IPost
    {
        void AddComment(Comment comment);
        void AddLike(Like like);
        IList<Comment> GetComments();
        IList<Like> GetLikes();
        Picture GetPicture();
        string GetText();
        User GetUserPost();
    }
}