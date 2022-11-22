using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Inlamning.Helpers;

namespace _03_Inlamning.Models.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public RelayCommand CustomersViewCommand { get; set; }
        public RelayCommand CreateCustomerViewCommand { get; set;}
        public RelayCommand ErrandsViewCommand { get; set; }
        public RelayCommand CreateErrandViewCommand { get; set; }
        public CustomersViewModel CustomersViewModel { get; set; }
        public CreateCustomerViewModel CreateCustomerViewModel { get; set; }
        public ErrandsViewModel ErrandsViewModel { get; set; }
        public CreateErrandViewModel CreateErrandViewModel { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set 
            {
                _currentView = value; 
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            
            CustomersViewModel = new CustomersViewModel();
            CreateCustomerViewModel = new CreateCustomerViewModel();
            ErrandsViewModel = new ErrandsViewModel();
            CreateErrandViewModel = new CreateErrandViewModel();

            CurrentView = CreateCustomerViewModel;

            CustomersViewCommand = new RelayCommand(x => CurrentView = CustomersViewModel);
            CreateCustomerViewCommand = new RelayCommand(x => CurrentView = CreateCustomerViewModel);
            ErrandsViewCommand = new RelayCommand(x => CurrentView = ErrandsViewModel);
            CreateErrandViewCommand = new RelayCommand(x => CurrentView = CreateErrandViewModel);
        }

    }
}
