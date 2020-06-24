using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace KataAnagram
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = Console.ReadLine();
            AnagramFinder anagramFinder = new AnagramFinder(path);
            Show(anagramFinder.GetAnagramGroups());
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
                        System.Console.WriteLine(val);
                    }
                }
            }
        }
    }
}
