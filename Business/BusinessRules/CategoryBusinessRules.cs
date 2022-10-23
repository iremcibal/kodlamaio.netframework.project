using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CategoryBusinessRules
    {
        ICategoryDal _categoryDal;

        public CategoryBusinessRules(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CheckIfCategoryNotExist(Category category)
        {
            if (category == null) throw new Exception("Category not be exist");
        }

        public void CheckIfCategoryExist(Category category)
        {
            if (category != null) throw new Exception("Category already exist");
        }
    }
}
