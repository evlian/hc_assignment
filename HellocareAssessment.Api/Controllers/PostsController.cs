using HellocareAssessment.Model.Posts.GetPosts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HellocareAssessment.Api.Controllers
{
    [ApiController]
    [Route("posts")]
    public class PostsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("user/feed")]
        public async Task<ActionResult<GetUserFeedPostsResult>> GetUserFeedPostsAsync([FromHeader] Guid userId)
        {
            var getUserFeedQuery = new GetUserFeedPostsQuery
            {
                UserId = userId,
            };

            var getPostsResult = await _mediator.Send(getUserFeedQuery);
            if (getPostsResult.ErrorMessage != null)
                return NotFound(getPostsResult); // should implement exception middleware

            return Ok(getPostsResult);
        }
    }
}
