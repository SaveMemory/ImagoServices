using System;
using System.Collections.Generic;
using Imago.Thrash.Dto;

namespace Imago.BusinessLogic.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetAllHiredForUser(Guid id);
    }
}