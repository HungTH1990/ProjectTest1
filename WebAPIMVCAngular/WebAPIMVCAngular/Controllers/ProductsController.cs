using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIMVCAngular.Models;

namespace WebAPIMVCAngular.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>();
        public IEnumerable<Product> GetAllProducts()
        {
            GetProducts();
            return products;
        }

        private void GetProducts()
        {
            products.Add(new Product { id = 1, Name = "Iphone 5", Price = "10 Trieu dong" });
            products.Add(new Product { id = 2, Name = "Iphone 6", Price = "12 Trieu dong" });
            products.Add(new Product { id = 3, Name = "Iphone 7", Price = "15 Trieu dong" });
            products.Add(new Product { id = 4, Name = "Iphone 8", Price = "19 Trieu dong" });
        }
        public IEnumerable<Product> GetProducts(int selectedid)
        {
            if (products.Count() > 0)
            {
                return products.Where(p => p.id == selectedid);
            }
            else
            {
                GetProducts();
                return products.Where(p => p.id == selectedid);
            }
        }
    }
}
