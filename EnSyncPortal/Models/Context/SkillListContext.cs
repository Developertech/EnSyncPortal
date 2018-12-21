using Microsoft.EntityFrameworkCore;

namespace EnSyncPortal.Models.Context
{
    public class SkillListContext : DbContext
    {
        public SkillListContext(DbContextOptions<SkillListContext> options)
            : base(options)
        {
        }

        public DbSet<SkillList> SkillLists { get; set; }
    }
}
