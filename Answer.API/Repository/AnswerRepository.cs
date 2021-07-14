using Answer.API.Data;
using Answer.API.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Answer.API.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public AnswerRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public async Task<AnswerDto> AddAnswers(AnswerDto answerDto)
        {
            Model.Dto.Answer answer = _mapper.Map<AnswerDto, Model.Dto.Answer>(answerDto);
            _db.Answer.Add(answer);
            await _db.SaveChangesAsync();

            return _mapper.Map<Model.Dto.Answer, AnswerDto>(answer);
        }

        public async Task<List<AnswerDto>> GetAnswers(int candidateId, int interviewId)
        {
            List<Model.Dto.Answer> listAnswer = await _db.Answer.Where(el => el.IDCandidate == candidateId && el.IDInterview == interviewId).ToListAsync();
            return _mapper.Map<List<AnswerDto>>(listAnswer);
        }
    }
}
