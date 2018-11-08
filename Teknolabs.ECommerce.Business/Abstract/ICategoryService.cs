using System.Collections.Generic;
using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
