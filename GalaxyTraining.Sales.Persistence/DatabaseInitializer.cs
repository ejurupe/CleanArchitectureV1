using GalaxyTraining.Sales.Domain.Customers;
using GalaxyTraining.Sales.Domain.Employees;
using GalaxyTraining.Sales.Domain.Products;
using GalaxyTraining.Sales.Domain.Sales;
using System;
using System.Data.Entity;
using System.Linq;

namespace GalaxyTraining.Sales.Persistence
{
    public class DatabaseInitializer 
        : CreateDatabaseIfNotExists<DatabaseService>
    {
        protected override void Seed(DatabaseService database)
        {
            base.Seed(database);

            CreateCustomers(database);

            CreateEmployees(database);

            CreateProducts(database);
            
            CreateSales(database);
        }

        private void CreateCustomers(DatabaseService database)
        {
            database.Customers.Add(new Customer() { Name = "Jose Liza" });

            database.Customers.Add(new Customer() { Name = "Miguel Salvador" });

            database.Customers.Add(new Customer() { Name = "Sarai Carhuayo" });

            database.SaveChanges();
        }

        private void CreateEmployees(DatabaseService database)
        {
            database.Employees.Add(new Employee() { Name = "Alberto Diaz" });

            database.Employees.Add(new Employee() { Name = "Rosario Chavez" });

            database.Employees.Add(new Employee() { Name = "Sarai Carhuayo" });

            database.SaveChanges();
        }

        private void CreateProducts(DatabaseService database)
        {
            database.Products.Add(new Product() { Name = "Celular", Price = 3500m });

            database.Products.Add(new Product() { Name = "Laptop", Price = 6500m });

            database.Products.Add(new Product() { Name = "TV", Price = 8000m });

            database.SaveChanges();
        }

        private void CreateSales(DatabaseService database)
        {
            var customers = database.Customers.ToList();

            var employees = database.Employees.ToList();

            var products = database.Products.ToList();

            database.Sales.Add(new Sale()
            {
                Date = DateTime.Now.Date.AddDays(-3),
                Customer = customers[0],
                Employee = employees[0],
                Product = products[0],
                UnitPrice = 5m,
                Quantity = 1
            });

            database.Sales.Add(new Sale()
            {
                Date = DateTime.Now.Date.AddDays(-2),
                Customer = customers[1],
                Employee = employees[1],
                Product = products[1],
                UnitPrice = 10m,
                Quantity = 2
            });

            database.Sales.Add(new Sale()
            {
                Date = DateTime.Now.Date.AddDays(-1),
                Customer = customers[2],
                Employee = employees[2],
                Product = products[2],
                UnitPrice = 15m,
                Quantity = 3
            });

            database.SaveChanges();
        }
    }
}
