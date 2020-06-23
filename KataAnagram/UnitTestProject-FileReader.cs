// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System;
// using System.Collections.Generic;

// namespace UnitTestProject1
// {
//     [TestClass]
//     public class UnitTest1
//     {
//         //Check for nonImplementedmethod
//         [TestMethod]
//         public void TestMethod1()
//         {
//             List<string> List;
//             KataAnagram.FileReader anagramFinder = new KataAnagram.FileReader();
//             Assert.ThrowsException<NotImplementedException>(() => List = anagramFinder.GetWords(""));
//         }
//         [TestMethod]
//         public void TestMethod2()
//         {
//             List<string> List;
//             KataAnagram.FileReader anagramFinder = new KataAnagram.FileReader();
//             Assert.ThrowsException<ArgumentException>(() => List = anagramFinder.GetWords(""));
//         }
//         [TestMethod]
//         public void TestMethod3()
//         {
//             KataAnagram.FileReader anagramFinder = new KataAnagram.FileReader();
//             CollectionAssert.AreEqual(new string[] { }, anagramFinder.GetWords(@"F:\Anagram\emptyfile.txt"));
//         }

//         [TestMethod]
//         public void TestMethod4()
//         {
//             KataAnagram.FileReader anagramFinder = new KataAnagram.FileReader();
//             CollectionAssert.AreEqual(new string[] {"hola","como","estas","bien","Bye"}, anagramFinder.GetWords(@"F:\Anagram\somewords.txt"));
//         }

//         [TestMethod]
//         public void TestMethod5()
//         {
//             KataAnagram.FileReader anagramFinder = new KataAnagram.FileReader();
//             CollectionAssert.AreEqual(new string[] { "hola", "como", "estas", "bien", "bye" }, anagramFinder.GetWords(@"F:\Anagram\somewords.txt"));
//         }
//     }
// }
