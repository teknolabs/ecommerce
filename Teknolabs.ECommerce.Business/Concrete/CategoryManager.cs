using System.Collections.Generic;
using Teknolabs.ECommerce.Business.Abstract;
using Teknolabs.ECommerce.DataAccess.Abstract;
using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
