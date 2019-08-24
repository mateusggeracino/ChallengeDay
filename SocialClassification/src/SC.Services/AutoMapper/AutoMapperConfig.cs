using AutoMapper;
using SC.Services.AutoMapper.Profiles;

namespace SC.Services.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration Register()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile<DomainToViewModel>();
                config.AddProfile<ViewModelToDomain>();
            });
        }
    }
}
