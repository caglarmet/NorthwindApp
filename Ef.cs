using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class EfExample
{
    public static void Run()
    {
        using (var context = new NorthwindContext())
        {
            var products = context.Products.ToList();

            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.UnitPrice}, Stock: {product.UnitsInStock}");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
