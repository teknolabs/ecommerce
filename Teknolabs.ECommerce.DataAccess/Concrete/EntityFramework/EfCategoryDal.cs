using Teknolabs.Core.DataAccess.EntityFramework;
using Teknolabs.ECommerce.DataAccess.Abstract;
using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ECommerceContext>, ICategoryDal
    {
    }
}
