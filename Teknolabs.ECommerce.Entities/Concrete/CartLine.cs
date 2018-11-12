using System.Linq;

namespace Teknolabs.ECommerce.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

}
