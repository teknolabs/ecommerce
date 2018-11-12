using System.Collections.Generic;
using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveToCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
