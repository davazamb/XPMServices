﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPMServices.Pages;

namespace XPMServices.Services
{
    public class NavigationService
    {
        public async void Navigate(string PageName)
        {
            App.Master.IsPresented = false;

            switch (PageName)
            {
                case "ProductPage":
                    await App.Navigator.PushAsync(new ProductPage());
                    break;
                case "ConsultPage":
                    await App.Navigator.PushAsync(new ConsultPage());
                    break;
                case "SettingsPage":
                    await App.Navigator.PushAsync(new SettingsPage());
                    break;
                case "NewProductPage":
                    await App.Navigator.PushAsync(new NewProductPage());
                    break;
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
                default:
                    break;
            }
        }

        internal void SetMainPage(MasterPage masterPage)
        {
            throw new NotImplementedException();
        }
    }

}
