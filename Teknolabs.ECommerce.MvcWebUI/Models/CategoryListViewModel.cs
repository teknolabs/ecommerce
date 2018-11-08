using System.Collections.Generic;
using Teknolabs.ECommerce.Entities.Concrete;

namespace Teknolabs.ECommerce.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
