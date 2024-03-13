using HellocareAssessment.Core.Data.Configurations.Shared;
using HellocareAssessment.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HellocareAssessment.Core.Data.Configurations
{
    public class UserEntityTypeConfiguration : BaseEntityTypeConfiguration<User>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<User> builder)
        {
            builder
                .HasMany(x => x.FollowedCompanies)
                .WithMany(x => x.Followers);

            builder
                .HasMany(x => x.FollowedUsers)
                .WithMany(x => x.Followers);

            builder
                .HasMany(x => x.FollowedProducts)
                .WithMany(x => x.Followers);

            builder
                .HasMany(x => x.Posts)
                .WithOne(x => x.User)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
