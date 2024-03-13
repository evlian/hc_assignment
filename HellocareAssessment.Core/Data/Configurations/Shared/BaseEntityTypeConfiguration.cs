using HellocareAssessment.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HellocareAssessment.Core.Data.Configurations.Shared
{
    public abstract class BaseEntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.InsertedAt)
                .HasDefaultValueSql("NOW()")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.InsertedBy)
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .HasDefaultValueSql("NOW()")
                .ValueGeneratedOnUpdate();

            builder.Property(x => x.UpdatedBy)
                .IsRequired(false);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedOnAdd()
                .IsRequired();

            ConfigureEntity(builder);
        }

        protected abstract void ConfigureEntity(EntityTypeBuilder<T> builder);
    }
}
