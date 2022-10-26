using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Request.Product
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        public string CategoryID { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitPrice { get; set; }
    }
}
