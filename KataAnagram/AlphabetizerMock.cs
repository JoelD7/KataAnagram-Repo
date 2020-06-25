
using System;
using System.Collections.Generic;

namespace KataAnagram
{
    public class AlphabetizerMock
    {
        public Dictionary<string, string> keys;
        public AlphabetizerMock()
        {
            keys = new Dictionary<string, string>();
            keys.Add("tar", "art");
            keys.Add("rat", "art");
            keys.Add("arc", "acr");
            keys.Add("car", "acr");

        }
        public string Alphabetize(string word)
    {
        char[] arr = word.ToCharArray();
        Array.Sort(arr);
        return new string(arr);
    }
    }
}