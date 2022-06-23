using System;
using System.Collections.Generic;
using System.Linq;
using GalaxyTraining.Sales.Application.Interfaces;
using GalaxyTraining.Sales.Common.Dates;
using StructureMap;
using StructureMap.Graph;

namespace GalaxyTraining.Sales.Specification.Common
{
    public static class IoC
    {
        public static IContainer Initialize(AppContext appContext)
        {
            ObjectFactory.Initialize(x =>
            {
                SetScanningPolicy(x);

                x.For<IDatabaseService>()
                    .Use(appContext.DatabaseService);

                x.For<IInventoryService>()
                    .Use(appContext.InventoryService);

                x.For<IDateService>()
                    .Use(appContext.DateService);

            });

            return ObjectFactory.Container;
        }

        private static void SetScanningPolicy(IInitializationExpression x)
        {
            x.Scan(scan =>
            {
                scan.AssembliesFromApplicationBaseDirectory(
                    filter => filter.FullName.StartsWith("GalaxyTraining.Sales"));

                scan.WithDefaultConventions();
            });
        }
    }
}
