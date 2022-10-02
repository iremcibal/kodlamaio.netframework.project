using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Delete(Product request);
        void Update(Product request);
        void Add(Product request);
    }
}
