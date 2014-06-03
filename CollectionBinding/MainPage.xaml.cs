using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CollectionBinding
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        ObservableCollection<String> firstCollection = new ObservableCollection<string>();
        ObservableCollection<Person> personCollection = new ObservableCollection<Person>();
        public MainPage()
        {
            InitializeComponent();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            firstCollection.Add("My Item 1");
            firstCollection.Add("My Item 2");
            firstCollection.Add("My Item 3");
            firstCollection.Add("My Item 4");
            FirstListBox.ItemsSource = firstCollection;
            personCollection.Add(new Person("Ankit", "https://pbs.twimg.com/profile_images/424009531408920576/f-8F_WVc_normal.jpeg"));
            personCollection.Add(new Person("Ankit", "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xpf1/t1.0-1/p160x160/1656097_10202038641180974_1393328449_n.jpg"));
            SecondListBox.ItemsSource = personCollection;
        }
    }
}