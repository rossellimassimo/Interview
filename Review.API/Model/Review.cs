using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Review.API.Model
{
    public class Review
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
        [Required]
        public bool isCorrect { get; set; }

    }
}
