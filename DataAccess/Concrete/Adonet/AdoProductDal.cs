using Core.DataAccess.Adonet.Helpers;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Adonet
{
    public class AdoProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            List<Product> products = DbHelper.CreateReadCommand<Product>("select * from Products");

            return products;
        }
    }
}
