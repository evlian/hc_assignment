namespace HellocareAssessment.Model.Entities
{
    public class Company : BaseEntity
    {
        public required string Name { get; set; }

        public List<Admin> Admins { get; set; }
        public List<Product>? Products { get; set; }
        public List<Employee>? Employees { get; set; }

        public List<Post>? Posts { get; set; }
        public List<User>? Followers { get; set; }
    }
}
