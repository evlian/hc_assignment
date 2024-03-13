using AutoMapper;
using HellocareAssessment.Core.Mappings.Posts;

namespace HellocareAssessment.Api.Extensions
{
    public static class MapperExtensions
    {
        public static void AddMappingWithProfiles(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<PostMappings>();
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
