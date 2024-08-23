using EF009.IncludeEntities.Data;
using EF009.IncludeEntities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF009.IncludeEntities
{
    class Program
    {
        public static void Main()
        {
            var context=new AppDbContext();

            /*var OrderDetails1 = context.Orders
                            .Include(x => x.OrderDetails)
                            .FirstOrDefault(x => x.Id == 1)
                            .OrderDetails;
                        Console.WriteLine(OrderDetails1.Count());
                        Console.ReadKey();
            */

        }
    }
}