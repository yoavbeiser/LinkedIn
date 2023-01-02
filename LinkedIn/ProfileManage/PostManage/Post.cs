using System;
using System.Xml.Linq;
using LinkedIn.ProfileManage.PostManage;

namespace LinkedIn.ProfileManage
{
    public class Post : IPost
    {
        #region Prop
        private readonly User _userPost;
        private readonly string _text;
        private readonly Picture _picture;
        private readonly IList<Comment> _comments;
        private readonly IList<Like> _likes;
        #endregion

        #region Ctor
        public Post(string text, Picture picture, User userPost)
        {
            _text = text;
            _picture = picture;
            _userPost = userPost;
            _comments = new List<Comment>();
            _likes = new List<Like>();
        }
        #endregion

        #region Gets
        public IList<Like> GetLikes()
        {
            return _likes;
        }
        public IList<Comment> GetComments()
        {
            return _comments;
        }
        public string GetText()
        {
            return _text;
        }

        public Picture GetPicture()
        {
            return _picture;
        }

        public User GetUserPost()
        {
            return _userPost;
        }
        #endregion

        #region Methods
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public void AddLike(Like like)
        {
            _likes.Add(like);
        }

        private string PrintComments()
        {
            if (_comments.Count == 0)
                return "No comments yet, be the first to comment!";
            string str = "His/Her comments are: \n";
            foreach (Comment comment in _comments)
                str += $"\t\t{comment}\n";
            return str;
        }

        private string PrintLikes()
        {
            int count = _likes.Count;
            string str = count == 0 ? "" : "and liked by: \n";
            foreach (Like like in _likes)
                str += $"\t\t{like.GetUserLiked().GetUserName()}\n";
            return $"This post has {count} likes " + str;
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            Post newObj = (Post)obj;
            return newObj != null
                && newObj._comments.Equals(_comments)
                && newObj._likes.Equals(_likes)
                && newObj._picture.Equals(_picture)
                && newObj._text == _text
                && newObj._userPost.Equals(_userPost);
        }

        public override string ToString()
        {
            return $"{PrintComments()}\n" +
                   $"\tLikes: {PrintLikes()}\n" +
                   $"\tPicture: {_picture}\n" +
                   $"\tText: {_text}\n" +
                   $"\tUser posted: {_userPost.GetUserName()}\n";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_comments, _likes, _picture, _text, _userPost);
        }

        #endregion
    }
}

