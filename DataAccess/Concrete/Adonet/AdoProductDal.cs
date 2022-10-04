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
        public void Add(Product product)
        {
            int affectedRowCount = DbHelper.CreateWriteConnection("Insert into Products(ProductName,CategoryID) values (@ProductName,@CategoryID)", product);
            if (affectedRowCount == 0) throw new Exception("No affected row");
        }

        public void Delete(Product product)
        {
            int affectedRowCount = DbHelper.CreateWriteConnection("Delete from Products where ProductID = @ProductID", product);
            if (affectedRowCount == 0) throw new Exception("No affected row");
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

        public void Update(Product product)
        {
            int affectedRowCount = DbHelper.CreateWriteConnection("Update Products set ProductName = @ProductName, " +
                " UnitsInStock = @UnitsInStock where productID=@ProductID", product);
            if (affectedRowCount == 0) throw new Exception("No affected row");
        }

        public Product GetByName(string name)
        {
            Product product = DbHelper.CreateReadCommand<Product>($"select * from Products where ProductName='{name}'").FirstOrDefault();

            return product;
        }
    }
}
