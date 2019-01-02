using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs.Model
{
    public class PV
    {
        public PV(DateTime date, int pvcount)
        {
            Date = date;
            PvCount = pvcount;
        }
        public DateTime Date { get; set; }
        public int PvCount { get; set; }
    }
}
