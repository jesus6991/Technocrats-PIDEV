using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public enum LeaveType
    {
        Maternity, Vacation, Disease
    }
    public  class Leave
    {
        public int LeaveId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Start_date { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime D_date { get; set; }
        public LeaveType Type_leave { get; set; }

        public Ressource Ressource { get; set; }

    }
}
