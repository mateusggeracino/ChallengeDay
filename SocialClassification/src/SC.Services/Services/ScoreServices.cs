using AutoMapper;
using SC.Business.Interfaces;
using SC.Services.Interfaces;
using SC.Services.ViewModels.Response;

namespace SC.Services.Services
{
    public class ScoreServices : IScoreServices
    {
        private readonly IMapper _mapper;
        private readonly IScoreBusiness _scoreBusiness;

        public ScoreServices(IScoreBusiness scoreBusiness, IMapper mapper)
        {
            _scoreBusiness = scoreBusiness;
            _mapper = mapper;
        }

        public ScoreResponseViewModel GetScoreClient(int clientId)
        {
            return _mapper.Map<ScoreResponseViewModel>(_scoreBusiness.GetScoreClient(clientId));
        }
    }
}