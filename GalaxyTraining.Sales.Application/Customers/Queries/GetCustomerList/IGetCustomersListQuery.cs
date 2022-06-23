using System.Collections.Generic;

namespace GalaxyTraining.Sales.Application.Customers.Queries.GetCustomerList
{
    public interface IGetCustomersListQuery
    {
        List<CustomerModel> Execute();
    }
}