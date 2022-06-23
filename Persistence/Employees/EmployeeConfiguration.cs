using GalaxyTraining.Sales.Domain.Employees;
using System.Data.Entity.ModelConfiguration;

namespace GalaxyTraining.Sales.Persistence.Employees
{
    public class EmployeeConfiguration
           : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
