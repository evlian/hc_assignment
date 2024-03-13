using HellocareAssessment.Core.Data.Configurations.Shared;
using HellocareAssessment.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HellocareAssessment.Core.Data.Configurations
{
    public class CompanyEntityTypeConfiguration : BaseEntityTypeConfiguration<Company>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Company> builder)
        {
            builder
                .HasMany(x => x.Employees)
                .WithOne(x => x.Company)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(x => x.Followers)
                .WithMany(x => x.FollowedCompanies);

            builder
                .HasMany(x => x.Posts)
                .WithOne(x => x.Company)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
