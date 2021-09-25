using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Imago.BusinessCore.DomainModels;

namespace Imago.DataAccess.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllHiredForUser(Guid userId);
    }
}