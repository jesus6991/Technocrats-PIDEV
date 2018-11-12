using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public String Value { get; set; }

        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }

        public virtual ICollection<RessourceSkill> RessourceSkills { get; set; }
    }
}
