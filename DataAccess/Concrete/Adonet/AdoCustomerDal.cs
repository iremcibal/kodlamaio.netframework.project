using Core.DataAccess.Adonet.Helpers;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Adonet
{
    public class AdoCustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            int affectedRowCount = DbHelper.CreateWriteConnection("Insert into Customers(CustomerID,CompanyName , Country, Phone, IdentityNumber,FirstName, LastName, BirthDate) " +
                "values (@CustomerID,@CompanyName,@Country, @Phone, @IdentityNumber, @FirstName, @LastName, @BirthDate)", entity);
            if (affectedRowCount == 0) throw new Exception("No affected row");
        }

        public void Delete(Customer entity)
        {
            int affectedRowCount = DbHelper.CreateWriteConnection("Delete from Products where CustomerID = @CustomerID", entity);
            if (affectedRowCount == 0) throw new Exception("No affected row");
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            List<Customer> customers = DbHelper.CreateReadCommand<Customer>("select * from Customers");
            return filter != null ? customers.AsQueryable().FirstOrDefault(filter) : customers.FirstOrDefault();
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            List<Customer> customers = DbHelper.CreateReadCommand<Customer>("select * from customers");

            return filter != null ? customers = customers.AsQueryable().Where(filter).ToList() : customers;
        }

        public void Update(Customer entity)
        {
            int affectedRowCount = DbHelper.CreateWriteConnection("Update Customers set CompanyName = @CompanyName, " +
                "  Country= @Country, Phone= @Phone,IdentityNumber = @IdentityNumber," +
                "FirstName=@FirstName, LastName=@LastName, BirthDate=@BirthDate  where CustomerID=@CustomerID", entity);
            if (affectedRowCount == 0) throw new Exception("No affected row");
        }
    }
}
