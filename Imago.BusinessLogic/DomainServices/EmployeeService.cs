using System;
using System.Collections.Generic;
using Imago.BusinessLogic.Interfaces;
using Imago.Thrash.Dto;

namespace Imago.BusinessLogic.DomainServices
{
    public class EmployeeService : IEmployeeService
    {
        public IEnumerable<EmployeeDto> GetAllHiredForUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}