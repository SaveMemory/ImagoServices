using System;

namespace Imago.BusinessCore.DomainModels
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Workforce { get; set; }
        public Guid UserId { get; set; }

        public Employee(Guid id, string forename, string surname, int workforce, Guid userId)
        {
            Id = id;
            Forename = forename;
            Surname = surname;
            Workforce = workforce;
            UserId = userId;
        }
    }
}