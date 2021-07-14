using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Answer.API.Model.Dto
{
    public class ResponseDto
    {
        public bool isSuccess { get; set; } = true;
        public string errorMessage { get; set; }
        public List<AnswerModel> listAnswer { get; set; } = new List<AnswerModel>();
        public AnswerDto listFullAnswer { get; set; }
    }
}
