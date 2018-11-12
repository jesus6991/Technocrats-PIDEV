using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public enum ProjectState
    {
        New,
        inprogress,
        finished

    }
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public String Project_name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Start_date { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime end_date { get; set; }
        public String Adress { get; set; }
        public int Total_number_ressource { get; set; }
        public int Levio_number_ressource { get; set; }
        public ProjectState project_state { get; set; }

        public virtual ICollection<OrganizationChart> OrganizationCharts { get; set; }
        public virtual ICollection<ProjectSkill> ProjectSkills { get; set; }
        public virtual ICollection<Mandate> Mandates { get; set; }
    }
}
