using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        // [Required(ErrorMessage = "answer is required")]
        // [StringLength(50, MinimumLength = 3,
        //ErrorMessage = "Name Should be minimum 3 characters and a maximum of 100 characters")]
        public string answer { get; set; }
        public int questionId { get; set; }

        public Question question { get; set; }
    }
}
