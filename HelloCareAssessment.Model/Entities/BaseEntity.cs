namespace HellocareAssessment.Model.Entities
{
    public class BaseEntity
    {
        public required Guid Id { get; set; }

        public required Guid InsertedBy { get; set; }
        public DateTime InsertedAt { get; set; }

        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}
