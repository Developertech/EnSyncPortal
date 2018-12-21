using Microsoft.EntityFrameworkCore;

namespace EnSyncPortal.Models.Context
{
    public class EmployeeProfileContext : DbContext
    {
        public EmployeeProfileContext(DbContextOptions<EmployeeProfileContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
    }
}
