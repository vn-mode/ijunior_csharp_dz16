using System;

namespace vn_mode_csharp_dz_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int sourceNumber = 1;
            int counter = 0;
            int minNumber = 100;
            int maxNumber = 1000;

            for(int i = minNumber; i < maxNumber; i++)
            {
                counter++;
            }

            Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны {sourceNumber}  = {counter}");

        }
    }
}
