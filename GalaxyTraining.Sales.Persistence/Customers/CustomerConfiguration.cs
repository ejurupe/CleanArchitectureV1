using GalaxyTraining.Sales.Domain.Customers;
using System.Data.Entity.ModelConfiguration;

namespace GalaxyTraining.Sales.Persistence.Customers
{
    public class CustomerConfiguration 
        : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
