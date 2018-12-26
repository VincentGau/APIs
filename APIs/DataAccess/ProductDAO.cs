using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs.DataAccess
{
    public static class ProductDAO
    {
        public static int RecordCount = 0;
        public static Product GetProductById(string id)
        {
            RecordCount = 1;
            return new Product(id, "haku");
        }

        public static List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            for (int i = 1; i < 123; i++)
            {
                allProducts.Add(new Product(i.ToString(), string.Format("name-{0}", i)));
            }
            RecordCount = allProducts.Count();
            return allProducts;
        }
    }
}
