using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KataAnagram
{
    public class FileReader
    {
        public List<string> GetWords(string p)
        {
            List<string> words = new List<string>();
            try
            {
                string[] lines = File.ReadAllLines(p, Encoding.UTF8);
                var MyArrayLower = lines.Select(s => s.ToLowerInvariant()).ToArray();
                words = new List<string>(MyArrayLower);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please make sure the file is on txt format and it is on the specified route");
                Console.Write("Please input the correct path: ");
                FileReader fileReader = new FileReader();
                string path = Console.ReadLine();
                Console.WriteLine();
                return fileReader.GetWords(@path);
            }
            return words;
        }
    }
}
