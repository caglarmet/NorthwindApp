using System;
using Microsoft.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Collections.Generic;
using NorthwindApp.Models;

public class DapperExample
{
    public static void Run()
    {
        string connectionString = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;";

        using (var connection = new SqlConnection(connectionString))
        {
            string query = "SELECT ProductName, UnitPrice FROM Products";
            var products = connection.Query<DapperProduct>(query).ToList();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
