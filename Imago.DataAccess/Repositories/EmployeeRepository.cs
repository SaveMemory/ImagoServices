using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Imago.BusinessCore.DomainModels;
using Imago.DataAccess.Database;
using Imago.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Imago.DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ImagoContext _context;

        public EmployeeRepository(ImagoContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Employee>> GetAllHiredForUser(Guid userId)
        {
            return await _context.Employees.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}