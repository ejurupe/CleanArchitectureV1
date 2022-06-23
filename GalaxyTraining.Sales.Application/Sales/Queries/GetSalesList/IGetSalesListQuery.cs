using System.Collections.Generic;

namespace GalaxyTraining.Sales.Application.Sales.Queries.GetSalesList
{
    public interface IGetSalesListQuery
    {
        List<SalesListItemModel> Execute();
    }
}