using System.Collections.Generic;
using Teknolabs.ECommerce.Business.Abstract;
using Teknolabs.ECommerce.DataAccess.Abstract;
using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product productId)
        {
            _productDal.Delete(productId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
