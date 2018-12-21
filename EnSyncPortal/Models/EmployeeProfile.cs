using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnSyncPortal.Models
{
    public class EmployeeProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EMPLOYEE_PROFILE_ID { get; set; }
        public string CONTROL_ID { get; set; }
        public long EMPLOYEE_ID { get; set; }
        public long DEPARTMENT_ID { get; set; }
        public long PROJECT_ID { get; set; }
        public DateTime HIRE_DATE { get; set; }
        public float SALARY_AMOUNT { get; set; }
        public string COUNTRY { get; set; }
        public string EMPLOYMENT_TYPE { get; set; }
        public DateTime TIME_STAMP { get; set; }
    }
}
