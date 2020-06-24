using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace KataAnagram
{
    public class AnagramFinder
    {
        private Dictionary<string, string> anagramGroups;
        private Alphabetizer alphabetizer;
        private string filename;

        public AnagramFinder(string filename)
        {
            anagramGroups = new Dictionary<string, string>();
            this.filename = filename;
            alphabetizer = new Alphabetizer();
            GroupAnagrams();

        }
        public AnagramFinder()
        {
            List<string> list = new List<string>();
            list.Add("d");
            list.Add("d");
        }

        private void GroupAnagrams()
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

        public Dictionary<string, string> GetAnagramGroups(){
            return anagramGroups;
        }
    }
}
