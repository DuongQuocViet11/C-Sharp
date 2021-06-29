using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new { Name = "Michgan Enterpries", Code = 1301, Price = 35056.75 };
            Console.WriteLine("Stock Name: " + stock.Name);
            Console.WriteLine("Stock Code: " + stock.Code);
            Console.WriteLine("Stock Price: " + stock.Price);
        }

        public static void Main(string[] args)
        {
            Employee david = new Employee();
            david.DisplayDetails(new { FirstName = "David", LastName = "Olake", Age = 30 });
            Console.Read();
        }
    }
}
