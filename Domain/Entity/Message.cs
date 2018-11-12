using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime SentDate { get; set; }
        public string Object { get; set; }

        public Discussion Discussion { get; set; }
    }
}
