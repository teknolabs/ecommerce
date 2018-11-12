using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);

    }
}
