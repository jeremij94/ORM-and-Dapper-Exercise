using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
namespace ORM_Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var connectionString = "Server=localhost;Database=bestbuy;Uid-root;Pwd=password;";

            var conn = new MySqlConnection(connectionString);

            IEnumerable<Department> GetDepartments()
            {
                return conn.Query<Department>("SELECT * from departments;");
            }
        }
    }
}