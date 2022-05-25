using System;

namespace vn_mode_csharp_dz_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            int counter = 0;

            for(int i = 100; i < 1000; i++)
            {
                counter++;
            }

            Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны {N}  = {counter}");

        }
    }
}
