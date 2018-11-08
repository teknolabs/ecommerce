using Teknolabs.Core.Entities;

namespace Teknolabs.ECommerce.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
