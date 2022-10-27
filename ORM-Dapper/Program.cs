using Dapper;
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

           
            IEnumerable<Department> GetDepartments()
            {
                return conn.Query<Department>("SELECT * from departments;");
            }

            var dRepo = new Department_Repository(conn);

            var departments = GetDepartments();

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
            Console.ReadLine();

            //Successful
        }
    }
}