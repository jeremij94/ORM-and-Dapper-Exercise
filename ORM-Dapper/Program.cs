using System;
using Dapper;
using Internal;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
namespace ORM_Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

            var connectString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connectString);

            /* var dRepo = new DapperDepartmentRepo(conn);
            var departments = dRepo.GetAllDepartments();

            foreach (var department in departments)
            {
                Console.WriteLine($"{department.DepartmentID} {department.Name}");
                Console.WriteLine();
            }
            Console.ReadLine();

            //Placed a console read to test as a before/after to see if "vintage" was added.
            
            dRepo.InsertDepartment("Vintage");

            foreach (var department in departments)
            {
                Console.WriteLine($"{department.DepartmentID} {department.Name}");
                Console.WriteLine();
            }
            Console.ReadLine(); */

            //Successful

            //Commented Above Code Out since successful

            var dProductRepo = new DapperProductRepo(conn);
            var products = dProductRepo.GetAllProducts();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID} {product.Name} {product.Price}");
                Console.WriteLine();
            }

            Console.ReadLine();

           /* Console.WriteLine("Input new product name: ");
            var newProdName = Console.ReadLine();


            Console.WriteLine("Input new product price: ");
            double newProdPrice = Console.ReadLine();


            Console.WriteLine(Input new CategoryID);
            var newProdCatID = int.Parse(Console.ReadLine());

            dProductRepo.CreateNewProduct(newProdCatID, newProdName, newProdPrice);

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID} {product.Name} {product.Price}");
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}