using Imago.BusinessCore.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Imago.DataAccess.Database
{
    public class ImagoContext : DbContext
    {
        public ImagoContext(DbContextOptions<ImagoContext> options)
            : base(options)
        { }
        public DbSet<Employee> Employees { get; set; }
    }
}