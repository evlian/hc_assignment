using HellocareAssessment.Core.Data.Configurations.Shared;
using HellocareAssessment.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HellocareAssessment.Core.Data.Configurations
{
    public class ProductEntityTypeConfiguration : BaseEntityTypeConfiguration<Product>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasOne(x => x.ParentCompany)
                .WithMany(x => x.Products)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(x => x.Followers)
                .WithMany(x => x.FollowedProducts);

            builder
                .HasMany(x => x.Posts)
                .WithOne(x => x.Product)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
