using System.Data.Entity;
using GalaxyTraining.Sales.Domain.Customers;
using GalaxyTraining.Sales.Domain.Employees;
using GalaxyTraining.Sales.Domain.Products;
using GalaxyTraining.Sales.Domain.Sales;

namespace GalaxyTraining.Sales.Application.Interfaces
{
    public interface IDatabaseService
    {
        IDbSet<Customer> Customers { get; set; }

        IDbSet<Employee> Employees { get; set; }
        
        IDbSet<Product> Products { get; set; }
        
        IDbSet<Sale> Sales { get; set; }

        void Save();
    }
}