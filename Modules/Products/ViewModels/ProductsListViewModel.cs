using Prism.Mvvm;

namespace Products.ViewModels
{
    public class ProductsListViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ProductsListViewModel()
        {
            Message = "View All Products from your Products Module";
        }
    }
}
