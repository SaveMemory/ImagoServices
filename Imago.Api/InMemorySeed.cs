using System;
using System.Collections.Generic;
using Imago.BusinessCore.DomainModels;
using Imago.DataAccess.Database;

namespace Imago.Api
{
    public static class InMemorySeed
    {
        public static void CreateSeed(ImagoContext context)
        {
            var hiredEmployees = new List<Employee>()
            {
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b")),
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b")),
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b")),
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b")),
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b")),
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b")),
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b")),
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b")),
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b")),
                new Employee(new Guid(), "testForename", "testSurname", 5, new Guid("3134d4fc-bb10-4d07-ad3c-3c7d69939d5b"))
            };
            
            context.Employees.AddRange(hiredEmployees);
            context.SaveChanges();
        }
    }
}