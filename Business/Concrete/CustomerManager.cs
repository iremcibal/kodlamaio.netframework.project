﻿using AutoMapper;
using Business.Abstract;
using Business.Request.Customer;
using Business.Response.Customer;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        private IMapper _mapper;

        public CustomerManager(ICustomerDal customerDal, IMapper mapper)
        {
            _customerDal = customerDal;
            _mapper = mapper;
        }

        public void Add(CreateCustomerRequest request)
        {
            Customer customer = _mapper.Map<Customer>(request);
            _customerDal.Add(customer);
        }

        public void Delete(DeleteCustomerRequest request)
        {
            Customer customer = _customerDal.Get(c=>c.CustomerID == request.CustomerID);
            _customerDal.Delete(customer);
        }

        public GetCustomerResponse Get(string id)
        {
            var result = _customerDal.Get(p => p.CustomerID == id);
            var response = _mapper.Map<GetCustomerResponse>(result);
            return response;
        }

        public List<ListCustomerResponse> GetAll()
        {
            List<Customer> customers = _customerDal.GetAll();
            List<ListCustomerResponse> list = _mapper.Map<List<ListCustomerResponse>>(customers);
            return list;
        }

        public void Update(UpdateCustomerRequest request)
        {
            Customer customer = _customerDal.Get(c => c.CustomerID == request.CustomerID);
            if(customer!=null)
            _customerDal.Update(customer);
        }
    }
}
