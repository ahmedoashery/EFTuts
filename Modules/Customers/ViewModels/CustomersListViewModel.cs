using System.Collections.Generic;
using System.Collections.ObjectModel;
using EFTuts.Data.Repository.Domain;
using EFTuts.Data.Repository.UnitOfWork;
using Prism.Mvvm;

namespace Modules.Customers.ViewModels
{
    public class CustomersListViewModel : BindableBase
    {
        private ObservableCollection<Customer> _customers;

        public CustomersListViewModel()
        {
            DataContext context = new DataContext();
            UnitOfWork uof = new UnitOfWork(context);

            uof.Customers.GetAll();
            Customers = uof.Customers.CustomersObser();
        }

        public ObservableCollection<Customer> Customers
        {
            get {return _customers;}
            set { SetProperty(ref _customers, value); }
        }
    }
}
