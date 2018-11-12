using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class MandateHistory
    {
        [Key]
        public int MandatehistoryId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime saveDate { get; set; }
        [ForeignKey("mandate")]
        public int MandateId { get; set; }
        public int RessourceId { get; set; }
        public int ProjectId { get; set; }


        public Mandate mandate { get; set; }
    }
}
