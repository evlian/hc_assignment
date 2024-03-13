namespace HellocareAssessment.Model.Entities
{
    public class Admin : BaseEntity
    {
        public User User { get; set; }
        public Company Company { get; set; }
    }
}
