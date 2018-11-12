using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public enum StateR
    {
        Accepted, unaccepted, pending
    }
    public class RDV
    {
        [Key]
        public int RdvId { get; set; }
        public int ApplicantId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateRdv { get; set; }
        public StateR StateRdv { get; set; }

        public Applicant Applicant { get; set; }
    }
}
