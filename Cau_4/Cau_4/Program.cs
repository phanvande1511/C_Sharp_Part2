using System;

namespace Cau_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum Of Fractions From 1/2 To 1/{0}: {1:0.00}", number * 2, sumOfFractions(number));
        }

        static double sumOfFractions(int number)
        {
            if(number == 0)
            {
                return 0;
            } else
            {
                return sumOfFractions(number - 1) + (1 / (double)(number * 2));
            }
        }
    }
}
