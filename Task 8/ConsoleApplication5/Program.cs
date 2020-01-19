using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int prod = 1;
            string s = "x";
            
            for (int i = 10; i > 0; i--)
            {
                if (i == 1)
                {
                    s = ":";
                }
               
                Console.Write(i+s);
                prod *= i;
            }
            Console.WriteLine();
            Console.WriteLine("Fictorial of 10 is: " + prod);
            Console.ReadLine();
        }
    }
}
