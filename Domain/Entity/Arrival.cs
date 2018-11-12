using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Arrival
    {
        [Key]
        public int ArrivalId { get; set; }
        public int ApplicantId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateArrival { get; set; }

        public Applicant Applicant { get; set; }
    }
}
