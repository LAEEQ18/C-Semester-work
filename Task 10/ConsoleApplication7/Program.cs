using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the Sentence: ");
            string s = Console.ReadLine();
            Console.WriteLine("The Reverse is: " + revStr(s));
            Console.ReadLine();
        }

        static string revStr(string sen)
        {
            string retu = "";
            var s = sen.Split(' ');
            for (int i = s.Length-1; i >= 0; i--)
            {
                retu = retu +" "+  s[i];
            }
            return retu;
        }
    }
}
