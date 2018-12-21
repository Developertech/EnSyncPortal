using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnSyncPortal.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DEPARTMENT_ID { get; set; }
        public string CONTROL_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public DateTime TIME_STAMP { get; set; }
    }
}
