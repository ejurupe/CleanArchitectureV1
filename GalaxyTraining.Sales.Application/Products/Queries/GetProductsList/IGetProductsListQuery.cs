using System.Collections.Generic;

namespace GalaxyTraining.Sales.Application.Products.Queries.GetProductsList
{
    public interface IGetProductsListQuery
    {
        List<ProductModel> Execute();
    }
}