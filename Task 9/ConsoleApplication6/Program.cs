using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task9 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Its Power is: " + power(num,5));
            Console.ReadLine();
        }

        static int power(int number, int pow )
        {
            int r = 1;
            for (int i = 1; i <= pow ; i++)
            {
                r *= number ;
            }
            return r;
        }
    }
}
