using System;
using System.Collections.Generic;
using DemoApp.ViewModel;
using Xamarin.Forms;

namespace DemoApp.View
{
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
			BindingContext = new ItemsFileViewModel();
        }
    }
}