using APIs.Logic;
using APIs.Model;
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
    public class PVController :ApiController
    {
        [Route("api/pv")]
        public ResResult GetPV()
        {
            return new ResResult
            {
                ResultList = PVManage.PVList(),
                ReturnCode = "0000",
                ReturnMsg = "Success",
                RecordCount = PVManage.recordCount,
            };
        }
    }
}
