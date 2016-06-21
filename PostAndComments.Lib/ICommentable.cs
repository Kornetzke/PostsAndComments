using System.Collections.Generic;


namespace PostAndComments.Lib
{
    public interface ICommentable
    {
        void AddComment(string comment);
        ICollection<string> GetComments();
    }
}