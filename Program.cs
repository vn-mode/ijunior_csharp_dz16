using System;

namespace vn_mode_csharp_dz_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int minSourceNumber = 1;
            int maxSourceNumber = 27;
            int sourceNumber;
            int counter = 0;
            int minNumber = 100;
            int maxNumber = 1000;
            int tempNumber;

            Random randomSourceNumber = new Random();
            sourceNumber = randomSourceNumber.Next(minSourceNumber, (maxSourceNumber + 1));
            tempNumber = sourceNumber;

            for (int i = tempNumber; i < maxNumber; i++)
            {
                if (tempNumber >= minNumber && tempNumber < maxNumber )
                {
                    counter++;
                }
                tempNumber++;
            }

            Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны {sourceNumber}  = {counter}");

        }
    }
}
