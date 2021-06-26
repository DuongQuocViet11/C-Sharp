using System;

namespace Ex3
{
    class Ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1-7): ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1: Console.WriteLine("1- Monday");
                    break;
                case 2:
                    Console.WriteLine("2- Tuesday");
                    break;
                case 3:
                    Console.WriteLine("3- Wednesday");
                    break;
                case 4:
                    Console.WriteLine("4- Thursday");
                    break;
                case 5:
                    Console.WriteLine("5- Friday");
                    break;
                case 6:
                    Console.WriteLine("6- Saturday");
                    break;
                case 7:
                    Console.WriteLine("7- Sunday");
                    break;
            }
        }
    }
}
