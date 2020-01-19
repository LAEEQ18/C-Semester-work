using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            
            }
            Console.WriteLine("The Reverse of Num is {0}", reverse);
            Console.ReadLine(); 
        }
   
    }
   
}
