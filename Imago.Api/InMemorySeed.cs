using System;
using System.Collections.Generic;
using Imago.BusinessLogic.DomainModels;
using Imago.DataAccess.Database;

namespace Imago.Api
{
    public static class InMemorySeed
    {
        public static void CreateSeed(ImagoContext context)
        {
            var employees = new List<Employee>()
            {
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
                new Employee(new Guid(), "testForename", "testSurname", 5),
            };
            
            context.Employees.AddRange(employees);
        }
    }
}