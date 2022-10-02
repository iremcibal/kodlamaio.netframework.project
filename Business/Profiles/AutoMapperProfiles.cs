using AutoMapper;
using Business.Request.Product;
using Business.Response.Product;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CreateProductRequest, Product>();
            CreateMap<UpdateProductRequest, Product>();
            CreateMap<Product, GetProductResponse>()
                .ForMember(p => p.ID, config => config.MapFrom(p => p.ProductID))
                .ForMember(p => p.Name, config => config.MapFrom(p => p.ProductName))
                .ForMember(p => p.UnitPrice, config => config.MapFrom(p => p.UnitPrice));
            CreateMap<List<Product>, List<ListProductResponse>>();
        }
    }
}
