using GalaxyTraining.Sales.Domain.Products;
using System.Data.Entity.ModelConfiguration;

namespace GalaxyTraining.Sales.Persistence.Products
{
    public class ProductConfiguration
           : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Price)
                .IsRequired()
                .HasPrecision(7, 2);
        }
    }
}
