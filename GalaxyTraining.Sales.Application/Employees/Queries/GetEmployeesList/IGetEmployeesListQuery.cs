using System.Collections.Generic;

namespace GalaxyTraining.Sales.Application.Employees.Queries.GetEmployeesList
{
    public interface IGetEmployeesListQuery
    {
        List<EmployeeModel> Execute();
    }
}