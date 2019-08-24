using Microsoft.Extensions.DependencyInjection;
using SC.Business.Business;
using SC.Business.Interfaces;
using SC.Repository.Interfaces;
using SC.Repository.Repository;
using SC.Services.AutoMapper;
using SC.Services.Interfaces;
using SC.Services.Services;

namespace SC.API.Extensions
{
    public static class DependencyInjection
    {
        public static void DIRegister(this IServiceCollection services)
        {
            var autoMapper = AutoMapperConfig.Register();
            services.AddSingleton(autoMapper.CreateMapper());

            services.AddTransient<IClientServices, ClientServices>();
            services.AddTransient<IAnswerServices, AnswerServices>();
            services.AddTransient<IQuestionServices, QuestionServices>();
            services.AddTransient<IScoreServices, ScoreServices>();

            services.AddTransient<IClientBusiness, ClientBusiness>();
            services.AddTransient<IAnswerBusiness, AnswerBusiness>();
            services.AddTransient<IScoreBusiness, ScoreBusiness>();

            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IAnswerRepository, AnswerRepository>();
            services.AddTransient<IQuestionRepository, QuestionRepository>();
        }
    }
}