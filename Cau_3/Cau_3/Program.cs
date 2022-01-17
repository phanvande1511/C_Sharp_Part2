using System;

namespace Cau_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum Of Fractions From 1 To 1/{0}: {1:0.00}", number, sumOfFractions(number));
        }

        static double sumOfFractions(int number)
        {
            if(number == 1)
            {
                return 1;
            } else
            {
                return sumOfFractions(number - 1) + (1 / (double)number);
            }
        }
    }
}