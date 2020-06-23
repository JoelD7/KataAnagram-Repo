using System;
using System.Collections.Generic;
using System.Linq;

namespace KataAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please input the path to the text file with the words: ");
            string path = Console.ReadLine();
            Console.WriteLine();
            AnagramFinder anagramFinder = new AnagramFinder(path);
            
            
            List<List<string>> listOfList = anagramFinder.GetAnagramGroups();
            

            listOfList.ForEach((list)=>{
                foreach (var item in list)
                {
                    System.Console.Write("{0}, ", item);
                }
                System.Console.WriteLine();
            });
        }
    }
}
