using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public  class Mandate
    {
        [Key]
        public int MandateId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Start_date { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime end_date { get; set; }
        public float fee { get; set; }
        public int nb_task_Todo { get; set; }
        public int nb_task_done { get; set; }


        public Project project { get; set; }
        public Ressource ressource { get; set; }
    }
}
