using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helper;

namespace TextMatch.Tests
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void TextMatchPositionEmptyText()
        {
            StringHelper utility = new StringHelper();

            List<int> result = utility.TextMatchPosition("", "test"); 

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void TextMatchPositionNullText() {
            StringHelper utility = new StringHelper();

            List<int> result = utility.TextMatchPosition(null, "test");

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void TextMatchPositionEmptySearch() {
            StringHelper utility = new StringHelper();

            List<int> result = utility.TextMatchPosition("Lorem ipsum dolor", "");

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void TextMatchPositionNullSearch() {
            StringHelper utility = new StringHelper();

            List<int> result = utility.TextMatchPosition("Lorem ipsum dolor", null);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void TextMatchPositionTestCase1() {
            StringHelper utility = new StringHelper();

            List<int> result = utility.TextMatchPosition("Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea", "polly");

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(26, result[1]);
            Assert.AreEqual(51, result[2]);
        }

        [TestMethod]
        public void TextMatchPositionTestCase2() {
            StringHelper utility = new StringHelper();

            List<int> result = utility.TextMatchPosition("11112", "12");

            Assert.IsNotNull(result);
            Assert.AreEqual(4, result[0]);
        }

        [TestMethod]
        public void TextMatchPositionTestCase3() {
            StringHelper utility = new StringHelper();

            List<int> result = utility.TextMatchPosition("aaaa", "aa");

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
        }
    }
}
