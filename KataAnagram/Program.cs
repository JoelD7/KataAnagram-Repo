using System;
using System.Collections.Generic;
using System.Linq;

namespace KataAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //FileReader
            //string path = @"F:\Anagram\wordss.txt";
            Console.Write("Please input the path to the text file with the words: ");
            string path = Console.ReadLine();
            Console.WriteLine();
            AnagramFinder anagramFinder = new AnagramFinder();
            foreach( var x in anagramFinder.FileReader(@path))
            {
                Console.WriteLine(x); 
            }
            
            List<List<string>> listOfList = new List<List<string>>();
            listOfList.Add(new string[]{"one","two"}.ToList());
            listOfList.Add(new string[]{"3","4"}.ToList());
            listOfList.Add(new string[]{"5","6"}.ToList());

            listOfList.ForEach((list)=>{
                System.Console.Write("List: ");
                foreach (var item in list)
                {
                    System.Console.Write("{0}, ", item);
                }
                System.Console.WriteLine();
            });
        }
    }
}
