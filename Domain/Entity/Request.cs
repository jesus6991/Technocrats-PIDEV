using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public string requested_profil { get; set; }
        public string experience_year { get; set; }
        public string education_scolarity { get; set; }
        //public Project project { get; set; }
        public string manager { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime deposit_date { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime deposit_hour { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Start_date_mandate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime end_date_mandate { get; set; }

        public Client Client { get; set; }
    }
}
