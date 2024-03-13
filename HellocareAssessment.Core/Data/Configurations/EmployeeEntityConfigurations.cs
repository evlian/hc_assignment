using HellocareAssessment.Core.Data.Configurations.Shared;
using HellocareAssessment.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HellocareAssessment.Core.Data.Configurations
{
    public class EmployeeEntityTypeConfiguration : BaseEntityTypeConfiguration<Employee>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasOne(x => x.Company)
                .WithMany(x => x.Employees)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
