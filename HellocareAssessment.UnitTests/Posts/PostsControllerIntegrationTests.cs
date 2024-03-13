using HellocareAssessment.Api;
using HellocareAssessment.Model.Posts.GetPosts;
using Newtonsoft.Json;

namespace HellocareAssessment.Tests
{
    public class RegisterControllerIntegrationTests : IClassFixture<TestingWebAppFactory<Program>>
    {
        private readonly HttpClient _client;

        public RegisterControllerIntegrationTests(TestingWebAppFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetUserFeed_WithNonExistantUserId_ShouldReturnNotFound()
        {
            // Arrange
            var getRequest = new HttpRequestMessage(HttpMethod.Get, "/posts/user/feed");
            getRequest.Headers.Add("UserId", Guid.NewGuid().ToString());
            // Act
            var response = await _client.SendAsync(getRequest);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task GetUserFeed_WithExistingUserId_ShouldReturnOK()
        {
            // Arrange
            var getRequest = new HttpRequestMessage(HttpMethod.Get, "/posts/user/feed");
            getRequest.Headers.Add("UserId", "11111111-1111-1111-1111-111111111113");
            // Act
            var response = await _client.SendAsync(getRequest);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetUserFeed_WithExistingUserId_ShouldReturnDescendinglyOrderedPosts()
        {
            // Arrange
            var getRequest = new HttpRequestMessage(HttpMethod.Get, "/posts/user/feed");
            getRequest.Headers.Add("UserId", "11111111-1111-1111-1111-111111111113");
            // Act
            var response = await _client.SendAsync(getRequest);
            var model = JsonConvert.DeserializeObject<GetUserFeedPostsResult>(await response.Content.ReadAsStringAsync());
            var expectedList = model.Posts.OrderByDescending(p => p.InsertedAt).ToList();

            // Assert
            Assert.True(expectedList.SequenceEqual(model.Posts));
        }

        [Fact]
        public async Task GetUserFeed_WithExistingUserId_ShouldReturnDistinctPosts()
        {
            // Arrange
            var getRequest = new HttpRequestMessage(HttpMethod.Get, "/posts/user/feed");
            getRequest.Headers.Add("UserId", "11111111-1111-1111-1111-111111111113");
            // Act
            var response = await _client.SendAsync(getRequest);
            var model = JsonConvert.DeserializeObject<GetUserFeedPostsResult>(await response.Content.ReadAsStringAsync());
            var expectedList = model.Posts.OrderByDescending(p => p.InsertedAt).Distinct().ToList();

            // Assert
            Assert.True(expectedList.SequenceEqual(model.Posts.OrderByDescending(p => p.InsertedAt)));
        }

        [Fact]
        public async Task GetUserFeed_WithUserThatWorksInCompany_ShoudlReturnCompanyPosts()
        {
            //implement
            Assert.True(true);
        }

        [Fact]
        public async Task GetUserFeed_WithUserThatFollowsUser_ShoudlReturnUserPosts()
        {
            //implement
            Assert.True(true);
        }

        [Fact]
        public async Task GetUserFeed_WithUserThatFollowsProduct_ShoudlReturnProductPosts()
        {
            //implement
            Assert.True(true);
        }

        [Fact]
        public async Task GetUserFeed_WithUserThatDoesNotWorkOrFollowCompany_ShouldNotReturnCompanyPosts()
        {
            //implement
            Assert.True(true);
        }

        [Fact]
        public async Task GetUserFeed_WithUserThatDoesNotFollowUser_ShouldNotReturnUserPosts()
        {
            //implement
            Assert.True(true);
        }

        [Fact]
        public async Task GetUserFeed_WithUserThatDoesNotFollowProduct_ShouldNotReturnProductPosts()
        {
            //implement
            Assert.True(true);
        }
    }
}
