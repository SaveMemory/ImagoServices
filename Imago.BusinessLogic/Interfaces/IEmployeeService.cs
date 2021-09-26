using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Imago.Thrash.Dto;

namespace Imago.BusinessLogic.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllHiredForUser(Guid userId);
        Task<IEnumerable<EmployeeDto>> GetAllEmployableForUser(Guid userId);
    }
}