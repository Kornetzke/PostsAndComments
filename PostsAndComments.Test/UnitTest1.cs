using System;
using NUnit.Framework;
using System.Collections.Generic;
using PostAndComments.Lib;
using System.Collections;

namespace PostsAndComments.Test
{
    [TestFixture]
    public class UnitTest1
    {

        ICollection<string> commentCollection;
        Post post;


        [SetUp]
        public void SetUp()
        {
            commentCollection = new List<string>();
            post = new Post(commentCollection);
        }


        [Test]
        public void AddComment_Hello_NUnit()
        {
            string comment = "hello";
            post.AddComment(comment);

            ICollection<string> expected = new List<string>() { comment };
            ICollection<string> actual = post.GetComments();


            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
