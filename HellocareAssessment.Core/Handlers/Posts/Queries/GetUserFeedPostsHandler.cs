using AutoMapper;
using HellocareAssessment.Core.Abstractions.Services.Posts;
using HellocareAssessment.Core.Data.Contexts;
using HellocareAssessment.Model.Dtos;
using HellocareAssessment.Model.Posts.GetPosts;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HellocareAssessment.Core.Handlers.Posts.Queries
{
    public class GetUserFeedPostsHandler : IRequestHandler<GetUserFeedPostsQuery, GetUserFeedPostsResult>
    {
        private readonly IFeedService _feedService;
        private readonly MainDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetUserFeedPostsHandler(
            IFeedService feedService,
            MainDbContext dbContext,
            IMapper mapper)
        {
            _feedService = feedService;
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<GetUserFeedPostsResult> Handle(GetUserFeedPostsQuery request, CancellationToken cancellationToken)
        {
            var user = await _dbContext
                .Users
                .Include(x => x.FollowedCompanies)
                .Include(x => x.FollowedProducts)
                .Include(x => x.FollowedUsers)
                .FirstOrDefaultAsync(x => x.Id == request.UserId);

            if (user == null)
            {
                return new()
                {
                    ErrorMessage = "User not found"
                }; // should implement exception middleware
            }

            var userFeedPosts = _feedService.GetUserFeedPosts(user);

            var result = new GetUserFeedPostsResult();

            var posts = new List<PostDto>();

            foreach (var postEntity in userFeedPosts)
            { 
                var postDto = _mapper.Map<PostDto>(postEntity);
                postDto.AuthorName = 
                    postEntity.User?.Name
                    ?? postEntity.Product?.Name
                    ?? postEntity.Company?.Name
                    ?? "";

                posts.Add(postDto);
            }

            result.Posts = posts;

            return result;
        }
    }
}
