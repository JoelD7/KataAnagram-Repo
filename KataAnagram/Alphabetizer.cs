using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAnagram
{
    public class Alphabetizer
    {
        public string Alphabetize(string word)
        {
            word = word.ToLower();
            char[] newArray = word.ToCharArray();
            Array.Sort(newArray);
            return new string(newArray);
        }
    }
}
