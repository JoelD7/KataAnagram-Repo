using System;
using System.Collections.Generic;
using System.Linq;


namespace KataAnagram
{
    public class AnagramFinder
    {
        public List<string> list = new List<string>();
        private AlphabetizerMock alphabetizer;
        private string longestAnagram;
        private Dictionary<string, string> anagramGroups;

        public AnagramFinder(List<string> list)
        {
            this.list = list;
            longestAnagram = "";
            anagramGroups = new Dictionary<string, string>();
            alphabetizer = new AlphabetizerMock();
            GroupAnagrams();
        }

        public void GroupAnagrams()
        {
            string curWord;
            for (int i = 0; i < list.LongCount(); i++)
            {
                curWord = list[i];
                string key = alphabetizer.Alphabetize(curWord);
                string value;
                if (anagramGroups.TryGetValue(key, out value))
                {
                    longestAnagram = key.Length > longestAnagram.Length ? key : longestAnagram;
                    anagramGroups[key] = value + ", " + curWord;
                }
                else
                {
                    anagramGroups.Add(key, curWord);
                }
            }
        }

        public string GetLongestAnagrams(){
            return anagramGroups[longestAnagram];
        }

        public Dictionary<string, string> GetAnagramGroups()
        {
            return anagramGroups
            .Where(kvp => kvp.Value.Contains(","))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

    }


}