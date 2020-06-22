using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Check for nonImplementedmethod
        [TestMethod]
        public void TestMethod1()
        {
            List<string> List;
            KataAnagram.AnagramFinder anagramFinder = new KataAnagram.AnagramFinder();
            Assert.ThrowsException<NotImplementedException>(() => List = anagramFinder.FileReader(""));
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<string> List;
            KataAnagram.AnagramFinder anagramFinder = new KataAnagram.AnagramFinder();
            Assert.ThrowsException<ArgumentException>(() => List = anagramFinder.FileReader(""));
        }
        [TestMethod]
        public void TestMethod3()
        {
            KataAnagram.AnagramFinder anagramFinder = new KataAnagram.AnagramFinder();
            CollectionAssert.AreEqual(new string[] { }, anagramFinder.FileReader(@"F:\Anagram\emptyfile.txt"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            KataAnagram.AnagramFinder anagramFinder = new KataAnagram.AnagramFinder();
            CollectionAssert.AreEqual(new string[] {"hola","como","estas","bien","Bye"}, anagramFinder.FileReader(@"F:\Anagram\somewords.txt"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            KataAnagram.AnagramFinder anagramFinder = new KataAnagram.AnagramFinder();
            CollectionAssert.AreEqual(new string[] { "hola", "como", "estas", "bien", "bye" }, anagramFinder.FileReader(@"F:\Anagram\somewords.txt"));
        }
    }
}
