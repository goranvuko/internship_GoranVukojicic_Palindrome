using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace palindrome
{
    public class isTheWordPalindrome
    {
        public static Boolean IsPalindrome()
        {
            string str = "";
            Console.WriteLine("Enter string:");

            str = Console.ReadLine();
            str = str.Replace(" ", "");

            str = str.Replace("'", "");
            str = str.Replace(".", "");
            str = str.Replace(",", "");
            str = str.Replace("!", "");
            str = str.Replace("?", "");
            str = str.ToLower();

            for (int i=0; i<str.Length / 2; i++)
            {
                if (str[i] != str[str.Length -1 - i]) return false;
            }
            return true;
        }
    }
}
