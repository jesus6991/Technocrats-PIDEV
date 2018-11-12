using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class RessourceSkill
    {
        [Key]
        public int RSId { get; set; }

        public Skill Skill { get; set; }
        public Ressource Ressource { get; set; }
    }
}
