using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                sum += (i * i);
            }
            Console.WriteLine("The Sum is : " + sum);
            Console.ReadLine();
        }
    }
}
