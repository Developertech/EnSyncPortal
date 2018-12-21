using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnSyncPortal.Models
{
    public class SkillList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SKILL_ID { get; set; }
        public string SKILL_NAME { get; set; }
        public string SKILL_DESCRIPTION { get; set; }
    }
}
