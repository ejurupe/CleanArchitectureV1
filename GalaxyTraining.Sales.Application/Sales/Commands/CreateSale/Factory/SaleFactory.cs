using System;
using System.Collections.Generic;
using System.Linq;
using GalaxyTraining.Sales.Domain.Customers;
using GalaxyTraining.Sales.Domain.Employees;
using GalaxyTraining.Sales.Domain.Products;
using GalaxyTraining.Sales.Domain.Sales;

namespace GalaxyTraining.Sales.Application.Sales.Commands.CreateSale.Factory
{
    public class SaleFactory : ISaleFactory
    {
        public Sale Create(DateTime date, Customer customer, Employee employee, Product product, int quantity)
        {
            var sale = new Sale();

            sale.Date = date;

            sale.Customer = customer;

            sale.Employee = employee;

            sale.Product = product;

            sale.UnitPrice = sale.Product.Price;

            sale.Quantity = quantity;

            // Note: Total price is calculated in domain logic

            return sale;
        }
    }
}
