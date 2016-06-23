using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        public Product GetProductById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Products.FirstOrDefault(x => x.ID == id);
            }
        }


        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product { ID=1,Description="Cristal",Price=3.0,CreateDate=DateTime.Now },
                new Product { ID=2,Description="Pilsen",Price=0.0,CreateDate=null }
            };
        }
    }
}
