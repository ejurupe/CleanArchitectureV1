using GalaxyTraining.Sales.Application.Interfaces;
using GalaxyTraining.Sales.Domain.Customers;
using GalaxyTraining.Sales.Domain.Employees;
using GalaxyTraining.Sales.Domain.Products;
using GalaxyTraining.Sales.Domain.Sales;
using GalaxyTraining.Sales.Persistence.Customers;
using GalaxyTraining.Sales.Persistence.Employees;
using GalaxyTraining.Sales.Persistence.Products;
using GalaxyTraining.Sales.Persistence.Sales;
using System.Data.Entity;


namespace GalaxyTraining.Sales.Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public IDbSet<Customer> Customers { get; set; }

        public IDbSet<Employee> Employees { get; set; }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<Sale> Sales { get; set; }

        public DatabaseService() : base("cnnSales")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new SaleConfiguration());
        }
    }
}
