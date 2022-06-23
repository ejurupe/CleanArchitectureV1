using System;
using System.Collections.Generic;
using System.Linq;

namespace GalaxyTraining.Sales.Application.Interfaces
{
    public interface IInventoryService
    {
        void NotifySaleOcurred(int productId, int quantity);
    }
}
