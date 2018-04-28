using System.Collections.ObjectModel;

namespace EFTuts.Data.Repository.Domain
{
    public class Category
    {
        public Category()
        {
            Products = new ObservableCollection<Product>();
        }
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ObservableCollection<Product> Products { get; set; }
    }
}
