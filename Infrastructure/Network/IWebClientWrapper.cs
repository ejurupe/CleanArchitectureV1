using System;
using System.Collections.Generic;
using System.Linq;

namespace GalaxyTraining.Sales.Infrastructure.Network
{
    public interface IWebClientWrapper
    {
        void Post(string address, string json);
    }
}