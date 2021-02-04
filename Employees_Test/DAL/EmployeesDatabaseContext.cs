using System;
using System.Collections.Concurrent;
using Employees_Test.Models;

namespace Employees_Test.DAL
{
    public class EmployeesDatabaseContext
    {
        private ConcurrentDictionary<string, Employee> Values  { get; } = new ConcurrentDictionary<string, Employee>();
        private readonly string _connectionString;

        public EmployeesDatabaseContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public bool Add(Employee employee) => Values.TryAdd(employee.Id, employee);
        public Employee Get(string id) => Values.TryGetValue(id, out var employee) ? employee : null;
        public bool Update(Employee employee) => (Values.ContainsKey(employee.Id) ? (Values[employee.Id] = employee) : null) != null;
        public bool Remove(string employeeId) => Values.TryRemove(employeeId, out _);
    }
}
