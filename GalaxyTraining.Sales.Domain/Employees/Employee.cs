using GalaxyTraining.Sales.Domain.Common;

namespace GalaxyTraining.Sales.Domain.Employees
{
    public class Employee : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
