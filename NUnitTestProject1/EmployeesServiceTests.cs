using AutoFixture;
using Moq;
using NUnit.Framework;
using Employees_Test.Models;
using Employees_Test.Repositories;
using Employees_Test.Services;

namespace NUnitTestProject1
{
    public class EmployeesServiceTests
    {
        private readonly Fixture _fixture;
        private readonly Mock<IEmployeesRepository> _employeesRepository;
        private readonly EmployeesService _employeesService;

        public EmployeesServiceTests()
        {
            _fixture = new Fixture();
            _employeesRepository = new Mock<IEmployeesRepository>();
            _employeesService = new EmployeesService(_employeesRepository.Object);
        }

        [Test]
        public void WhenAddCalled_CallsRepository_AndReturnsCorrectResult()
        {
            // Arrange
            Employee employee = _fixture.Create<Employee>();
            _employeesRepository.Setup(r => r.Add(employee)).Returns(true);

            // Act
            (bool isSuccess, string errorMessage) result = _employeesService.AddEmployee(employee);

            // Assert
            _employeesRepository.Verify(r => r.Add(employee));
            Assert.That(result.isSuccess);
        }

        [Test]
        public void WhenNewFunction_CallsRepository_AndReturnsCorrectResult()
        {
            // Arrange
            Employee employee = _fixture.Create<Employee>();
            _employeesRepository.Setup(r => r.Add(employee)).Returns(true);

            // Act
            (bool isSuccess, string errorMessage) result = _employeesService.AddEmployee(employee);

            // Assert
            _employeesRepository.Verify(r => r.Add(employee));
            Assert.That(result.isSuccess);
        }

        [Test]
        public void WhenGet_CallsRepository_AndReturnsCorrectResult()
        {
            var employee = _fixture.Create<Employee>();
            _employeesRepository.Setup(r => r.NewFunction(employee)).Returns(true);

            bool result = _employeesService.NewFunction(employee);

            _employeesRepository.Verify(r => r.NewFunction(employee));
            Assert.That(result, Is.True);
        }
    }
}