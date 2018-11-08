using System;
using System.Collections.Generic;
using System.Text;
using Teknolabs.Core.DataAccess;
using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {

    }
}
