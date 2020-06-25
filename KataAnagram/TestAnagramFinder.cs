using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace KataAnagram
{
    public class TestAnagramFinder
    {
        public List<string> list = new List<string>();

        public TestAnagramFinder()
        {
            list.Add("tar");
            list.Add("arc");
        }

        [Fact]
        public void test()
        {
            Dictionary<string,string> expected = new Dictionary<string, string>();
            expected.Add("art","tar, rat");
            expected.Add("acr","arc, car");
            expected.Add("aegln","glean, angel");


            AnagramFinder anagram = new AnagramFinder(list);
            Dictionary<string,string> actual = anagram.GetAnagramGroups();
            Assert.Equal(expected, actual);
        }

        public void TestLongestAnagrams(){
            AnagramFinder anagram = new AnagramFinder(list);
            string expected = "stressed, desserts";
            string actual = anagram.GetLongestAnagrams();
            Assert.Equal(expected, actual);
        }



    }
}