using System;

namespace Cau_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum Of Fractions From 1 To 1/{0}: {1:0.000}", (number * 2) + 1, sumOfFractions(number) + 1);
        }

        static double sumOfFractions(int number)
        {
            if((double)number == 0)
            {
                return 0;
            } else
            {
                return sumOfFractions(number - 1) + (1 / ((2 * (double)number) + 1));
            }
        }
    }
}
