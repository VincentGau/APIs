using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class ProductManage
    {
        private static List<Product> allProducts = new List<Product>();
        private void Init()
        {
            for (int i = 1; i < 123; i++)
            {
                allProducts.Add(new Product(i, string.Format("name-{0}", i)));
            }
        }

        public List<Product> ProductList()
        {
            Init();
            return allProducts;
        }

        internal List<Product> ProductListPage(int pageIndex, int pageSize)
        {
            Init();
            List<Product> result = allProducts.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return result;
        }
    }
}
