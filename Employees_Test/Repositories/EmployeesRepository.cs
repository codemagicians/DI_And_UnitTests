using System;
using Employees_Test.DAL;
using Employees_Test.Models;

namespace Employees_Test.Repositories
{
    public sealed class EmployeesRepository : IEmployeesRepository
    {
        private readonly EmployeesDatabaseContext _dbContext;

        public EmployeesRepository(EmployeesDatabaseContext databaseContext) => _dbContext = databaseContext;

        public bool Add(Employee employee) => this._dbContext.Add(employee);

        public Employee Get(string id) => this._dbContext.Get(id);

        public bool Update(Employee newEmployeeData) => this._dbContext.Update(newEmployeeData);

        public bool Remove(string employeeId) => this._dbContext.Remove(employeeId);

        public bool NewFunction(object obj) => true;
    }
}