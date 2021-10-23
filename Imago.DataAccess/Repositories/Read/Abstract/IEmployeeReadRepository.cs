using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Imago.BusinessCore.DomainModels;

namespace Imago.DataAccess.Repositories.Read.Abstract
{
    public interface IEmployeeReadRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesForUserAsync(Guid userId);
    }
}