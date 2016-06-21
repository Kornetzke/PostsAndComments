using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostAndComments.Lib;
using System.Collections.Generic;
using System.Collections;

namespace PostsAndComments.Test
{
    [TestClass]
    public class PostTests
    {
        Post post;
        ICollection<string> commentsCollection;

        [TestInitialize]
        public void TestInit()
        {
            commentsCollection = new List<string>();
            post = new Post(commentsCollection);
        }

        [TestMethod]
        public void AddComment_Hello()
        {
            string comment = "hello";
            post.AddComment(comment);

            ICollection<string> expected = new List<string>() { comment };
            ICollection<string> actual = commentsCollection;

            Assert.IsNotNull(actual as ICollection);
            CollectionAssert.AreEqual(expected as ICollection, actual as ICollection);
        }

        [TestMethod]
        public void GetComments_Hello()
        {
            string comment = "hello";
            commentsCollection.Add(comment);

            ICollection<string> expected = new List<string>() { comment };
            ICollection<string> actual = post.GetComments();

            Assert.IsNotNull(actual as ICollection);
            CollectionAssert.AreEqual(expected as ICollection, post.GetComments() as ICollection);
        }
    }
}
