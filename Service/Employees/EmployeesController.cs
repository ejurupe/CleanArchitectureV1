using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using GalaxyTraining.Sales.Application.Employees.Queries.GetEmployeesList;

namespace GalaxyTraining.Sales.Service.Employees
{
    public class EmployeesController : ApiController
    {
        private readonly IGetEmployeesListQuery _query;

        public EmployeesController(IGetEmployeesListQuery query)
        {
            _query = query;
        }

        public IEnumerable<EmployeeModel> Get()
        {
            return _query.Execute();
        }
    }
}