using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imago.BusinessCore.DomainModels;
using Imago.DataAccess.Database;
using Imago.DataAccess.Repositories.Read.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Imago.DataAccess.Repositories.Read
{
    public class EmployeeReadRepository : IEmployeeReadRepository
    {
        private readonly ImagoContext _context;

        public EmployeeReadRepository(ImagoContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Employee>> GetAllEmployeesForUserAsync(Guid userId)
        {
            return await _context.Employees.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}