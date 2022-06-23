using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using GalaxyTraining.Sales.Application.Products.Queries.GetProductsList;

namespace GalaxyTraining.Sales.Service.Products
{
    public class ProductsController : ApiController
    {
        private readonly IGetProductsListQuery _query;

        public ProductsController(IGetProductsListQuery query)
        {
            _query = query;
        }

        public IEnumerable<ProductModel> Get()
        {
            return _query.Execute();
        }
    }
}