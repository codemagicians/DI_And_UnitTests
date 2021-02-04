using System;
using Employees_Test.Models;

namespace Employees_Test.Services
{
    public interface IEmployeesService
    {
        (bool isSuccess, string errorMessage) AddEmployee(Employee employee);
        (Employee employee, string errorMessage) GetEmployee(string employeeId);
        (bool isSuccess, string errorMessage) UpdateEmployee(Employee employee);
        (bool isSuccess, string errorMessage) RemoveEmployee(string employeeId);

        bool NewFunction(object obj);
    }
}
