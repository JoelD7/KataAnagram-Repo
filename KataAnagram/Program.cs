using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KataAnagram
{
    public class Program
    {
        private static List<string> greaterSet = new List<string>();
        private static AnagramFinder anagramFinder;
        private static string outputFile;
        public static void Show(Dictionary<String, String> valuePairs)
        {

            string val = null;
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (var key in valuePairs.Keys)
                {
                    if (valuePairs.TryGetValue(key, out val))
                    {
                        if (val.Contains(','))
                        {
                            greaterSet = val.Split(",").ToList().LongCount() > greaterSet.LongCount()
                            ? val.Split(",").ToList() : greaterSet;
                            writer.WriteLine(val);
                        }
                    }
                }
                writer.WriteLine("Largest set: {0}", greaterSet.Aggregate((x, y) => x + " " + y));
                writer.WriteLine("Longest anagrams: {0}", anagramFinder.GetLongestAnagrams());
            }
        }
        static void Main(string[] args)
        {
            System.Console.Write("Enter input file: ");
            string filename = Console.ReadLine();
            System.Console.WriteLine();

            System.Console.Write("Enter output file: ");
            outputFile = Console.ReadLine();

            anagramFinder = new AnagramFinder(filename);
            Show(anagramFinder.GetAnagramGroups());

        }
    }
}
