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
            var list = new List<int> { 44, 10, 5, 35, 5, 20 };
            list.Reverse();
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}