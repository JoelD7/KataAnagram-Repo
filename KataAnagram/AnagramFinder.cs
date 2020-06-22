using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;

namespace KataAnagram
{
    public class AnagramFinder
    {
        public List<string> FileReader(string p) 
        {
			List<string> anagramsGroup = new List<string>();
			try
			{
				string[] lines = File.ReadAllLines(p, Encoding.UTF8);
				var MyArrayLower = lines.Select(s => s.ToLowerInvariant()).ToArray();
				anagramsGroup = new List<string>(MyArrayLower);
			}
			catch (Exception e )
			{
				Console.WriteLine("Please make sure the file is on txt format and it is on the specified route");
			}
			return anagramsGroup;
		}
    }
}
