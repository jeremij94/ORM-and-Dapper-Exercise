using System;
using System.Data;
using Dapper;

namespace ORM_Dapper
{
    public class Department_Repository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public Department_Repository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM departments;");
        }

        public void InsertDepartment(string newDeptName)
        {
            _connection.Execute("INSERT INTO departments (Name) VALUES (@name);", new { name = newDeptName });
        }

    }
}

