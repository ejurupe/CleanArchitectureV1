using System;
using System.Web.Mvc;
using GalaxyTraining.Sales.Application.Customers.Queries.GetCustomerList;

namespace GalaxyTraining.Sales.Presentation.Customers
{
    public class CustomersController : Controller
    {
        private readonly IGetCustomersListQuery _query;

        public CustomersController(IGetCustomersListQuery query)
        {
            _query = query;
        }

        public ViewResult Index()
        {
            var customers = _query.Execute();

            return View(customers);
        }
    }
}