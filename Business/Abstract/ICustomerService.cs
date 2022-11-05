using Business.Request.Customer;
using Business.Response.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<ListCustomerResponse> GetAll();
        GetCustomerResponse Get(string id);
        void Add(CreateCustomerRequest request);
        void Update(UpdateCustomerRequest request);
        void Delete(DeleteCustomerRequest request);
    }
}
