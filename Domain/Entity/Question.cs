using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Question
    {
        [Key]
        public int questionId { get; set; }
        public string question { get; set; }
        public int id_correct_answer { get; set; }
        public string category { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public Applicant applicant { get; set; }
    }
}
