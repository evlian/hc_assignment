using HellocareAssessment.Core.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace HellocareAssessment.Core.Data
{
    public class DataInitializer
    {
        private readonly MainDbContext _dbContext;

        public DataInitializer(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void EnsureMigrated()
        {
            _dbContext.Database.Migrate();
        }
    }
}
