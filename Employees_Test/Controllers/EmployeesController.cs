using System;
using Employees_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Employees_Test.Services;

namespace Employees_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeeService;

        public EmployeesController(IEmployeesService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var (isSuccess, errorMessage) = _employeeService.AddEmployee(employee);
            return isSuccess ? (IActionResult)Ok(new { success = true }) : Ok(new { errorMessage });
        }

        [HttpGet]
        public IActionResult Get(string id)
        {
            var (employee, errorMessage) = _employeeService.GetEmployee(id);
            return employee != null ? (IActionResult)Ok(new { success = true }) : Ok(new { success = false, errorMessage });
        }
    }
}
