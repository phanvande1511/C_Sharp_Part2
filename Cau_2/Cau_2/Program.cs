using System;

namespace Cau_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Squared From 1 To {0}: {1}", number, squared(number));
        }

        static int squared(int number)
        {
            if (number == 1)
            {
                return 1;
            } else
            {
                return squared(number - 1) + (number * number);
            }
        }
    }
}
 