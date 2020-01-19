using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int sum = 0;
            int s = 1;

            Console.WriteLine(f);
            Console.WriteLine(s);
            int count = 1;

            while (count <= 10)
            {

                sum = f + s;
                Console.WriteLine(sum);
                f = s;
                s = sum;
                count++;
            }
            Console.ReadLine();
        }
    }
}
