using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Product;
using Business.Response.Product;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private ProductBusinessRules _productBusinessRules;
        private IMapper _mapper;

        public ProductManager(IProductDal productDal, ProductBusinessRules productBusinessRules, IMapper mapper)
        {
            this._productDal = productDal;
            this._productBusinessRules = productBusinessRules;
            this._mapper = mapper;
        }

        public void Add(CreateProductRequest request)
        {
            //_productBusinessRules.CheckIfCategoryNameExists(request.Name);
            Product product = _mapper.Map<Product>(request);
            _productDal.Add(product);
        }

        public void Delete(DeleteProductRequest request)
        {
            Product product = _mapper.Map<Product>(request);
            _productDal.Delete(product);
        }

        public List<ListProductResponse> GetAll()
        {
            List<Product> products = _productDal.GetAll();
            List<ListProductResponse> list = _mapper.Map<List<ListProductResponse>>(products);
            return list;
        }

        public GetProductResponse GetById(string id)
        {
            var result = _productDal.Get(p => p.ProductID == id);
            //_productBusinessRules.
            var response = _mapper.Map<GetProductResponse>(result);
            return response;

        }

        public void Update(UpdateProductRequest request)
        {
            Product product = _mapper.Map<Product>(request);
            _productDal.Update(product);
        }
    }
}
