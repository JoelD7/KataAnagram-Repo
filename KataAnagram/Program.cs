using System;
using System.Collections.Generic;
using System.Linq;

namespace KataAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string path = "";
            //AnagramFinder Anagram = new AnagramFinder();
            //AnagramFinder(path);
            
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
