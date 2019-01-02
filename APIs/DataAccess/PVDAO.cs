using APIs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs.DataAccess
{
    public static class PVDAO
    {
        public static int recordCount = 1000;
        public static List<PV> GetAllPV()
        {
            List<PV> result = new List<PV>();
            DateTime now = DateTime.Now;
            Random ran = new Random();
            
            for (int i = 0; i < 1000; i++)
            {
                result.Add(new PV(now.AddDays(-i), ran.Next(10000, 20000)));
            }
            return result;
        }
    }
}
