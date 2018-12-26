using APIs.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class ProductManage
    {
        public int RecordCount { get; set; }
        /// <summary>
        /// 根据ID查询单个产品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(string id)
        {
            RecordCount = ProductDAO.RecordCount;
            return ProductDAO.GetProductById(id);
        }

        /// <summary>
        /// 获取所有产品列表
        /// </summary>
        /// <returns></returns>
        public List<Product> ProductList()
        {
            RecordCount = ProductDAO.RecordCount;
            return ProductDAO.GetAllProducts();
        }

        /// <summary>
        /// 分页获取产品列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        internal List<Product> ProductListPage(int pageIndex, int pageSize)
        {
            RecordCount = ProductDAO.RecordCount;
            List<Product> allProducts = ProductDAO.GetAllProducts();
            List<Product> result = allProducts.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return result;
        }
    }
}
