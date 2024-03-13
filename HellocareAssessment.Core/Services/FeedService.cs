using HellocareAssessment.Core.Abstractions.Services.Posts;
using HellocareAssessment.Core.Data.Contexts;
using HellocareAssessment.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace HellocareAssessment.Core.Services
{
    public class FeedService : IFeedService
    {
        private readonly MainDbContext _dbContext;

        public FeedService(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Post> GetUserFeedPosts(User user)
        {
            var userCompanies = _dbContext.Employees
                .Where(x => x.User == user)
                .Select(x => x.Company)
                .ToList();

            return _dbContext.Posts
                .Where(x => user.FollowedCompanies.Contains(x.Company)
                         || user.FollowedProducts.Contains(x.Product)
                         || user.FollowedUsers.Contains(x.User)
                         || userCompanies.Contains(x.Company))
                .OrderByDescending(x => x.InsertedAt)
                .ToList();
        }
    }
}
