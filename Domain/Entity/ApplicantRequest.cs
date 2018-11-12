using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public enum ApplicantReqState
    {
        Inprogress,
        Denied,
        Waiting
    }
    public class ApplicantRequest
    {
        [Key]
        public int ApplicantRequestId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime app_req_date { get; set; }
        public string specialty { get; set; }
        public ApplicantReqState app_req_state { get; set; }
        public Applicant Applicant { get; set; }
    }
}
