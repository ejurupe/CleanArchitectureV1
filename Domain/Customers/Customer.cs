using GalaxyTraining.Sales.Domain.Common;

namespace GalaxyTraining.Sales.Domain.Customers
{
    public class Customer : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
