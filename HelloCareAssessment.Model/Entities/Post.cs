namespace HellocareAssessment.Model.Entities
{
    public class Post : BaseEntity
    {
        public string? Content { get; set; }

        public Company? Company { get; set; }
        public Product? Product { get; set; }
        public User? User { get; set; }
    }
}
