using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class Product
    {
        public Product(string id, string name, string remark = "test")
        {
            Id = id;
            Name = name;
            Remark = remark;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
    }
}
