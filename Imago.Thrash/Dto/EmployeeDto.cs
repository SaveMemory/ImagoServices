using System;

namespace Imago.Thrash.Dto
{
    public class EmployeeDto
    {
        public Guid Guid { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Workforce { get; set; }
    }
}