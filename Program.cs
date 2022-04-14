using System;

namespace Zadanie_XX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] res = new int[array.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = array[i]*2;
            }
            Printer(res);
        }
        static void Printer(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
