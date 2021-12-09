﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biodiversity.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantDetailPage : ContentPage
    {
        public PlantDetailPage(Plant plantItem)
        {
            InitializeComponent();
            BindingContext = plantItem; 
        }

        void OnLocationClicked(object sender, EventArgs e)
        {
            var location = new Location(80, 80);
            Xamarin.Essentials.Map.OpenAsync(location);
        }
    }
}