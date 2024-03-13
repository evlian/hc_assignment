using MediatR;

namespace HellocareAssessment.Model.Posts.GetPosts
{
    public class GetUserFeedPostsQuery : IRequest<GetUserFeedPostsResult>
    {
        public Guid UserId { get; set; }
    }
}
