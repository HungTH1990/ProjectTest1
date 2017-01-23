using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
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

        public IHttpActionResult PostAddToProduct([FromBody] Product product)
        {
            int id = product.id;
            string name = product.Name;
            string price = product.Price;
            products.Add(new Product { id = id, Name = name, Price = price });
            return CreatedAtRoute("DefaultApi",id=product.id,product);
        }

        public void PutModifyToProduct([FromBody] Product product)
        {
            int id = product.id;
            string name = product.Name;
            string price = product.Price;
            products.Add(new Product { id = id, Name = name, Price = price });
        }
        public void DeleteToProduct([FromBody] int id)
        {
            for (int i = 0; i < products.Count;i++ )
            {
                if(id==products[i].id)
                {
                    products.RemoveAt(i);
                }
            }
        }
    }
}
