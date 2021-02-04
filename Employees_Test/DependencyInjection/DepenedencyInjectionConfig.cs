using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Employees_Test.DAL;
using Employees_Test.Repositories;
using Employees_Test.Services;

namespace Employees_Test.DependencyInjection
{
    internal static class DependencyInjectionConfig
    {
        public static IServiceCollection ConfigureDependencies(this IServiceCollection collection, IConfiguration configuration)
        {
            var connectionString = configuration["ConnecstionString"];
            var dbContext = new EmployeesDatabaseContext(connectionString);
            collection.AddTransient<IEmployeesRepository>(x => new EmployeesRepository(dbContext));
            collection.AddSingleton<IEmployeesService, EmployeesService>();
            return collection;
        }
    }
}
