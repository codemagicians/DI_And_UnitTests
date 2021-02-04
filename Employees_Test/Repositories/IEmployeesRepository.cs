using System;
using Employees_Test.Models;

namespace Employees_Test.Repositories
{
    public interface IEmployeesRepository
    {
        bool Add(Employee employee);
        Employee Get(string id);
        bool Update(Employee newEmployeeData);
        bool Remove(string employeeId);

        bool NewFunction(object obj);
    }
}
