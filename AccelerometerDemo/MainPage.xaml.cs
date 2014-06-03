using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Devices.Sensors;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AccelerometerDemo.Resources;

namespace AccelerometerDemo
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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!Accelerometer.IsSupported)
            {
                StatusBlock.Text = "Accelerometer not supported";
            }
            else
            {
                Accelerometer accel = new Accelerometer();
                accel.TimeBetweenUpdates = TimeSpan.FromMilliseconds(100);
                accel.CurrentValueChanged += accel_CurrentValueChanged;
                accel.Start();
            }
        }

        void accel_CurrentValueChanged(object sender, SensorReadingEventArgs<AccelerometerReading> e)
        {
            var acceleration = e.SensorReading.Acceleration;
            Dispatcher.BeginInvoke(() =>
            {
                XBlock.Text = "X: " + acceleration.X.ToString("0.00");
                YBlock.Text = "Y: " + acceleration.Y.ToString("0.00");
                ZBlock.Text = "Z: " + acceleration.Z.ToString("0.00");
            });
        }

        void Abc()
        {
            Dispatcher.BeginInvoke(Abc);

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