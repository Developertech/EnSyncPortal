using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnSyncPortal.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EMPLOYEE_ID { get; set; }
        public string CONTROL_ID { get; set; }
        public string SSN { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public DateTime DOB { get; set; }
        public string GENDER { get; set; }
    }
}
