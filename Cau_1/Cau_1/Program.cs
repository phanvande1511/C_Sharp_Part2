using System;

namespace Cau_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            Console.Write("Total From 0 To {0}: {1}", number, sum(number));
        }

        static int sum(int number)
        {
            if (number == 1)
            {
                return 1;
            } else
            {
                return sum(number - 1) + number;
            }
        }
    } 
}
