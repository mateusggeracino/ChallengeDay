using AutoMapper;
using SC.Domain.Models;
using SC.Services.ViewModels.Request;

namespace SC.Services.AutoMapper.Profiles
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<ClientRequestViewModel, Client>();
            CreateMap<AnswerRequestViewModel, Answer>();
            //CreateMap<QuestionRequestViewModel, Question>();
        }
    }
}