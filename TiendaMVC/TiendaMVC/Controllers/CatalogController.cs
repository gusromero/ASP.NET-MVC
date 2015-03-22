using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TiendaMVC.Models;

namespace TiendaMVC.Controllers
{
    public class CatalogController : ApiController
    {
        public IEnumerable<Product> Get(int pageNumber)
        {
            using (StoreModel model = new StoreModel())
            {
                return model.Products.Take(6 * pageNumber).ToList().Skip(6 * (pageNumber - 1)).Take(6);
            }
        }

        public int GetTotalPages()
        {
            using (StoreModel model = new StoreModel())
            {
                int elements = model.Products.Count();
                int total = elements % 6 == 0 ? elements / 6 : (elements / 6) + 1;
                return total;
            }
        }

        [HttpPost]
        public void AddProductToCart(int productId)
        {
            var session = System.Web.HttpContext.Current.Session;
            List<int> products = null;

            if (session["cart"] != null)
                products = (List<int>)session["cart"];
            else
                products = new List<int>();
            products.Add(productId);

            session["cart"] = products;
        }
    }
}
