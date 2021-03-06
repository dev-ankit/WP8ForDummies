﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AzureMobile.Resources;
using Microsoft.WindowsAzure.MobileServices;

namespace AzureMobile
{
    public partial class MainPage : PhoneApplicationPage
    {
        //TODO Use Your Application url and key Here
        public static MobileServiceClient MobileService = new MobileServiceClient(
            "UrlGivenByAzure",
            "ApplicationKeyGivenByAzure"
        );
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            BillBoard b = new BillBoard();
            b.Message = InputBox.Text;
            await MobileService.GetTable<BillBoard>().InsertAsync(b);
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<BillBoard> notices = await MobileService.GetTable<BillBoard>().ToListAsync();
            NoticeBox.ItemsSource = notices;
        }
    }
}