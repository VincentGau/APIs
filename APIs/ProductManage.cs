using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class ProductManage
    {
        public List<Product> ProductList()
        {
            List<Product> l = new List<Product>();
            l.Add(new Product(1, "lala"));
            l.Add(new Product(2, "haha"));
            return l;
        }
    }
}
