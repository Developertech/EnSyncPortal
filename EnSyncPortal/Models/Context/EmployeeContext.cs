using Microsoft.EntityFrameworkCore;
using System;

namespace EnSyncPortal.Models.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EMPLOYEE_ID = 1,
                CONTROL_ID = "DEV",
                FIRST_NAME = "Tzain",
                LAST_NAME = "Adebola",
                DOB = new DateTime(1990,01,01),
                GENDER = "M",
                SSN = "100101000"

            }, new Employee
            {
                EMPLOYEE_ID = 2,
                CONTROL_ID = "DEV",
                FIRST_NAME = "Zelie",
                LAST_NAME = "Adebola",
                DOB = new DateTime(1990, 01, 01),
                GENDER = "F",
                SSN = "100101001"
            });
        }
    }
}
