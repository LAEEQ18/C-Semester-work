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
           
            int product=1;
            Console.WriteLine("Even numbers from 1 - 10 are: ");
            for (int i = 1 ; i <=10 ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    product *= i;
                }
            }
            Console.WriteLine("And their Product is: " + product);
            Console.ReadLine();
        }
    }
}