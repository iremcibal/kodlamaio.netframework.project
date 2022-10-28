using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Request.Product
{
    public class UpdateProductRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CategoryID { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitPrice { get; set; }
    }
}
