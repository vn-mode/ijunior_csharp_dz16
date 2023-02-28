using System;

namespace vn_mode_csharp_dz_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomForNumberN = new Random();

            int loverGivenRange = 1;
            int hiverGivenRange = 27;
            int numberN = randomForNumberN.Next(loverGivenRange, (hiverGivenRange + 1));
            int counterNumbersMultiplesN = 0;
            int lowerRangeLimit = 100;
            int upperRangeLimit = 999;

            Console.WriteLine("Рандомное число: " + numberN);

            for (int i = 0; i <= upperRangeLimit; i += numberN)
            {
                if (i >= lowerRangeLimit)
                {
                    counterNumbersMultiplesN++;
                }
            }

            Console.WriteLine("Количество чисел кратное числу " + numberN + "равно " + counterNumbersMultiplesN);
        }
    }
}
