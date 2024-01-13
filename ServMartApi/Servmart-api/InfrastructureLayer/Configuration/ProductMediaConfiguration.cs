using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Configuration
{
    public class ProductMediaConfiguration : IEntityTypeConfiguration<ProductMedia>
    {
        public void Configure(EntityTypeBuilder<ProductMedia> builder)
        {
            builder.ToTable("ProductMedia", "Product");
            builder.HasKey(m => m.ID);
            builder.Property(m => m.MeadiUrl).HasMaxLength(250).IsRequired();
            builder.HasOne(m => m.Product).WithMany(m => m.ProductMedias).HasForeignKey(m => m.ProductID);
        }
    }
}
