using AutoMapper;
using SC.Domain.Models;
using SC.Services.ViewModels.Response;

namespace SC.Services.AutoMapper.Profiles
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Client, ClientResponseViewModel>();
            CreateMap<Question, QuestionResponseViewModel>();
            CreateMap<Score, ScoreResponseViewModel>();
        }
    }
}