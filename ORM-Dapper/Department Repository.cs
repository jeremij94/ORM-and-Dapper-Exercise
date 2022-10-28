using System;
using System.Data;
using Dapper;

namespace ORM_Dapper
{
    public class DapperDepartmentRepo : IDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public DapperDepartmentRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM departments;");
        }

        public void InsertDepartment(string newDeptName)
        {
            _connection.Execute("INSERT INTO departments (Name) VALUES (@name);", new { name = newDeptName });
        }

    }
}

