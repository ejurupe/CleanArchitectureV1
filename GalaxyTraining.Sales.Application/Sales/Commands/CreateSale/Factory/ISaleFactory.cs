using System;
using System.Collections.Generic;
using System.Linq;
using GalaxyTraining.Sales.Domain.Customers;
using GalaxyTraining.Sales.Domain.Employees;
using GalaxyTraining.Sales.Domain.Products;
using GalaxyTraining.Sales.Domain.Sales;

namespace GalaxyTraining.Sales.Application.Sales.Commands.CreateSale.Factory
{
    public interface ISaleFactory
    {
        Sale Create(DateTime date, Customer customer, Employee employee, Product product, int quantity);
    }
}