using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose ORM to run:");
        Console.WriteLine("1 - Entity Framework Core");
        Console.WriteLine("2 - Dapper");
        Console.WriteLine("3 - ADO.NET");
        Console.Write("Enter choice: ");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                EfExample.Run();
                break;
            case "2":
                DapperExample.Run();
                break;
            case "3":
                AdoNetExample.Run();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting...");
                break;
        }
    }
}
