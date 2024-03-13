using HellocareAssessment.Model.Entities;

namespace HellocareAssessment.Core.Abstractions.Services.Posts
{
    public interface IFeedService
    {
        List<Post> GetUserFeedPosts(User user);
    }
}
