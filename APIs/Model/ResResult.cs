using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs.Model
{
    public class ResResult
    {
        public string ReturnMsg { get; set; }
        public string ReturnCode { get; set; }
        public int RecordCount { get; set; }
        public Object ResultList { get; set; }
    }
}
