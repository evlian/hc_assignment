using HellocareAssessment.Core.Data.Configurations.Shared;
using HellocareAssessment.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HellocareAssessment.Core.Data.Configurations
{
    public class PostEntityTypeConfiguration : BaseEntityTypeConfiguration<Post>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Post> builder)
        {
            builder
                .HasOne(x => x.Company)
                .WithMany(x => x.Posts)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.Product)
                .WithMany(x => x.Posts)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Posts)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
