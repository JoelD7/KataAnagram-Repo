
using System;

namespace KataAnagram{
    public class Alphabetizer
{
    public Alphabetizer()
    {
        
    }
    public string Alphabetize(string word)
    {
        char[] arr = word.ToCharArray();
        Array.Sort(arr);
        return new string(arr);
    }
}
}