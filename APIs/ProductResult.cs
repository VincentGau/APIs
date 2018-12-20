using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class ProductResult
    {
        public ProductResult()
        {
            ReturnCode = "0000";
            ReturnMsg = "";
        }
        public string ReturnMsg { get; set; }
        public string ReturnCode { get; set; }
        public Object ResultList { get; set; }
    }
}
