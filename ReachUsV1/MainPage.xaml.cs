using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using ReachUsV1.Resources;

namespace ReachUsV1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        void GotoLocation(double lat, double lng, String name)
        {
            MapsDirectionsTask mdt = new MapsDirectionsTask();
            GeoCoordinate gpsLocation = new GeoCoordinate(lat, lng);
            LabeledMapLocation mapLocation = new LabeledMapLocation(name, gpsLocation);
            mdt.End = mapLocation;
            mdt.Show();
        }
        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            GotoLocation(28.7530, 077.7626, "Office 1");
        }

        private void Grid_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
           GotoLocation(28.5510, 077.2539, "Office 2");
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
    }
}