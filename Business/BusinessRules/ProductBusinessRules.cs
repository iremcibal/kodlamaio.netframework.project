using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class ProductBusinessRules
    {
        IProductDal _productDal;
        
        public ProductBusinessRules(IProductDal productDal)
        {
            this._productDal = productDal;
        }
      
        public void CheckIfProductExist(Product product)
        {
            if (product == null)
            {
                throw new Exception("Brand not be exist");
            }
        }

        public void CheckIfProductNotExist(Product product)
        {
            if (product != null)
            {
                throw new Exception("Brand already exist");
            }
        }

        public void CheckIfProductExist(int productId)
        {
            Product product = _productDal.GetById(productId);
            CheckIfProductExist(product);
        }

        public void CheckIfProductNameExist(string productName)
        {
            Product product = _productDal.GetByName(productName);
            CheckIfProductNotExist(product);
        }



    }
}
