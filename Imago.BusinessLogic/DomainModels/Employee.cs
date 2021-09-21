using System;

namespace Imago.BusinessLogic.DomainModels
{
    public class Employee
    {
        public Guid Guid { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Workforce { get; set; }
        public Guid UserId { get; set; }

        public Employee(Guid guid, string forename, string surname, int workforce)
        {
            Guid = guid;
            Forename = forename;
            Surname = surname;
            Workforce = workforce;
        }
    }
}