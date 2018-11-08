using System;
using System.Collections.Generic;
using System.Text;
using Teknolabs.Core.DataAccess.EntityFramework;
using Teknolabs.ECommerce.DataAccess.Abstract;
using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceContext>, IProductDal
    {
    }
}
