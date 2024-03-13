namespace HellocareAssessment.Model.Dtos
{
    public class PostDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }

        public DateTime InsertedAt { get; set; }
    }
}
