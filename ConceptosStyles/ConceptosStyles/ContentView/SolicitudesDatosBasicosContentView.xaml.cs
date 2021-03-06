﻿using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConceptosStyles.ContentView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SolicitudesDatosBasicosContentView : Xamarin.Forms.ContentView
    {
        public SolicitudesDatosBasicosContentView()
        {
            InitializeComponent();
        }


        private async void DireccionPopUp(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            var page = new DireccionContentView();
            await Navigation.PushPopupAsync(page);
        }

    }
}