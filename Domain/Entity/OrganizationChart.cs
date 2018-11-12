using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class OrganizationChart
    {
        [Key]
        public string directional_level { get; set; }
        public string program_name { get; set; }
        public string project_responsable { get; set; }
        public string client_name { get; set; }
        public string account_manager { get; set; }
        public string name_assignement_manager_client { get; set; }

        public Client Client { get; set; }

        public Ressource Ressource { get; set; }

        public Project Project { get; set; }
    }
}
