using EF009.ExcludeEntities.Data;
using System;

namespace EF009.ExcludeEntities
{
    class Program
    {
        public static void Main()
        {
            var context = new AppDbContext();
            foreach (var item in context.Products)
            {
                Console.WriteLine($"{item.Name} => loaded at: " +
                    $"{item.Snapshot.LoadAt.ToString()}" +
                    $"\nVersion:{item.Snapshot.Version}");
            }
            Console.ReadKey();
        }
    }
}