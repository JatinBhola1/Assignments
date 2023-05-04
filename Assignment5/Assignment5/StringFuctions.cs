using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment5
{
    public class StringFuctions
    {
        public int NoOfCharacters(string str)
        {
            return str.Length;
        }
        public bool IsPalidrome(string str)
        {
            char[] s = str.ToCharArray();
            Array.Reverse(s);
            Console.WriteLine( s);
            if(str.CompareTo(new String(s)) == 0 )
                return true;
            else
                return false;

        }
        public string ReverseString(string str)
        {
            char[] s= str.ToCharArray();
            Array.Reverse(s);
            return  new string(s); 
        }
        public string ConvertUpperCase(string str)
        {
            return str.ToUpper();
        }

        public string ConvertLowerCase(string str)
        {
            return str.ToLower();
        }

        public string CombineTwoSentence(string str1, string str2)
        {
            string ans = String.Concat(str1, str2);
            return ans;
        }
        public int CountWords(string str)
        {
            int count = 1;
            foreach (char ch in str)
            {
                if (ch == ' ') count++;
            }
            return count;
        }
        public bool SearchSubstring(string str,string mainstr)
        {
            return mainstr.Contains(str);



        }
        public int CountSubstring(String str, String substring)
        {



            string[] chars = str.ToLower().Split(substring.ToLower());



            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i] + "\t");

            }



            return str.ToLower().Split(substring.ToLower()).Length - 1;

        }



    }
}
