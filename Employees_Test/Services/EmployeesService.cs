using System;
using Employees_Test.Models;
using Employees_Test.Repositories;

namespace Employees_Test.Services
{
    public class EmployeesService : IEmployeesService
    {
        private IEmployeesRepository EmployeesRepository { get; }

        public EmployeesService(IEmployeesRepository employeesRepository)
        {
            EmployeesRepository = employeesRepository;
        }

        public (bool isSuccess, string errorMessage) AddEmployee(Employee employee)
        {
            var result = this.EmployeesRepository.Add(employee);
            return result ? (true, null) : (false, "something went wrong");
        }

        public (Employee employee, string errorMessage) GetEmployee(string employeeId)
        {
            var employee = this.EmployeesRepository.Get(employeeId);
            return employee != null ? (employee, "") : (null, "something went wrong");
        }

        public (bool isSuccess, string errorMessage) UpdateEmployee(Employee employee) => throw new NotImplementedException();

        public (bool isSuccess, string errorMessage) RemoveEmployee(string employeeId) => throw new NotImplementedException();

        public bool NewFunction(object obj)
        {
            return this.EmployeesRepository.NewFunction(obj);
        }
    }
}