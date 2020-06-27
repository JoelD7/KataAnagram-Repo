using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAnagram
{
    public class Program
    {
        public static string Show(Dictionary<String,String> valuePairs)
        {

            string val = null;
            foreach (var key in valuePairs.Keys)
            {
                if(valuePairs.TryGetValue(key,out val))
                {
                    if (val.Contains(','))
                    {
                        return val;
                    }
                }
            }

            return null;
        }
        static void Main(string[] args)
        {
        }
    }
}
