using HellocareAssessment.Core.Data;
using HellocareAssessment.Core.Data.Contexts;

namespace HellocareAssessment.Api.Extensions
{
    public static class HostExtension
    {
        public static IHost Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();

            var dbContext = scope.ServiceProvider.GetRequiredService<MainDbContext>();
            var dataInitializer = new DataInitializer(dbContext);
            dataInitializer.EnsureMigrated();

            return host;
        }
    }
}
