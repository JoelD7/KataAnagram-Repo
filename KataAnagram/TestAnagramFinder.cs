using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace KataAnagram
{
    public class TestAnagramFinder
    {
        [Fact]

        public void test()
        {
            List<List<string>> expected = new List<List<string>>();
            expected.Add(new string[] { "tar", "rat" }.ToList());
            expected.Add(new string[] { "arc", "car" }.ToList());
            expected.Add(new string[] { "glean", "angel" }.ToList());
            expected.Add(new string[] { "stressed", "desserts" }.ToList());
            expected.Add(new string[] { "state", "taste" }.ToList());
            expected.Add(new string[] { "elbow", "below" }.ToList());
            expected.Add(new string[] { "cried", "cider" }.ToList());
            expected.Add(new string[] { "dusty", "study" }.ToList());
            expected.Add(new string[] { "pairs", "paris" }.ToList());
            expected.Add(new string[] { "chin", "inch" }.ToList());
            expected.Add(new string[] { "night", "thing" }.ToList());
            expected.Add(new string[] { "robed", "bored" }.ToList());
            expected.Add(new string[] { "grab", "brag" }.ToList());
            expected.Add(new string[] { "cat", "act" }.ToList());
            expected.Add(new string[] { "nerved", "denver" }.ToList());
            expected.Add(new string[] { "save", "vase" }.ToList());
            expected.Add(new string[] { "votes", "stove" }.ToList());
            expected.Add(new string[] { "fried", "fired" }.ToList());
            expected.Add(new string[] { "untied", "united" }.ToList());
            expected.Add(new string[] { "dog", "god" }.ToList());
            expected.Add(new string[] { "wolf", "flow" }.ToList());
            expected.Add(new string[] { "hear", "here" }.ToList());
            expected.Add(new string[] { "teacher", "cheater" }.ToList());
            expected.Add(new string[] { "break", "baker" }.ToList());
            expected.Add(new string[] { "rebuild", "builder" }.ToList());
            expected.Add(new string[] { "dice", "iced" }.ToList());
            expected.Add(new string[] { "senator", "treason" }.ToList());
            expected.Add(new string[] { "kitchen", "thicken" }.ToList());
            AnagramFinder anagram = new AnagramFinder();
            // List<List<string>> actual = anagram.GetAnagramGroups();

            // Assert.Equal(expected, actual);

        }



    }
}