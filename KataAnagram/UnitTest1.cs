using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataAnagram;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class AlphabetizeTest
    {
        //[TestMethod]
        //public void test_Alphabetizer_NotImplemented()
        //{
        //    Alphabetizer alphabetizer = new Alphabetizer();
        //    Assert.ThrowsException<NotImplementedException>(() => alphabetizer.Alphabetize("Raul"));
        //}

        [TestMethod]
        public void test_Alphabetizer_Alphabetize_First()
        {
            Alphabetizer alphabetizer = new Alphabetizer();
            string expected = "abz";
            Assert.AreEqual(expected, alphabetizer.Alphabetize("zab"));
        }

        [TestMethod]
        public void test_Alphabetizer_Alphabetize_Lowercase()
        {
            Alphabetizer alphabetizer = new Alphabetizer();
            string expected = "adq";
            Assert.AreEqual(expected, alphabetizer.Alphabetize("aqd"));
        }

        [TestMethod]
        public void test_Alphabetizer_Alphabetize_Uppercase()
        {
            Alphabetizer alphabetizer = new Alphabetizer();
            string expected = "adq";
            Assert.AreEqual(expected, alphabetizer.Alphabetize("aqD"));
        }

        [TestMethod]
        public void test_Alphabetizer_Alphabetize_EmptySpace()
        {
            Alphabetizer alphabetizer = new Alphabetizer();
            string expected = "";
            Assert.AreEqual(expected, alphabetizer.Alphabetize(""));
        }

        [TestMethod]
        public void test_Alphabetizer_Alphabetize_With_Apostrophe()
        {
            Alphabetizer alphabetizer = new Alphabetizer();
            string expected = "'im";
            Assert.AreEqual(expected, alphabetizer.Alphabetize("I'm"));
        }

        [TestMethod]
        public void test_Alphabetizer_Alphabetize_With_Number()
        {
            Alphabetizer alphabetizer = new Alphabetizer();
            string expected = "'3im";
            Assert.AreEqual(expected, alphabetizer.Alphabetize("I'm3"));
        }

    }

    [TestClass]
    public class ShowTest
    {
        [TestMethod]
        public void test_Show()
        {
            Dictionary<String,String > CompareDictionary = new Dictionary<String, String>();
            string value = "a1bc";
            string nextword = "abc1";
            CompareDictionary.Add("1abc", value + ", " + nextword);
            string expected = "a1bc, abc1";
            Assert.AreEqual(expected, Program.Show(CompareDictionary));
        }
        [TestMethod]
        public void test_Show_Without_Commas()
        {
            Dictionary<String, String> CompareDictionary = new Dictionary<String, String>();
            string value = "a1bc";
            CompareDictionary.Add("1abc", value);
            string expected = null;
            Assert.AreEqual(expected, Program.Show(CompareDictionary));
        }
    }
}
