using HellocareAssessment.Core.Data.Configurations.Shared;
using HellocareAssessment.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HellocareAssessment.Core.Data.Configurations
{
    public class AdminEntityTypeConfiguration : BaseEntityTypeConfiguration<Admin>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Admin> builder)
        {
            builder
                .HasOne(x => x.Company)
                .WithMany(x => x.Admins)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
