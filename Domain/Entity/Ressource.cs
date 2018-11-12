using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domain.Entity
{
    public enum RessourceType
    {
        Freelancer, Employe
    }
    public enum AvailibilityType
    {
        Available, Unavailable, Available_soon
    }
    public class Ressource:Users
    {
        public string Contrat_type { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Seniorty { get; set; }
        public string Work_profil { get; set; }
        public string Note { get; set; }
        public String File { get; set; }
        public RessourceType Ressource_type { get; set; }
        public AvailibilityType Avaibility { get; set; }
        public float Salary { get; set; }
        public string Sector { get; set; }
        //public string Email { get; set; }

        public virtual ICollection<Leave> Leaves { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
        public virtual ICollection<OrganizationChart> OrganizationCharts { get; set; }
        public virtual ICollection<RessourceSkill> RessourceSkills { get; set; }
        public virtual ICollection<Mandate> Mandates { get; set; }
        public virtual ICollection<ApplicantRessource> ApplicantRessources { get; set; }



    }
}