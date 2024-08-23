using EF009.BasicSetup.Data;
using System;

namespace EF009.BasicSetup
{
    class Program
    {
        public static void Main()
        {
            var Context= new AppDbContext();
            foreach(var item in Context.orderDetails) 
            {
                Console.WriteLine($"{item.OrderId}{item.ProductId}");
            }
            Console.ReadKey();
        }
    }
}