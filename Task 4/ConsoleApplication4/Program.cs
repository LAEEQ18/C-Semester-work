using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the Number: ");
            int num = int.Parse(Console.ReadLine());
            
            for (int ii = 1; ii <= 10; ii++)
            {
                for (int i = 1; i <= num; i++)
                {
                    int coi = i * ii;
                    Console.Write("{0}x{1}={2} ", i, ii,coi);
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
