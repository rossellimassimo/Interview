using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Answer.API.Model
{
    public class AnswerDto
    {
        public int ID { get; set; }
        public int IDCandidate { get; set; }
        public int IDInterview { get; set; }
        public int IDAnswer { get; set; }
        public string AnswerString { get; set; }
    }
}
