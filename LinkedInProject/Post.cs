using System;
using System.Collections.Generic;

namespace LinkedInProject
{
    public class Post
    {
        #region Properties

        private readonly User _userPost;
        private readonly string _text;
        private readonly Picture _picture;
        private readonly IList<string> _comments;
        private readonly IList<Like> _likes;
        #endregion

        #region Ctor
        public Post(string text, Picture picture, IList<string> comments, int likes, User userPost)
        {
            _text = text;
            _picture = picture;
            _userPost = userPost;
            _likes = new List<Like>();
            _comments = new List<string>();
        }
        #endregion

        #region Gets
        public IList<Like> GetLikes()
        {
            return _likes;
        }
        public IList<string> GetComments()
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
        public void AddComment(string comment)
        {
            _comments.Add(comment);
        }
        
        public void AddLike(Like like)
        {
            _likes.Add(like);
        }
        #endregion

        #region OverrideMethods

        public override bool Equals(object obj)
        {
            Post newObj = (Post)obj;
            return newObj!=null
                && newObj.GetComments().Equals(this.GetComments())
                && newObj.GetLikes().Equals(this.GetLikes())
                && newObj.GetPicture().Equals(this.GetPicture())
                && newObj.GetText()==this.GetText()
                && newObj.GetUserPost().Equals(this.GetUserPost());
        }

        public override string ToString()
        {
            return $"This post Comments: {GetComments()}" +
                   $"And Likes: {GetLikes()}" +
                   $"And Picture: {GetPicture()}" +
                   $"And Text: {GetText()}" +
                   $"The User is: {GetUserPost()}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_comments,_likes,_picture,_text,_userPost);
        }

        #endregion
    }
}