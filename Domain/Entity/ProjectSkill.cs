using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ProjectSkill
    {
        public int ProjectSkillId { get; set; }

        public Skill Skill { get; set; }

        public Project Project { get; set; }
    }
}
