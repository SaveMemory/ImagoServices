using System;

namespace Imago.BusinessCore.DomainModels
{
    public class Employee : Worker
    {
        public Employee(Guid id, string forename, string surname, int workforce, Guid userId) : base(id, forename, surname, workforce, userId)
        {
        }
    }
}
