using APIs.DataAccess;
using APIs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs.Logic
{
    public static class PVManage
    {
        public static int recordCount;
        public static List<PV> PVList()
        {
            recordCount = PVDAO.recordCount;
            return PVDAO.GetAllPV();
        }
    }
}
