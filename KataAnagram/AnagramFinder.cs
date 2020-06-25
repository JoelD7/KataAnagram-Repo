using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KataAnagram {
    public class AnagramFinder {
        private Dictionary<string, string> anagramGroups;
        private AlphabetizerMock alphabetizer;
        private string filename;
        public List<string> list;
        private string longestAnagrams = "";
        private List<string> greaterSet;

        public AnagramFinder (string filename) {
            anagramGroups = new Dictionary<string, string> ();
            greaterSet = new List<string>();
            this.filename = filename;
            alphabetizer = new AlphabetizerMock ();
            GroupAnagrams ();

        }
        public AnagramFinder (List<string> list) {
            this.list = list;
        }

        private void GroupAnagrams () {
            using (StreamReader reader = new StreamReader (filename)) {

                string curWord = reader.ReadLine ();
                while (curWord != null) {

                    string key = alphabetizer.Alphabetize (curWord);
                    
                    string value;
                    if (anagramGroups.TryGetValue (key, out value)) {
                        longestAnagrams = key.Length > longestAnagrams.Length ? key : longestAnagrams;
                        anagramGroups[key] = value + ", " + curWord;
                    } else {
                        anagramGroups.Add (key, curWord);
                    }
                    curWord = reader.ReadLine ();
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

        public Dictionary<string, string> GetAnagramGroups () {
            return anagramGroups;
        }
        public string GetLongestAnagrams(){
            return anagramGroups[longestAnagrams];
        }
    }
}