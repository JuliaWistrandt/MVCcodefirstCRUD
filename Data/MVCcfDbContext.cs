using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MVCcodeFirstCRUID.Models.Domain;

namespace MVCcodeFirstCRUID.Data
{
    public class MVCcfDbContext : DbContext
    {
        public MVCcfDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
