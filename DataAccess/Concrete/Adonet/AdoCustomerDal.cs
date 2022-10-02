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
    public class AdoCustomerDal : ICustomerDal
    {
        public List<Customer> GetAll()
        {
            List<Customer> customers = DbHelper.CreateReadCommand<Customer>("select * from customers");
            return customers;
        }
    }
}
