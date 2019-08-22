using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StoryStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //bool result = Regex.IsMatch(text, "\\programming\\b", RegexOptions.IgnoreCase);
            if (text.Contains("programming"))
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
        }
    }
}
