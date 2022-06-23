using GalaxyTraining.Sales.Domain.Sales;
using System.Data.Entity.ModelConfiguration;

namespace GalaxyTraining.Sales.Persistence.Sales
{
    public class SaleConfiguration
           : EntityTypeConfiguration<Sale>
    {
        public SaleConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Date)
                .IsRequired();

            HasRequired(p => p.Customer);

            HasRequired(p => p.Employee);

            HasRequired(p => p.Product);

            Property(p => p.TotalPrice)
                .IsRequired()
                .HasPrecision(7, 2);
        }
    }
}
