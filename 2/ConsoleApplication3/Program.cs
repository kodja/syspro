using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    class Sort
    {
        public const int Max = 5;

        int[] Array = new int[Max];

        public void GetArray()
        {
            for (int i = 0; i < Max; ++i)
            {
                Console.Write("введите число: ");
                string S = Console.ReadLine();
                int Value = int.Parse(S);
                Array[i] = Value;
            }

        }

        private void Swap(int FElem, int SecElem)
        {
            int tmp;
            tmp = Array[FElem];
            Array[FElem] = Array[SecElem];
            Array[SecElem] = tmp;
        }

        public void PrintArray()
        {
            for (int i = 0; i < Max; ++i)
                Console.WriteLine(Array[i]);
        }

        public void BubbleSort()
        {
            int i, j;

            for (i = 1; i < Max; ++i)
                for (j = 0; j < Max - i; ++j)
                    if (Array[j] > Array[j + 1])
                    {
                        Swap(j, j + 1);
                    }


        }
    }
    class Sorti
    {
        public static void Main(string[] args)
        {
            Sort sort = new Sort();
            sort.GetArray();
            Console.WriteLine("до сортировки:");
            sort.PrintArray();
            sort.BubbleSort();
            Console.WriteLine("после:");
            sort.PrintArray();
            Console.ReadLine();
        }
    }
}