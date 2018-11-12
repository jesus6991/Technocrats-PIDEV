using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ApplicantAnswer
    {
        [Key]
        public int app_answerId { get; set; }
        public int applicantId { get; set; }
        public int questionId { get; set; }

        public Applicant applicant { get; set; }
        public Question question { get; set; }
    }
}
