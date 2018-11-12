using System.Collections.Generic;
using Teknolabs.ECommerce.Entities.Concrete;


namespace Teknolabs.ECommerce.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categodyId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product productId);
        Product GetById(int productId);
    }
}
