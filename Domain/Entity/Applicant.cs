using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public enum ApplicantState
    {
        Applicant,
        Pre_employed,
        Employed,
        Refused
    }
    public class Applicant : Users
    {
        //public int applicantId { get; set; }
        //public string name { get; set; }
        public ApplicantState applicant_state { get; set; }
        //public string Email { get; set; }
        //[ForeignKey("applicantRequest")]
        //public int? ApplicantRequestId { get; set; }
        public ApplicantRequest applicantRequest { get; set; }

        //[ForeignKey("arrival")]
        //public int? ArrivalId { get; set; }

        public virtual ICollection<RDV> RDVs { get; set; }
        public Arrival arrival { get; set; }
        public virtual ICollection<ApplicantAnswer> ApplicantAnswers { get; set; }

        public virtual ICollection<ApplicantRessource> ApplicantRessources { get; set; }
    }
}
