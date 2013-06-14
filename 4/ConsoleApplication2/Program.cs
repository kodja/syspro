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
            Console.WriteLine("Vvedite 4islo");
            int s = Convert.ToInt32(Console.ReadLine());
            int i,min=0;
            int []a = new int[10];
            i = 0;
            while (i < 10)
            {
                Console.WriteLine("Введите a[" + i + "]=");
                a[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            i = 0;
            while  (i<10)
            {
                if ((a[i] >= s) && (Prost(a[i]) == 0))
                    min = a[i];
                i++;
            }
            i = 0;
            while (i < 10)
            {
                if ((a[i] >= s) && (Prost(a[i]) == 0) && (a[i]<min))
                    min = a[i];
                i++;
            }
            Console.WriteLine("min = " + min);


        }
        static int Prost(int n)
        {
            int x = 0;
            int i = n/2;
            while(i > 1)
            {
                if (n % i == 0)
                {
                    x = 1;
                }
                i--;
            }
            if (x == 0)
            {
                return 0;
            }
            else 
                return 1;
        }

    }
}
