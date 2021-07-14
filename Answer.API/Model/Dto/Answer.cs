using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Answer.API.Model.Dto
{
    public class Answer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int IDCandidate { get; set; }
        [Required] 
        public int IDInterview { get; set; }
        [Required]
        public int IDAnswer { get; set; }
        [Required]
        public string AnswerString { get; set; }

    }
}
