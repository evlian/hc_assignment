using HellocareAssessment.Core.Configurations;

namespace HellocareAssessment.Api.Extensions
{
    public static class MediatrExtensions
    {
        public static void AddMediatr(this IServiceCollection services)
        {
            var assemblyApp = typeof(Program).Assembly;
            var assemblyCore = typeof(DatabaseConfiguration).Assembly;

            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblies(assemblyApp, assemblyCore);
            });
        }
    }
}
