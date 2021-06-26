using System;

namespace Ex4
{
    class Ex04
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());
       
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
            
        }
    }
}
