using Microsoft.EntityFrameworkCore;

namespace EnSyncPortal.Models.Context
{
    public class EmployeeContactContext : DbContext
    {
        public EmployeeContactContext(DbContextOptions<EmployeeContactContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeContact> EmployeeContacts { get; set; }
    }
}
