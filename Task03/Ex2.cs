using System;

namespace Ex2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first numner: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("First number is maximun number");
                }
                else
                {
                    Console.Write("Third number is maximun number");
                }
            }
            else if (b > c)
                Console.Write("Second number is maximun number");
            else
                Console.Write("Third number is maximun number");
        }
    }
}
