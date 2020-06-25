using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace KataAnagram
{
    class Program
    {
        private static List<string> greaterSet = new List<string>();
        static void Main(string[] args)
        {

            string path = Console.ReadLine();
            AnagramFinder anagramFinder = new AnagramFinder(path);
            Show(anagramFinder.GetAnagramGroups());
            System.Console.WriteLine("Longest anagrams: {0}", anagramFinder.GetLongestAnagrams());
            Dictionary<string,string> d = new Dictionary<string, string>();
            d.Add("acr","mike, mike");
            
            Dictionary<string,string> dd = new Dictionary<string, string>();
            dd.Add("acr","mike, mike"); 

        }


        static void Show(Dictionary<string, string> d)
        {
            foreach (var key in d.Keys)
            {
                string val;
                if (d.TryGetValue(key, out val))
                {
                    if (val.Contains(","))
                    {   
                        greaterSet = val.Split(",").ToList().LongCount() > greaterSet.LongCount() ? val.Split(",").ToList() : greaterSet;
                        System.Console.WriteLine(val);
                    }
                }
            }
            System.Console.WriteLine("Largest set: {0}", greaterSet.Aggregate((x,y)=>x+" " + y));
        }
    }
}
