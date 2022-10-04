using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
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
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.products.ToList();
            }
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Product request)
        {
            throw new NotImplementedException();
        }
    }
}
