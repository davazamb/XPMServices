using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XPMServices.Classes;
using XPMServices.Pages;
using XPMServices.Services;

namespace XPMServices.ViewModels
{
    public class MainViewModel
    {
        #region Attributes
        private NavigationService navigationService;
        #endregion

        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public ObservableCollection<Service> Services { get; set; }
        #endregion
        #region Constructors
        public MainViewModel()
        {
            navigationService = new NavigationService();
            LoadMenu();
            //LoadData();
        }
        #endregion
        #region Commands
        public ICommand GoToCommand { get { return new RelayCommand<string>(GoTo); } }

        private void GoTo(string pageName)
        {
            navigationService.Navigate(pageName);
        }
        public ICommand StartCommand { get { return new RelayCommand(Start); } }

        private void Start()
        {
            navigationService.SetMainPage(new MasterPage());
        }

        #endregion

        #region Methods


        //private void LoadData()
        //{
        //    Services = new ObservableCollection<Service>();
        //    Services.Clear();

        //    foreach (var Service in Services)
        //    {
        //        Services.Add(new Service
        //        {
        //            DateRegistered = Service.DateRegistered,
        //            Product = Service.Product,
        //            Quantity = Service.Quantity,
        //            Price = Service.Value,
        //        });
        //    }
        //    navigationService.SetMainPage(new MasterPage());
        //}


        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_orders.png",
                PageName = "ProductPage",
                Title = "Productos",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_client.png",
                PageName = "ConsultPage",
                Title = "Consultas",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_settings.png",
                PageName = "SettingsPage",
                Title = "Ajustes",
            });
        }
        #endregion
    }    

}
