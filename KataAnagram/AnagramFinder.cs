using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KataAnagram
{
    public class AnagramFinder
    {
        public List<string> FileReader(string p)
        {
            List<string> anagramsGroup = new List<string>();
            //Exception notImplemented = new NotImplementedException();
            //throw notImplemented;
            try
            {
                string[] lines = File.ReadAllLines(p, Encoding.UTF8);
                var MyArrayLower = lines.Select(s => s.ToLowerInvariant()).ToArray();
                anagramsGroup = new List<string>(MyArrayLower);
                //anagramsGroup = new List<string>(lines);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please make sure the file in on txt format and it is on the specified route");
                Console.Write("Please input the correct path: ");
                AnagramFinder anagramFinder2 = new AnagramFinder();
                string path = Console.ReadLine();
                return anagramFinder2.FileReader(@path);
            }
            return anagramsGroup;
        }
    }
}
