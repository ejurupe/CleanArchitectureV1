using System;
using System.Web.Mvc;
using GalaxyTraining.Sales.Application.Employees.Queries.GetEmployeesList;

namespace GalaxyTraining.Sales.Presentation.Employees
{
    public class EmployeesController : Controller
    {
        private readonly IGetEmployeesListQuery _query;

        public EmployeesController(IGetEmployeesListQuery query)
        {
            _query = query;
        }

        public ViewResult Index()
        {
            var employees = _query.Execute();

            return View(employees);
        }
    }
}