using Microsoft.EntityFrameworkCore;

namespace EnSyncPortal.Models.Context
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext(DbContextOptions<DepartmentContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
    }
}
