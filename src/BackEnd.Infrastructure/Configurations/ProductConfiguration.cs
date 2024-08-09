using BackEnd.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEnd.Infrastructure.Configurations;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Produts");

        builder.HasKey(product => product.Id);

        builder.Property(product => product.Name).HasMaxLength(50).IsRequired();

        builder.Property(product => product.Description).HasMaxLength(500).IsRequired();

        builder.Property(product => product.Price).HasColumnType("decimal(18,2)").IsRequired();

        builder.Property(product => product.Name).IsRequired();
    }
}
