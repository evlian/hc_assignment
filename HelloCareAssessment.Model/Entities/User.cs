namespace HellocareAssessment.Model.Entities
{
    public class User : BaseEntity
    {
        public required string Name { get; set; }

        public List<User>? FollowedUsers { get; set; }
        public List<Company>? FollowedCompanies { get; set; }
        public List<Product>? FollowedProducts { get; set; }

        public List<Post>? Posts { get; set; }
        public List<User>? Followers { get; set; }
    }
}
