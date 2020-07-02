using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace KataAnagram
{
    public class AnagramFinder
    {
        public List<string> list = new List<string>();
        private Alphabetizer alphabetizer;
        private string longestAnagram;
        private string filename;
        private Dictionary<string, string> anagramGroups;

        public AnagramFinder(List<string> list)
        {
            this.list = list;

        }

        public AnagramFinder(string filename)
        {
            this.filename = filename;
            longestAnagram = "";
            anagramGroups = new Dictionary<string, string>();
            alphabetizer = new Alphabetizer();
            GroupAnagrams();
        }


        public void GroupAnagrams()
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string curWord = reader.ReadLine();
                while (curWord != null)
                {
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
                    curWord = reader.ReadLine();
                }
            }
        }
        // private void GroupAnagrams()
        // {
        //     string curWord;
        //     for (int i = 0; i < list.LongCount(); i++)
        //     {
        //         curWord = list[i];
        //         string key = alphabetizer.Alphabetize(curWord);
        //         string value;
        //         if (anagramGroups.TryGetValue(key, out value))
        //         {
        //             anagramGroups[key] = value + ", " + curWord;
        //         }
        //         else
        //         {
        //             anagramGroups.Add(key, curWord);
        //         }
        //     }
        // }

        public string GetLongestAnagrams()
        {
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