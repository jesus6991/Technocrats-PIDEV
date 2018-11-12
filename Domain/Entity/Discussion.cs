using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Discussion
    {
        [Key]
        public int DiscId { get; set; }
        //public int SenderId { get; set; }
        //public int ReceiverId { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        [ForeignKey("client")]
        public int? clientId { get; set; }
        public Client client { get; set; }

        [ForeignKey("ressource")]
        public int? ressourceId { get; set; }
        public Ressource ressource { get; set; }
    }
}
