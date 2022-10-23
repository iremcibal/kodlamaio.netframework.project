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
    public class ProductMapperProfiles : Profile
    {
        public ProductMapperProfiles()
        {
            CreateMap<CreateProductRequest, Product>()
                .ForMember(p=>p.ProductID,config=>config.MapFrom(p=>p.ID))
                .ForMember(p=>p.ProductName,config=>config.MapFrom(p=>p.Name));
            CreateMap<UpdateProductRequest, Product>()
                .ForMember(p => p.ProductName, config => config.MapFrom(p => p.Name))
                .ForMember(p => p.ProductID, config => config.MapFrom(p => p.ID));
            CreateMap<Product, GetProductResponse>()
                .ForMember(p => p.ID, config => config.MapFrom(p => p.ProductID))
                .ForMember(p => p.Name, config => config.MapFrom(p => p.ProductName))
                .ForMember(p => p.UnitPrice, config => config.MapFrom(p => p.UnitPrice));
            CreateMap<Product, ListProductResponse>()
                .ForMember(p=>p.ID,config=>config.MapFrom(p=>p.ProductID))
                .ForMember(p => p.Name, config => config.MapFrom(p => p.ProductName))
                .ForMember(p => p.UnitPrice, config => config.MapFrom(p => p.UnitPrice));
            CreateMap<DeleteProductRequest, Product>()
                .ForMember(p=>p.ProductID, config=>config.MapFrom(p=>p.Id));
        }
    } 
}
