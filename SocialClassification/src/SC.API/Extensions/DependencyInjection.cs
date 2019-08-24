using Microsoft.Extensions.DependencyInjection;
using SC.Services.AutoMapper;

namespace SC.API.Extensions
{
    public static class DependencyInjection
    {
        public static void DIRegister(this IServiceCollection services)
        {
            var autoMapper = AutoMapperConfig.Register();

            services.AddSingleton(autoMapper.CreateMapper());
        }
    }
}