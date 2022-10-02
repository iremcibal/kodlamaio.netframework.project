using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class ProductBusinessRules
    {
        IProductDal productDal;
        
        public ProductBusinessRules(IProductDal productDal)
        {
            this.productDal = productDal;
        }




    }
}
