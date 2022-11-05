using AutoMapper;
using Business.Request.Customer;
using Business.Response.Customer;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CustomerMapperProfiles : Profile
    {
        public CustomerMapperProfiles()
        {
            CreateMap<CreateCustomerRequest, Customer>();
            CreateMap<DeleteCustomerRequest, Customer>();
            CreateMap<UpdateCustomerRequest, Customer>();
            CreateMap<Customer, GetCustomerResponse>();
            CreateMap<Customer, ListCustomerResponse>();

        }
    }
}
