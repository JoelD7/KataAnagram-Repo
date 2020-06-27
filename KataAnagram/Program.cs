using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAnagram
{
    public class Program
    {
        private static List<string> greaterSet = new List<string>();
        public static void Show(Dictionary<String, String> valuePairs)
        {

            string val = null;
            foreach (var key in valuePairs.Keys)
            {
                if (valuePairs.TryGetValue(key, out val))
                {
                    if (val.Contains(','))
                    {
                        greaterSet = val.Split(",").ToList().LongCount() > greaterSet.LongCount()
                        ? val.Split(",").ToList() : greaterSet;
                        System.Console.WriteLine(val);
                    }
                }
            }
            System.Console.WriteLine("Largest set: {0}", greaterSet.Aggregate((x,y)=>x + " " + y));

        }
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            AnagramFinder anagramFinder = new AnagramFinder(filename);
            Show(anagramFinder.GetAnagramGroups());
            System.Console.WriteLine("Longest anagrams: {0}", anagramFinder.GetLongestAnagrams());
        }
    }
}
