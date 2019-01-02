using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIs
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class ProductsController:ApiController 
    {
        // GET api/getproducts
        [HttpGet]
        [Route("api/values/getproducts")]
        public ProductResult GetProducts()
        {
            ProductResult result = new ProductResult();
            ProductManage manage = new ProductManage();

            List<Product> resultList = manage.ProductList();
            result.ResultList = resultList;
            result.ReturnCode = "0000";
            result.ReturnMsg = "Return Message";
            result.RecordCount = manage.RecordCount;

            return result;
        }

        //[HttpGet]
        //[Route("api/getproductspage")]
        public ProductResult GetProductsPage(string page, string pagesize)
        {
            ProductResult result = new ProductResult();
            ProductManage manage = new ProductManage();

            int pageIndex, pageSize;

            pageIndex = Convert.ToInt32(page);
            pageSize = Convert.ToInt32(pagesize);


            List<Product> resultList = manage.ProductListPage(pageIndex, pageSize);
            result.ResultList = resultList;
            result.ReturnCode = "0000";
            result.ReturnMsg = "Return Message";
            result.RecordCount = manage.RecordCount;

            return result;
        }
    }
}
