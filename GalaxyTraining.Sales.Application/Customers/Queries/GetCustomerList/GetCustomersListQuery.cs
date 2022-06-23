using System;
using System.Collections.Generic;
using System.Linq;
using GalaxyTraining.Sales.Application.Interfaces;

namespace GalaxyTraining.Sales.Application.Customers.Queries.GetCustomerList
{
    public class GetCustomersListQuery 
        : IGetCustomersListQuery
    {
        private readonly IDatabaseService _database;

        public GetCustomersListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<CustomerModel> Execute()
        {
            var customers = _database.Customers
                .Select(p => new CustomerModel()
                {
                    Id = p.Id, 
                    Name = p.Name
                });

            return customers.ToList();
        }
    }
}
