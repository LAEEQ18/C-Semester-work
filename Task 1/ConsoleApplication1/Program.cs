using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int Natural = 0;
            for (int i = 1; i <= 10; i++)
            {
                Natural += i;
            }
            Console.WriteLine(Natural);
            Console.ReadLine();
        }
    }
}
