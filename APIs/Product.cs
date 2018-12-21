using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs
{
    public class Product
    {
        public Product(int id, string name)
        {
            Id = id;
            Name = name;
            Remark = "test";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
    }
}
