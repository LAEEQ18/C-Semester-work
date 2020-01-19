using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the Number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {

                int cube = i*i*i;
                Console.WriteLine("Number is: {0} and the Cube is: {1}",i,cube);
            }
            
            Console.ReadLine();
        }
    }
}
