using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PostAndComments.Lib
{
    public class Post : ICommentable
    {
        ICollection<string> comments;

        public Post(ICollection<string> comments)
        {
            this.comments = comments;
        }

        public void AddComment(string comment)
        {
            comments.Add(comment);
        }

        public ICollection<string> GetComments()
        {
            return comments;
        }
    }
}
