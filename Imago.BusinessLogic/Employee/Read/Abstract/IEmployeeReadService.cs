using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Imago.Thrash.Dto;

namespace Imago.BusinessLogic.Employee.Read.Abstract
{
    public interface IEmployeeReadService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesForUserAsync(Guid userId);
    }
}