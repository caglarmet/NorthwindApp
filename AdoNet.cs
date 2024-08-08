using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using NorthwindApp.Models;

public class AdoNetExample
{
    public static void Run()
    {
        string connectionString = "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;";

        List<Product> products = new List<Product>();

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Products";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var product = new Product
                {
                    ProductId = (int)reader["ProductID"],
                    ProductName = (string)reader["ProductName"],
                    //UnitPrice = reader["UnitPrice"] != DBNull.Value ? (decimal)reader["UnitPrice"] : 0,
                    //UnitsInStock = reader["UnitsInStock"] != DBNull.Value ? (short)reader["UnitsInStock"] : (short)0
                };
                products.Add(product);
            }
        }

        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
