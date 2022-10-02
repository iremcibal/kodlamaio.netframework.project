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
    public class AdoCategoryDal : ICategoryDal
    {
        public List<Category> GetAll()
        {
            List<Category> categories = DbHelper.CreateReadCommand<Category>("select * from categories");
            
            return categories;

        }
    }
}
