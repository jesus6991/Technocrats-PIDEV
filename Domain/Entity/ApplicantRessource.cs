using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ApplicantRessource
    {
        [Key]
        public int AppResId { get; set; }

        [ForeignKey("ressource")]
        public int? ressourceId { get; set; }
        public Ressource ressource{ get; set; }

        [ForeignKey("applicant")]
        public int? applicantId { get; set; }
        public Applicant applicant{ get; set; }
    }
}
