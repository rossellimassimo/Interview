using Answer.API.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Answer.API.Repository
{
    public interface IAnswerRepository
    {
        Task<List<Model.AnswerDto>> GetAnswers(int candidateId, int interviewId);
        Task<Model.AnswerDto> AddAnswers(Model.AnswerDto anwerDto);
    }
}
