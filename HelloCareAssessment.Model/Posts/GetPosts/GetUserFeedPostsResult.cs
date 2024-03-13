using HellocareAssessment.Model.Dtos;
using MediatR;

namespace HellocareAssessment.Model.Posts.GetPosts
{
    public class GetUserFeedPostsResult
    {
        public List<PostDto> Posts { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
