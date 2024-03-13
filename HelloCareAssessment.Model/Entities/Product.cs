namespace HellocareAssessment.Model.Entities
{
    public class Product : BaseEntity
    {
        public required Company ParentCompany { get; set; }
        public required string Name { get; set; }

        public List<Post>? Posts { get; set; }
        public List<User>? Followers { get; set; }
    }
}
