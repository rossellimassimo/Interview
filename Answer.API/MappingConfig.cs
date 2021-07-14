using AutoMapper;
using Answer.API.Model.Dto;
using Answer.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Answer.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Model.AnswerDto, Model.Dto.Answer>();
                config.CreateMap<Model.Dto.Answer, Model.AnswerDto>();
            });

            return mappingConfig;
        }
    }
}
