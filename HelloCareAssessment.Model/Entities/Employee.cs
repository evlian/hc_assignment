namespace HellocareAssessment.Model.Entities
{
    public class Employee : BaseEntity
    {
        public required User User { get; set; }
        public required Company Company { get; set; }
    }
}
