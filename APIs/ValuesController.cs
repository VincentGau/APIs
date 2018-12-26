using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIs
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        //[EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/getproducts
        [EnableCors(origins: "*", headers: "*", methods: "*")]
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

        // GET api/values/5 
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
