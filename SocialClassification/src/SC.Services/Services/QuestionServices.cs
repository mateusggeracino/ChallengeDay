using System.Collections.Generic;
using AutoMapper;
using SC.Repository.Interfaces;
using SC.Services.Interfaces;
using SC.Services.ViewModels.Response;

namespace SC.Services.Services
{
    public class QuestionServices : IQuestionServices
    {
        private readonly IMapper _mapper;
        private readonly IQuestionRepository _questionRespository;

        public QuestionServices(IMapper mapper, IQuestionRepository questionRespository)
        {
            _mapper = mapper;
            _questionRespository = questionRespository;
        }


        public IEnumerable<QuestionResponseViewModel> GetAll()
        {
            var result = _questionRespository.GetAll();
            return _mapper.Map<IEnumerable<QuestionResponseViewModel>>(result);
        }
    }
}