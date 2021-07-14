using Answer.API.Model;
using Answer.API.Model.Dto;
using Answer.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Answer.API.Controllers
{
    [Route("api/answers")]
    public class AnswerAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private IAnswerRepository _answerRepository;

        public AnswerAPIController(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
            this._response = new ResponseDto();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                List<AnswerDto> answerDtos = await _answerRepository.GetAnswers(1, 1);

                foreach(var answer in answerDtos)
                {
                    _response.listAnswer.Add(new AnswerModel()
                    {
                        IDAnswer = answer.IDAnswer,
                        AnswerString = answer.AnswerString
                    });
                }
            }
            catch(Exception ex)
            {
                _response.isSuccess = false;
                _response.errorMessage = ex.Message.ToString();
            }

            return _response;
        }

        [HttpPost]
        public async Task<object> Post([FromBody]Model.AnswerDto answerDto)
        {
            try
            {
                AnswerDto answerDtos = await _answerRepository.AddAnswers(answerDto);
                _response.listFullAnswer = answerDto;                
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.errorMessage = ex.Message.ToString();
            }

            return _response;
        }
    }
}
