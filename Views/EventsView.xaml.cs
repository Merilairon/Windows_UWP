﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows_UWP.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows_UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EventsView : Page
    {

        public EventsViewModel EventsViewModel { get; set; } = new EventsViewModel();
        public EventsView()
        {
            this.InitializeComponent();
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await EventsViewModel.LoadDataAsync();
            BusinessGridView.ItemsSource = new ObservableCollection<BusinessViewModel>(EventsViewModel.BusinessViewModel);
            if(EventsViewModel.BusinessViewModel.Count() == 0)
            {
                ValidationEmpty.Visibility = Visibility.Visible;
            }
        }
    }
}
