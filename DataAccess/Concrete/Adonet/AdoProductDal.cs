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
        public void Add(Product request)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product request)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = DbHelper.CreateReadCommand<Product>("select * from Products");

            return products;
        }

        public Product GetById(int id)
        {
            Product product = DbHelper.CreateReadCommand<Product>($"select * from Products where productId ='{id}'").FirstOrDefault();

            return product;
        }

        public void Update(Product request)
        {
            throw new NotImplementedException();
        }
    }
}
