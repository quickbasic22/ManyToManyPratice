using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinBreakAwayGreekAdventures.Models;
using XamarinBreakAwayGreekAdventures.ViewModels;

namespace XamarinBreakAwayGreekAdventures.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Destination Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}