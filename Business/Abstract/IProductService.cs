using Business.Request.Product;
using Business.Response.Product;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<ListProductResponse> GetAll();
        GetProductResponse GetById(int id);
        void Add(CreateProductRequest request);  
        void Update(UpdateProductRequest request);
        void Delete(DeleteProductRequest request);
    }
}
