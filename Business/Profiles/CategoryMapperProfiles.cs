using AutoMapper;
using Business.Request.Category;
using Business.Response.Category;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CategoryMapperProfiles : Profile
    {
        public CategoryMapperProfiles()
        {
            CreateMap<CreateCategoryRequest, Category>();
            CreateMap<DeleteCategoryRequest, Category>();
            CreateMap<UpdateCategoryRequest, Category>();
            CreateMap<Category,GetCategoryResponse>();
            CreateMap<Category, ListCategoryResponse>();

        }
    }
}
